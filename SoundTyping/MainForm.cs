using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public MainForm()
        {
            InitializeComponent();
            sampleChars = new LabelArray(22, new Size(35, 70), this.panelSample);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            answer = answers[0];
            sampleChars.Text = answer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // sampleChars.Text = "012345";
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == answer[rightCount])
            {
                sampleChars.SetForeColor(Color.Gray, rightCount);
                sampleChars.SetBackColor(Color.LightGray, rightCount);
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
    }
}
