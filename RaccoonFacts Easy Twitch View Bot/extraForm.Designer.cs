namespace RaccoonFacts_Easy_Twitch_View_Bot
{
    partial class extraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(extraForm));
            this.ChromeCleanBtn = new System.Windows.Forms.Button();
            this.subBtn = new System.Windows.Forms.Button();
            this.helperLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btcBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChromeCleanBtn
            // 
            this.ChromeCleanBtn.Location = new System.Drawing.Point(25, 74);
            this.ChromeCleanBtn.Margin = new System.Windows.Forms.Padding(5);
            this.ChromeCleanBtn.Name = "ChromeCleanBtn";
            this.ChromeCleanBtn.Size = new System.Drawing.Size(238, 86);
            this.ChromeCleanBtn.TabIndex = 0;
            this.ChromeCleanBtn.Text = "Kill All Chrome Services";
            this.ChromeCleanBtn.UseVisualStyleBackColor = true;
            this.ChromeCleanBtn.Click += new System.EventHandler(this.ChromeCleanBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.Location = new System.Drawing.Point(405, 74);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(238, 86);
            this.subBtn.TabIndex = 1;
            this.subBtn.Text = "Subscribe to Youtube";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // helperLbl
            // 
            this.helperLbl.AutoSize = true;
            this.helperLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperLbl.Location = new System.Drawing.Point(58, 47);
            this.helperLbl.Name = "helperLbl";
            this.helperLbl.Size = new System.Drawing.Size(164, 22);
            this.helperLbl.TabIndex = 2;
            this.helperLbl.Text = "     Helper Tools     ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "     Support Creator     ";
            // 
            // btcBtn
            // 
            this.btcBtn.Location = new System.Drawing.Point(405, 170);
            this.btcBtn.Name = "btcBtn";
            this.btcBtn.Size = new System.Drawing.Size(238, 86);
            this.btcBtn.TabIndex = 4;
            this.btcBtn.Text = "Donate Crypto";
            this.btcBtn.UseVisualStyleBackColor = true;
            this.btcBtn.Click += new System.EventHandler(this.btcBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click Consent Non-USA (Coming soon)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 86);
            this.button2.TabIndex = 6;
            this.button2.Text = "Update Chrome/ChromeDriver (Coming Soon)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // extraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(702, 449);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.helperLbl);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.ChromeCleanBtn);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "extraForm";
            this.Text = "Extra Menu";
            this.Load += new System.EventHandler(this.extraForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChromeCleanBtn;
        private System.Windows.Forms.Button subBtn;
        private System.Windows.Forms.Label helperLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btcBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}