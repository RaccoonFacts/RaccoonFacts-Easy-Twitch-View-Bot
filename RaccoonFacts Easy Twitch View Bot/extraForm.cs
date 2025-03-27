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
    }
}
