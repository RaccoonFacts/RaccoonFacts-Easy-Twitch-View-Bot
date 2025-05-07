using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoonFacts_Easy_Twitch_View_Bot
{
    public partial class extraForm : Form
    {
        private btcForm btcForm;

        public extraForm()
        {
            InitializeComponent();
        }

        private void ChromeCleanBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var chromeProcess = Process.GetProcessesByName("chrome");
                if(chromeProcess.Any())
                {
                    foreach (var process in chromeProcess)
                    {
                        process.Kill();
                    }
                    MessageBox.Show("All Chrome processes have been terminated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("No Chrome processes are running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.youtube.com/channel/UC0u47g4vunP2ZERk9lwpiAQ?sub_confirmation=1";
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open browser: {ex.Message}");
            }

        }

        private void btcBtn_Click(object sender, EventArgs e)
        {
            if (btcForm == null || btcForm.IsDisposed)
            {
                btcForm = new btcForm();
                btcForm.Show();
            }
            else
            {
                btcForm.Activate();

            }

        }
    }
}
