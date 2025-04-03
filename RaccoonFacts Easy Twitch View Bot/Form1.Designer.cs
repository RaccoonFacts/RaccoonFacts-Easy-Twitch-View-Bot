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
            this.ProxyCheckBx = new System.Windows.Forms.CheckBox();
            this.staggerChkBx = new System.Windows.Forms.CheckBox();
            this.extraFrmBtn = new System.Windows.Forms.Button();
            this.mainBar = new System.Windows.Forms.ProgressBar();
            this.loadingLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.botCountNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(12, 373);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(159, 82);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(212, 373);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(159, 82);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // usernameTxtBx
            // 
            this.usernameTxtBx.Location = new System.Drawing.Point(12, 25);
            this.usernameTxtBx.Name = "usernameTxtBx";
            this.usernameTxtBx.Size = new System.Drawing.Size(402, 20);
            this.usernameTxtBx.TabIndex = 2;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(9, 9);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(96, 13);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Twitch Username: ";
            // 
            // botCountNUD
            // 
            this.botCountNUD.Location = new System.Drawing.Point(15, 89);
            this.botCountNUD.Name = "botCountNUD";
            this.botCountNUD.Size = new System.Drawing.Size(90, 20);
            this.botCountNUD.TabIndex = 4;
            // 
            // botNUDLbl
            // 
            this.botNUDLbl.AutoSize = true;
            this.botNUDLbl.Location = new System.Drawing.Point(12, 73);
            this.botNUDLbl.Name = "botNUDLbl";
            this.botNUDLbl.Size = new System.Drawing.Size(85, 13);
            this.botNUDLbl.TabIndex = 5;
            this.botNUDLbl.Text = "Number Of Bots:";
            // 
            // IntervalNUD
            // 
            this.IntervalNUD.Location = new System.Drawing.Point(139, 89);
            this.IntervalNUD.Name = "IntervalNUD";
            this.IntervalNUD.Size = new System.Drawing.Size(160, 20);
            this.IntervalNUD.TabIndex = 6;
            // 
            // IntervalNUDLbl
            // 
            this.IntervalNUDLbl.AutoSize = true;
            this.IntervalNUDLbl.Location = new System.Drawing.Point(136, 73);
            this.IntervalNUDLbl.Name = "IntervalNUDLbl";
            this.IntervalNUDLbl.Size = new System.Drawing.Size(163, 13);
            this.IntervalNUDLbl.TabIndex = 7;
            this.IntervalNUDLbl.Text = "Refresh Interval + Random Time:";
            // 
            // LogTxtBx
            // 
            this.LogTxtBx.Location = new System.Drawing.Point(539, 25);
            this.LogTxtBx.Multiline = true;
            this.LogTxtBx.Name = "LogTxtBx";
            this.LogTxtBx.ReadOnly = true;
            this.LogTxtBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTxtBx.Size = new System.Drawing.Size(324, 415);
            this.LogTxtBx.TabIndex = 8;
            // 
            // LogLbl
            // 
            this.LogLbl.AutoSize = true;
            this.LogLbl.Location = new System.Drawing.Point(536, 9);
            this.LogLbl.Name = "LogLbl";
            this.LogLbl.Size = new System.Drawing.Size(28, 13);
            this.LogLbl.TabIndex = 9;
            this.LogLbl.Text = "Log:";
            // 
            // ProxyCheckBx
            // 
            this.ProxyCheckBx.AutoSize = true;
            this.ProxyCheckBx.Location = new System.Drawing.Point(12, 164);
            this.ProxyCheckBx.Name = "ProxyCheckBx";
            this.ProxyCheckBx.Size = new System.Drawing.Size(164, 17);
            this.ProxyCheckBx.TabIndex = 10;
            this.ProxyCheckBx.Text = "Try All Proxies (Coming Soon)";
            this.ProxyCheckBx.UseVisualStyleBackColor = true;
            // 
            // staggerChkBx
            // 
            this.staggerChkBx.AutoSize = true;
            this.staggerChkBx.Location = new System.Drawing.Point(12, 141);
            this.staggerChkBx.Name = "staggerChkBx";
            this.staggerChkBx.Size = new System.Drawing.Size(182, 17);
            this.staggerChkBx.TabIndex = 11;
            this.staggerChkBx.Text = "Longer Times Between Each Bot";
            this.staggerChkBx.UseVisualStyleBackColor = true;
            // 
            // extraFrmBtn
            // 
            this.extraFrmBtn.Location = new System.Drawing.Point(271, 141);
            this.extraFrmBtn.Name = "extraFrmBtn";
            this.extraFrmBtn.Size = new System.Drawing.Size(143, 40);
            this.extraFrmBtn.TabIndex = 12;
            this.extraFrmBtn.Text = "Extra Tools/Help";
            this.extraFrmBtn.UseVisualStyleBackColor = true;
            this.extraFrmBtn.Click += new System.EventHandler(this.extraFrmBtn_Click);
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.Green;
            this.mainBar.Location = new System.Drawing.Point(539, 458);
            this.mainBar.Name = "mainBar";
            this.mainBar.Size = new System.Drawing.Size(324, 17);
            this.mainBar.TabIndex = 13;
            // 
            // loadingLbl
            // 
            this.loadingLbl.AutoSize = true;
            this.loadingLbl.Location = new System.Drawing.Point(536, 442);
            this.loadingLbl.Name = "loadingLbl";
            this.loadingLbl.Size = new System.Drawing.Size(84, 13);
            this.loadingLbl.TabIndex = 14;
            this.loadingLbl.Text = "Bots Remaining:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 487);
            this.Controls.Add(this.loadingLbl);
            this.Controls.Add(this.mainBar);
            this.Controls.Add(this.extraFrmBtn);
            this.Controls.Add(this.staggerChkBx);
            this.Controls.Add(this.ProxyCheckBx);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.CheckBox ProxyCheckBx;
        private System.Windows.Forms.CheckBox staggerChkBx;
        private System.Windows.Forms.Button extraFrmBtn;
        private System.Windows.Forms.ProgressBar mainBar;
        private System.Windows.Forms.Label loadingLbl;
    }
}

