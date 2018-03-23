namespace TMClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabClicker = new System.Windows.Forms.TabPage();
            this.cbUseGoldSteps = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.tabDev = new System.Windows.Forms.TabPage();
            this.pBox2 = new System.Windows.Forms.PictureBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.tbFilename = new System.Windows.Forms.TextBox();
            this.bCapture = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.nHeight = new System.Windows.Forms.NumericUpDown();
            this.nWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nLeft = new System.Windows.Forms.NumericUpDown();
            this.nTop = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkOfficialWebsite = new System.Windows.Forms.LinkLabel();
            this.linkSteam = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabClicker.SuspendLayout();
            this.tabDev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabClicker);
            this.tabControl.Controls.Add(this.tabDev);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 242);
            this.tabControl.TabIndex = 18;
            // 
            // tabClicker
            // 
            this.tabClicker.Controls.Add(this.label8);
            this.tabClicker.Controls.Add(this.label7);
            this.tabClicker.Controls.Add(this.label6);
            this.tabClicker.Controls.Add(this.linkSteam);
            this.tabClicker.Controls.Add(this.linkOfficialWebsite);
            this.tabClicker.Controls.Add(this.label5);
            this.tabClicker.Controls.Add(this.cbUseGoldSteps);
            this.tabClicker.Controls.Add(this.btnRun);
            this.tabClicker.Controls.Add(this.lbLog);
            this.tabClicker.Controls.Add(this.pictureBox1);
            this.tabClicker.Location = new System.Drawing.Point(4, 22);
            this.tabClicker.Name = "tabClicker";
            this.tabClicker.Padding = new System.Windows.Forms.Padding(3);
            this.tabClicker.Size = new System.Drawing.Size(792, 216);
            this.tabClicker.TabIndex = 0;
            this.tabClicker.Text = "Clicker";
            this.tabClicker.UseVisualStyleBackColor = true;
            // 
            // cbUseGoldSteps
            // 
            this.cbUseGoldSteps.AutoSize = true;
            this.cbUseGoldSteps.Location = new System.Drawing.Point(8, 17);
            this.cbUseGoldSteps.Name = "cbUseGoldSteps";
            this.cbUseGoldSteps.Size = new System.Drawing.Size(211, 17);
            this.cbUseGoldSteps.TabIndex = 19;
            this.cbUseGoldSteps.Text = "Use Additional Steps to Get Gold Chest";
            this.cbUseGoldSteps.UseVisualStyleBackColor = true;
            this.cbUseGoldSteps.CheckedChanged += new System.EventHandler(this.cbUseGoldSteps_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(324, 11);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 18;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(426, 11);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(358, 199);
            this.lbLog.TabIndex = 17;
            // 
            // tabDev
            // 
            this.tabDev.Controls.Add(this.pBox2);
            this.tabDev.Controls.Add(this.btnCompare);
            this.tabDev.Controls.Add(this.btnSaveAs);
            this.tabDev.Controls.Add(this.tbFilename);
            this.tabDev.Controls.Add(this.bCapture);
            this.tabDev.Controls.Add(this.pBox);
            this.tabDev.Controls.Add(this.nHeight);
            this.tabDev.Controls.Add(this.nWidth);
            this.tabDev.Controls.Add(this.label3);
            this.tabDev.Controls.Add(this.label4);
            this.tabDev.Controls.Add(this.nLeft);
            this.tabDev.Controls.Add(this.nTop);
            this.tabDev.Controls.Add(this.label2);
            this.tabDev.Controls.Add(this.label1);
            this.tabDev.Location = new System.Drawing.Point(4, 22);
            this.tabDev.Name = "tabDev";
            this.tabDev.Padding = new System.Windows.Forms.Padding(3);
            this.tabDev.Size = new System.Drawing.Size(792, 216);
            this.tabDev.TabIndex = 1;
            this.tabDev.Text = "Dev";
            this.tabDev.UseVisualStyleBackColor = true;
            // 
            // pBox2
            // 
            this.pBox2.Location = new System.Drawing.Point(454, 37);
            this.pBox2.Name = "pBox2";
            this.pBox2.Size = new System.Drawing.Size(108, 63);
            this.pBox2.TabIndex = 31;
            this.pBox2.TabStop = false;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(454, 106);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(108, 23);
            this.btnCompare.TabIndex = 30;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(262, 185);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(108, 23);
            this.btnSaveAs.TabIndex = 29;
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // tbFilename
            // 
            this.tbFilename.Location = new System.Drawing.Point(262, 159);
            this.tbFilename.Name = "tbFilename";
            this.tbFilename.Size = new System.Drawing.Size(178, 20);
            this.tbFilename.TabIndex = 28;
            // 
            // bCapture
            // 
            this.bCapture.Location = new System.Drawing.Point(262, 106);
            this.bCapture.Name = "bCapture";
            this.bCapture.Size = new System.Drawing.Size(108, 23);
            this.bCapture.TabIndex = 27;
            this.bCapture.Text = "Capture";
            this.bCapture.UseVisualStyleBackColor = true;
            this.bCapture.Click += new System.EventHandler(this.bCapture_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(262, 37);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(108, 63);
            this.pBox.TabIndex = 26;
            this.pBox.TabStop = false;
            // 
            // nHeight
            // 
            this.nHeight.Location = new System.Drawing.Point(135, 80);
            this.nHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nHeight.Name = "nHeight";
            this.nHeight.Size = new System.Drawing.Size(79, 20);
            this.nHeight.TabIndex = 25;
            this.nHeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nWidth
            // 
            this.nWidth.Location = new System.Drawing.Point(135, 37);
            this.nWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nWidth.Name = "nWidth";
            this.nWidth.Size = new System.Drawing.Size(79, 20);
            this.nWidth.TabIndex = 24;
            this.nWidth.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Width";
            // 
            // nLeft
            // 
            this.nLeft.Location = new System.Drawing.Point(30, 80);
            this.nLeft.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nLeft.Name = "nLeft";
            this.nLeft.Size = new System.Drawing.Size(79, 20);
            this.nLeft.TabIndex = 21;
            // 
            // nTop
            // 
            this.nTop.Location = new System.Drawing.Point(30, 37);
            this.nTop.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nTop.Name = "nTop";
            this.nTop.Size = new System.Drawing.Size(79, 20);
            this.nTop.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Top";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tactical Monsters is Copyright Camex Games 2017";
            // 
            // linkOfficialWebsite
            // 
            this.linkOfficialWebsite.AutoSize = true;
            this.linkOfficialWebsite.Location = new System.Drawing.Point(230, 109);
            this.linkOfficialWebsite.Name = "linkOfficialWebsite";
            this.linkOfficialWebsite.Size = new System.Drawing.Size(81, 13);
            this.linkOfficialWebsite.TabIndex = 21;
            this.linkOfficialWebsite.TabStop = true;
            this.linkOfficialWebsite.Text = "Official Website";
            this.linkOfficialWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkOfficialWebsite_LinkClicked);
            // 
            // linkSteam
            // 
            this.linkSteam.AutoSize = true;
            this.linkSteam.Location = new System.Drawing.Point(317, 109);
            this.linkSteam.Name = "linkSteam";
            this.linkSteam.Size = new System.Drawing.Size(65, 13);
            this.linkSteam.TabIndex = 22;
            this.linkSteam.TabStop = true;
            this.linkSteam.Text = "Steam Page";
            this.linkSteam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSteam_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(8, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 107);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "The Clicker was developed to help getting more points in clan chest challenge.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "The app does not violate any laws or copyrights. It\'s just game\'s fan tool.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(357, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "In case of any copyright issues, please contact the author to resolve them.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TM Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabClicker.ResumeLayout(false);
            this.tabClicker.PerformLayout();
            this.tabDev.ResumeLayout(false);
            this.tabDev.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabClicker;
        private System.Windows.Forms.CheckBox cbUseGoldSteps;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.TabPage tabDev;
        private System.Windows.Forms.PictureBox pBox2;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.TextBox tbFilename;
        private System.Windows.Forms.Button bCapture;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.NumericUpDown nHeight;
        private System.Windows.Forms.NumericUpDown nWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nLeft;
        private System.Windows.Forms.NumericUpDown nTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkOfficialWebsite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkSteam;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

