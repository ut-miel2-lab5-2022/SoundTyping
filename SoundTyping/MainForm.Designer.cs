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
            this.labelRightRateValue = new System.Windows.Forms.Label();
            this.labelRightRateTitle = new System.Windows.Forms.Label();
            this.labelMissCountValue = new System.Windows.Forms.Label();
            this.labelClearCountValue = new System.Windows.Forms.Label();
            this.labelMissCountTitle = new System.Windows.Forms.Label();
            this.labelClearCountTitle = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.changeWords = new System.Windows.Forms.ToolStripMenuItem();
            this.changeScore = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGame = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.scoreFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelNextWord = new System.Windows.Forms.Label();
            this.panelInform.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSample
            // 
            this.panelSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSample.Location = new System.Drawing.Point(99, 179);
            this.panelSample.Name = "panelSample";
            this.panelSample.Size = new System.Drawing.Size(760, 73);
            this.panelSample.TabIndex = 0;
            // 
            // panelInform
            // 
            this.panelInform.Controls.Add(this.labelRightRateValue);
            this.panelInform.Controls.Add(this.labelRightRateTitle);
            this.panelInform.Controls.Add(this.labelMissCountValue);
            this.panelInform.Controls.Add(this.labelClearCountValue);
            this.panelInform.Controls.Add(this.labelMissCountTitle);
            this.panelInform.Controls.Add(this.labelClearCountTitle);
            this.panelInform.Location = new System.Drawing.Point(893, 132);
            this.panelInform.Name = "panelInform";
            this.panelInform.Size = new System.Drawing.Size(311, 117);
            this.panelInform.TabIndex = 1;
            // 
            // labelRightRateValue
            // 
            this.labelRightRateValue.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRightRateValue.Location = new System.Drawing.Point(163, 78);
            this.labelRightRateValue.Name = "labelRightRateValue";
            this.labelRightRateValue.Size = new System.Drawing.Size(148, 39);
            this.labelRightRateValue.TabIndex = 5;
            this.labelRightRateValue.Text = "-- %";
            this.labelRightRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRightRateTitle
            // 
            this.labelRightRateTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRightRateTitle.Location = new System.Drawing.Point(0, 78);
            this.labelRightRateTitle.Name = "labelRightRateTitle";
            this.labelRightRateTitle.Size = new System.Drawing.Size(146, 39);
            this.labelRightRateTitle.TabIndex = 4;
            this.labelRightRateTitle.Text = "成功率";
            this.labelRightRateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMissCountValue
            // 
            this.labelMissCountValue.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMissCountValue.Location = new System.Drawing.Point(163, 39);
            this.labelMissCountValue.Name = "labelMissCountValue";
            this.labelMissCountValue.Size = new System.Drawing.Size(148, 39);
            this.labelMissCountValue.TabIndex = 3;
            this.labelMissCountValue.Text = "0";
            this.labelMissCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClearCountValue
            // 
            this.labelClearCountValue.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearCountValue.Location = new System.Drawing.Point(163, 0);
            this.labelClearCountValue.Name = "labelClearCountValue";
            this.labelClearCountValue.Size = new System.Drawing.Size(148, 39);
            this.labelClearCountValue.TabIndex = 2;
            this.labelClearCountValue.Text = "0";
            this.labelClearCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMissCountTitle
            // 
            this.labelMissCountTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMissCountTitle.Location = new System.Drawing.Point(0, 39);
            this.labelMissCountTitle.Name = "labelMissCountTitle";
            this.labelMissCountTitle.Size = new System.Drawing.Size(146, 39);
            this.labelMissCountTitle.TabIndex = 1;
            this.labelMissCountTitle.Text = "ミスタイプ";
            this.labelMissCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelClearCountTitle
            // 
            this.labelClearCountTitle.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClearCountTitle.Location = new System.Drawing.Point(0, 0);
            this.labelClearCountTitle.Name = "labelClearCountTitle";
            this.labelClearCountTitle.Size = new System.Drawing.Size(146, 39);
            this.labelClearCountTitle.TabIndex = 0;
            this.labelClearCountTitle.Text = "クリア";
            this.labelClearCountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeWords,
            this.changeScore,
            this.resetGame});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1245, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // changeWords
            // 
            this.changeWords.Name = "changeWords";
            this.changeWords.Size = new System.Drawing.Size(137, 24);
            this.changeWords.Text = "単語帳を変更 (&W)";
            this.changeWords.Click += new System.EventHandler(this.changeWords_Click);
            // 
            // changeScore
            // 
            this.changeScore.Name = "changeScore";
            this.changeScore.Size = new System.Drawing.Size(116, 24);
            this.changeScore.Text = "楽譜を変更 (&S)";
            this.changeScore.Click += new System.EventHandler(this.changeScore_Click);
            // 
            // resetGame
            // 
            this.resetGame.Name = "resetGame";
            this.resetGame.Size = new System.Drawing.Size(85, 24);
            this.resetGame.Text = "リセット(&R)";
            this.resetGame.Click += new System.EventHandler(this.resetGame_Click);
            // 
            // wordsFileDialog
            // 
            this.wordsFileDialog.Filter = "単語帳ファイル|*.txt|すべてのファイル|*.*";
            // 
            // scoreFileDialog
            // 
            this.scoreFileDialog.Filter = "MIDI ファイル|*.mid;*.midi|すべてのファイル|*.*";
            // 
            // labelNextWord
            // 
            this.labelNextWord.AutoSize = true;
            this.labelNextWord.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNextWord.Location = new System.Drawing.Point(99, 111);
            this.labelNextWord.Name = "labelNextWord";
            this.labelNextWord.Size = new System.Drawing.Size(93, 40);
            this.labelNextWord.TabIndex = 0;
            this.labelNextWord.Text = "next";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1245, 403);
            this.Controls.Add(this.labelNextWord);
            this.Controls.Add(this.panelInform);
            this.Controls.Add(this.panelSample);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
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
        private Label labelNextWord;
        private Label labelRightRateValue;
        private Label labelRightRateTitle;
        private ToolStripMenuItem resetGame;
    }
}