using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondStep
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string Key;

        private void btGenerate_Click(object sender, EventArgs e)
        {
            Key = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10);

            keyTextBox.Text = Key;

            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("Test Two Factor", "user@example.com", Key, 300, 300);

            string qrCodeImageUrl = setupInfo.QrCodeSetupImageUrl;
            string manualEntrySetupCode = setupInfo.ManualEntryKey;

            qrBox.Image = setupInfo.QrCodeImage;
            setupBox.Text = setupInfo.ManualEntryKey;
        }

        private void btMatch_Click(object sender, EventArgs e)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var result = tfa.ValidateTwoFactorPIN(Key, inputBox.Text);

            if (result)
            {
                resultLabel.Text = inputBox.Text + " is a valid PIN at UTC time " + DateTime.UtcNow.ToString();
                resultLabel.ForeColor = Color.Green;
            }
            else
            {
                resultLabel.Text = inputBox.Text + " is not a valid PIN at UTC time " + DateTime.UtcNow.ToString();
                resultLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
