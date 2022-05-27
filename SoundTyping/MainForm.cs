using NextMidi.MidiPort.Output.Core;
using NextMidi.MidiPort.Output;
using NextMidi.DataElement;

namespace SoundTyping
{
    public partial class MainForm : Form
    {
        private LabelArray sampleChars;
        private string[] answers = new string[] {"I believe.", "Hello, World!"};
        private int rightCount = 0;
        private int missCountSum = 0;
        private int clearCountSum = 0;
        private string answer = "";

        private MidiOutPort? port;
        private int noteCount = 0;
        private byte[] score = { 59, 55, 57, 59, 62, 60, 60, 64, 62, 62, 67, 66, 67, 62, 59, 55, 57, 59, 60, 62, 64, 62, 60, 59, 57, 59, 55, 54, 55, 57, 50, 54, 57, 60, 59, 57 };

        public MainForm()
        {
            InitializeComponent();
            sampleChars = new LabelArray(22, new Size(35, 70), this.panelSample);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            port = new MidiOutPort("Microsoft GS Wavetable Synth");
            port.Open();

            answer = answers[0];
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
            answer = answers[rng.Next(0, 2)];
            rightCount = 0;
            sampleChars.Text = answer;
        }

        private void PlayNext()
        {
            if (port == null) throw new Exception();
            byte nprev = score[(noteCount + score.Length - 1) % score.Length];
            byte n = score[noteCount];
            port.Send(new NoteOffEvent(nprev));
            port.Send(new NoteOnEvent(n, 112));
            noteCount++;
            noteCount %= score.Length;
        }
    }
}
