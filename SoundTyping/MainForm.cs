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

        public MainForm()
        {
            InitializeComponent();
            sampleChars = new LabelArray(22, new Size(35, 70), this.panelSample);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sampleChars.Text = "ABCDEFGHIJKLMNOPQRSTUV";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sampleChars.Text = "0123456789012345678901";
        }
    }
}
