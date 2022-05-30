namespace SoundTyping
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelSample = new System.Windows.Forms.Panel();
            this.panelInform = new System.Windows.Forms.Panel();
            this.labelMissCountValue = new System.Windows.Forms.Label();
            this.labelClearCountValue = new System.Windows.Forms.Label();
            this.labelMissCountTitle = new System.Windows.Forms.Label();
            this.labelClearCountTitle = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.changeWords = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScore = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.scoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelInform.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSample
            // 
            this.panelSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSample.Location = new System.Drawing.Point(127, 153);
            this.panelSample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(665, 55);
            this.panelSample.TabIndex = 0;
            // 
            // panelInform
            // 
            this.panelInform.Controls.Add(this.labelMissCountValue);
            this.panelInform.Controls.Add(this.labelClearCountValue);
            this.panelInform.Controls.Add(this.labelMissCountTitle);
            this.panelInform.Controls.Add(this.labelClearCountTitle);
            this.panelInform.Location = new System.Drawing.Point(822, 145);
            this.panelInform.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelInform.Name = "panelInform";
            this.panelInform.Size = new System.Drawing.Size(236, 61);
            this.panelInform.TabIndex = 1;
            // 
            // labelMissCountValue
            // 
            this.labelMissCountValue.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMissCountValue.Location = new System.Drawing.Point(143, 29);
            this.labelMissCountValue.Name = "labelMissCountValue";
            this.labelMissCountValue.Size = new System.Drawing.Size(94, 29);
            this.labelMissCountValue.TabIndex = 3;
            this.labelMissCountValue.Text = "0";
            this.labelMissCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClearCountValue
            // 
            this.labelClearCountValue.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearCountValue.Location = new System.Drawing.Point(143, 0);
            this.labelClearCountValue.Name = "labelClearCountValue";
            this.labelClearCountValue.Size = new System.Drawing.Size(94, 29);
            this.labelClearCountValue.TabIndex = 2;
            this.labelClearCountValue.Text = "0";
            this.labelClearCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMissCountTitle
            // 
            this.labelMissCountTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMissCountTitle.Location = new System.Drawing.Point(0, 29);
            this.labelMissCountTitle.Name = "labelMissCountTitle";
            this.labelMissCountTitle.Size = new System.Drawing.Size(128, 29);
            this.labelMissCountTitle.TabIndex = 1;
            this.labelMissCountTitle.Text = "ミスタイプ";
            this.labelMissCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelClearCountTitle
            // 
            this.labelClearCountTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearCountTitle.Location = new System.Drawing.Point(0, 0);
            this.labelClearCountTitle.Name = "labelClearCountTitle";
            this.labelClearCountTitle.Size = new System.Drawing.Size(128, 29);
            this.labelClearCountTitle.TabIndex = 0;
            this.labelClearCountTitle.Text = "クリア";
            this.labelClearCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWords,
            this.changeScore});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1104, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // changeWords
            // 
            this.changeWords.Name = "changeWords";
            this.changeWords.Size = new System.Drawing.Size(110, 20);
            this.changeWords.Text = "単語帳を変更 (&W)";
            this.changeWords.Click += new System.EventHandler(this.changeWords_Click);
            // 
            // changeScore
            // 
            this.changeScore.Name = "changeScore";
            this.changeScore.Size = new System.Drawing.Size(93, 20);
            this.changeScore.Text = "楽譜を変更 (&S)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1104, 502);
            this.Controls.Add(this.panelInform);
            this.Controls.Add(this.panelSample);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.panelInform.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelSample;
        private Panel panelInform;
        private Label labelMissCountValue;
        private Label labelClearCountValue;
        private Label labelMissCountTitle;
        private Label labelClearCountTitle;
        private MenuStrip menuStrip;
        private ToolStripMenuItem changeWords;
        private ToolStripMenuItem changeScore;
        private OpenFileDialog wordsFileDialog;
        private OpenFileDialog scoreFileDialog;
    }
}