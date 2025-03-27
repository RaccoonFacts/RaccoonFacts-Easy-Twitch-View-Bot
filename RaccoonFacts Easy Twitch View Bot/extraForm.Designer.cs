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
            this.ChromeCleanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChromeCleanBtn
            // 
            this.ChromeCleanBtn.Location = new System.Drawing.Point(12, 46);
            this.ChromeCleanBtn.Name = "ChromeCleanBtn";
            this.ChromeCleanBtn.Size = new System.Drawing.Size(143, 51);
            this.ChromeCleanBtn.TabIndex = 0;
            this.ChromeCleanBtn.Text = "Kill All Chrome Services";
            this.ChromeCleanBtn.UseVisualStyleBackColor = true;
            this.ChromeCleanBtn.Click += new System.EventHandler(this.ChromeCleanBtn_Click);
            // 
            // extraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChromeCleanBtn);
            this.Name = "extraForm";
            this.Text = "extraForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChromeCleanBtn;
    }
}