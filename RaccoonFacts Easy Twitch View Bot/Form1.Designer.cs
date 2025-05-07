namespace RaccoonFacts_Easy_Twitch_View_Bot
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.usernameTxtBx = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.botCountNUD = new System.Windows.Forms.NumericUpDown();
            this.botNUDLbl = new System.Windows.Forms.Label();
            this.IntervalNUD = new System.Windows.Forms.NumericUpDown();
            this.IntervalNUDLbl = new System.Windows.Forms.Label();
            this.LogTxtBx = new System.Windows.Forms.TextBox();
            this.LogLbl = new System.Windows.Forms.Label();
            this.staggerChkBx = new System.Windows.Forms.CheckBox();
            this.extraFrmBtn = new System.Windows.Forms.Button();
            this.mainBar = new System.Windows.Forms.ProgressBar();
            this.loadingLbl = new System.Windows.Forms.Label();
            this.chkBoxSpoof = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.botCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(27, 454);
            this.startBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(266, 140);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(424, 454);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(266, 140);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(20, 43);
            this.usernameTxtBx.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(667, 29);
            this.usernameTxtBx.TabIndex = 2;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(15, 14);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(159, 22);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Twitch Username: ";
            // 
            // botCountNUD
            // 
            this.botCountNUD.Location = new System.Drawing.Point(26, 151);
            this.botCountNUD.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.botCountNUD.Name = "botCountNUD";
            this.botCountNUD.Size = new System.Drawing.Size(150, 29);
            this.botCountNUD.TabIndex = 4;
            // 
            // botNUDLbl
            // 
            this.botNUDLbl.AutoSize = true;
            this.botNUDLbl.Location = new System.Drawing.Point(20, 124);
            this.botNUDLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.botNUDLbl.Name = "botNUDLbl";
            this.botNUDLbl.Size = new System.Drawing.Size(148, 22);
            this.botNUDLbl.TabIndex = 5;
            this.botNUDLbl.Text = "Number Of Bots:";
            // 
            // IntervalNUD
            // 
            this.IntervalNUD.Location = new System.Drawing.Point(233, 151);
            this.IntervalNUD.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.IntervalNUD.Name = "IntervalNUD";
            this.IntervalNUD.Size = new System.Drawing.Size(267, 29);
            this.IntervalNUD.TabIndex = 6;
            // 
            // IntervalNUDLbl
            // 
            this.IntervalNUDLbl.AutoSize = true;
            this.IntervalNUDLbl.Location = new System.Drawing.Point(227, 124);
            this.IntervalNUDLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IntervalNUDLbl.Name = "IntervalNUDLbl";
            this.IntervalNUDLbl.Size = new System.Drawing.Size(276, 22);
            this.IntervalNUDLbl.TabIndex = 7;
            this.IntervalNUDLbl.Text = "Refresh Interval + Random Time:";
            // 
            // LogTxtBx
            // 
            this.LogTxtBx.Location = new System.Drawing.Point(717, 43);
            this.LogTxtBx.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.LogTxtBx.Multiline = true;
            this.LogTxtBx.Name = "LogTxtBx";
            this.LogTxtBx.ReadOnly = true;
            this.LogTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTxtBx.Size = new System.Drawing.Size(352, 550);
            this.LogTxtBx.TabIndex = 8;
            // 
            // LogLbl
            // 
            this.LogLbl.AutoSize = true;
            this.LogLbl.Location = new System.Drawing.Point(713, 14);
            this.LogLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(46, 22);
            this.LogLbl.TabIndex = 9;
            this.LogLbl.Text = "Log:";
            // 
            // staggerChkBx
            // 
            this.staggerChkBx.AutoSize = true;
            this.staggerChkBx.Location = new System.Drawing.Point(26, 239);
            this.staggerChkBx.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.staggerChkBx.Name = "staggerChkBx";
            this.staggerChkBx.Size = new System.Drawing.Size(288, 26);
            this.staggerChkBx.TabIndex = 11;
            this.staggerChkBx.Text = "Longer Times Between Each Bot";
            this.staggerChkBx.UseVisualStyleBackColor = true;
            this.staggerChkBx.CheckedChanged += new System.EventHandler(this.staggerChkBx_CheckedChanged);
            // 
            // extraFrmBtn
            // 
            this.extraFrmBtn.Location = new System.Drawing.Point(453, 239);
            this.extraFrmBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.extraFrmBtn.Name = "extraFrmBtn";
            this.extraFrmBtn.Size = new System.Drawing.Size(237, 67);
            this.extraFrmBtn.TabIndex = 12;
            this.extraFrmBtn.Text = "Extra Tools/Help";
            this.extraFrmBtn.UseVisualStyleBackColor = true;
            this.extraFrmBtn.Click += new System.EventHandler(this.extraFrmBtn_Click);
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.Green;
            this.mainBar.Location = new System.Drawing.Point(27, 407);
            this.mainBar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.mainBar.Name = "mainBar";
            this.mainBar.Size = new System.Drawing.Size(540, 30);
            this.mainBar.TabIndex = 13;
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.Location = new System.Drawing.Point(23, 377);
            this.loadingLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(143, 22);
            this.loadingLbl.TabIndex = 14;
            this.loadingLbl.Text = "Bots Remaining:";
            // 
            // chkBoxSpoof
            // 
            this.chkBoxSpoof.AutoSize = true;
            this.chkBoxSpoof.Location = new System.Drawing.Point(27, 280);
            this.chkBoxSpoof.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chkBoxSpoof.Name = "chkBoxSpoof";
            this.chkBoxSpoof.Size = new System.Drawing.Size(208, 26);
            this.chkBoxSpoof.TabIndex = 15;
            this.chkBoxSpoof.Text = "Spoof Program Name";
            this.chkBoxSpoof.UseVisualStyleBackColor = true;
            this.chkBoxSpoof.CheckedChanged += new System.EventHandler(this.chkBoxSpoof_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1084, 603);
            this.Controls.Add(this.chkBoxSpoof);
            this.Controls.Add(this.loadingLbl);
            this.Controls.Add(this.mainBar);
            this.Controls.Add(this.extraFrmBtn);
            this.Controls.Add(this.staggerChkBx);
            this.Controls.Add(this.LogLbl);
            this.Controls.Add(this.LogTxtBx);
            this.Controls.Add(this.IntervalNUDLbl);
            this.Controls.Add(this.IntervalNUD);
            this.Controls.Add(this.botNUDLbl);
            this.Controls.Add(this.botCountNUD);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTxtBx);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Form1";
            this.Text = "Raccoon Facts Twitch View Botter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.botCountNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox usernameTxtBx;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.NumericUpDown botCountNUD;
        private System.Windows.Forms.Label botNUDLbl;
        private System.Windows.Forms.NumericUpDown IntervalNUD;
        private System.Windows.Forms.Label IntervalNUDLbl;
        private System.Windows.Forms.TextBox LogTxtBx;
        private System.Windows.Forms.Label LogLbl;
        private System.Windows.Forms.CheckBox staggerChkBx;
        private System.Windows.Forms.Button extraFrmBtn;
        private System.Windows.Forms.ProgressBar mainBar;
        private System.Windows.Forms.Label loadingLbl;
        private System.Windows.Forms.CheckBox chkBoxSpoof;
    }
}

