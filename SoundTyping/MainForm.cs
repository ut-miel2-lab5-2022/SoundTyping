using NextMidi.MidiPort.Output.Core;
using NextMidi.MidiPort.Output;
using NextMidi.DataElement;
using System.Text.RegularExpressions;

namespace SoundTyping
{
    public partial class MainForm : Form
    {
        const string charsAvailable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!;:,.? ";

        private LabelArray sampleChars;
        private List<string> words = new() { "I believe.", "Hello, World!" };
        private int rightCount = 0;
        private int missCountSum = 0;
        private int clearCountSum = 0;
        private string answer = "";

        private MidiOutPort? port;
        private int noteCount = 0;
        // private byte[] score = { 59, 55, 57, 59, 62, 60, 60, 64, 62, 62, 67, 66, 67, 62, 59, 55, 57, 59, 60, 62, 64, 62, 60, 59, 57, 59, 55, 54, 55, 57, 50, 54, 57, 60, 59, 57 };
        // private byte[] score = { 71, 67, 69, 71, 74, 72, 72, 76, 74, 74, 79, 78, 79, 74, 71, 67, 69, 71, 72, 74, 76, 74, 72, 71, 69, 71, 67, 66, 67, 69, 62, 66, 69, 72, 71, 69, 71, 67, 69, 71, 74, 72, 72, 76, 74, 74, 79, 78, 79, 74, 71, 67, 69, 71, 64, 74, 72, 71, 69, 67, 62, 67, 66, 67, 71, 74, 79, 74, 71, 67, 71, 73, 74, 62, 64, 66, 69, 68, 68, 71, 69, 69, 72, 71, 72, 69, 64, 69, 62, 64, 65, 74, 72, 74, 71, 68, 64, 66, 68, 69, 72, 71, 72, 76, 74, 74, 77, 76, 76, 81, 80, 81, 76, 72, 69, 71, 72, 77, 76, 74, 72, 71, 69, 64, 69, 68, 69, 197, 197, 197, 197, 197, 197, 197, 197 }; // 主よ人の望みの喜びよ
        private byte[] score = {68, 68, 69, 68, 67, 68, 73, 76, 75, 73, 75, 73, 72, 73, 76, 80, 80, 68, 69, 68, 67, 68, 73, 76, 75, 73, 75, 73, 72, 73, 76, 80, 80, 69, 73, 75, 78, 81, 85, 87, 95, 93, 92, 90, 88, 87, 90, 85, 84, 87, 81, 80, 78, 81, 76, 75, 78, 73, 72, 75, 69, 68, 71, 69, 69, 68, 69, 68, 67, 68, 73, 76, 75, 73, 75, 73, 72, 73, 76, 80, 80, 68, 70, 68, 67, 68, 73, 76, 75, 73, 75, 73, 72, 73, 76, 80, 75, 76, 75, 74, 75, 83, 82, 80, 79, 88, 87, 85, 83, 82, 80, 79, 82, 80, 83, 74, 76, 75, 80, 70, 73, 71, 75, 67, 70, 68, 67, 68, 68, 80, 72, 73, 66, 78, 72, 73, 65, 77, 72, 73, 66, 78, 72, 73, 61, 73, 66, 69, 63, 75, 66, 69, 64, 76, 68, 71, 68, 80, 71, 76, 68, 80, 72, 73, 66, 78, 72, 73, 65, 77, 72, 73, 66, 78, 72, 73, 65, 77, 71, 75, 66, 78, 71, 75, 69, 81, 71, 76, 68, 80, 71, 76, 68, 80, 72, 73, 66, 78, 72, 73, 65, 77, 72, 73, 66, 78, 72, 73, 61, 73, 66, 69, 63, 75, 66, 69, 64, 76, 68, 71, 68, 80, 71, 76, 68, 80, 72, 73, 66, 78, 72, 73, 75, 87, 78, 81, 73, 85, 78,
81, 73, 85, 75, 78, 72, 84, 75, 78, 72, 84, 75, 78, 72, 84, 75, 78, 72, 84, 75, 78, 71, 83, 75, 78, 71, 83, 75, 78, 70, 82, 75, 78, 70, 82, 75, 78, 69, 81, 75, 78, 69, 81, 75, 78, 69, 81, 75, 78, 72, 84, 75, 78, 71, 83, 75, 78, 71, 83, 75, 78, 70, 82, 75, 78, 70, 82, 75, 78, 69, 81, 75, 78, 69, 81, 75, 78, 68, 80, 75, 78 }; // 幻想即興曲

        public MainForm()
        {
            InitializeComponent();
            sampleChars = new LabelArray(22, new Size(35, 55), this.panelSample);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            port = new MidiOutPort("Microsoft GS Wavetable Synth");
            port.Open();

            answer = words[0];
            sampleChars.Text = answer;
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == answer[rightCount])
            {
                sampleChars.SetForeColor(Color.Gray, rightCount);
                sampleChars.SetBackColor(Color.LightGray, rightCount);
                PlayNext();
                rightCount++;
            }
            else
            {
                Task.Run(() => { Console.Beep(800, 50); });
                missCountSum++;
                labelMissCountValue.Text = missCountSum.ToString();
            }
            if (rightCount >= answer.Length)
            {
                clearCountSum++;
                labelClearCountValue.Text = clearCountSum.ToString();
                ResetGame();
            };
        }

        private void ResetGame()
        {
            sampleChars.Text = "";
            sampleChars.SetForeColorAll(SystemColors.ControlText);
            sampleChars.SetBackColorAll(SystemColors.Window);
            Random rng = new System.Random();
            answer = words[rng.Next(0, words.Count)];
            rightCount = 0;
            sampleChars.Text = answer;
        }

        private void PlayNext()
        {
            if (port == null) throw new Exception();
            byte nprev = (byte)(score[(noteCount + score.Length - 1) % score.Length] % 128);
            byte n = score[noteCount];
            if (n < 128)
            {
                port.Send(new NoteOffEvent(nprev));
                port.Send(new NoteOnEvent(n, 112));
            }
            noteCount++;
            noteCount %= score.Length;
        }

        private void changeWords_Click(object sender, EventArgs e)
        {
            if (wordsFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> wordsNew = new();
                StreamReader sr = new StreamReader(wordsFileDialog.FileName);
                while (!sr.EndOfStream)
                {
                    string? word = sr.ReadLine();
                    if (word != null && word.Length <= 19 && Regex.IsMatch(word, @"[A-Za-z0-9,.!? ]+"))
                    {
                        wordsNew.Add(word);
                    }
                }

                if (wordsNew.Count > 0)
                {
                    words = wordsNew;
                    ResetGame();
                }
            }
        }
    }
}
