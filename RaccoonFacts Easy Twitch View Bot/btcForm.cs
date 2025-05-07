using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaccoonFacts_Easy_Twitch_View_Bot
{
    public partial class btcForm : Form
    {
        public btcForm()
        {
            InitializeComponent();
        }

        private void copyBTCButton_Click(object sender, EventArgs e)
        {
            copyLink(btcAddTxtBx.Text);

        }
        private void ETHCopyBtn_Click(object sender, EventArgs e)
        {
            copyLink(ETHTxtBx.Text);
        }
        private void dogeCopyBtn_Click(object sender, EventArgs e)
        {
            copyLink(dogeTxtBx.Text);
        }

        private void copyLink(String link)
        {
            Clipboard.SetText(link);
            MessageBox.Show("Copied to clipboard", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
    }
}
