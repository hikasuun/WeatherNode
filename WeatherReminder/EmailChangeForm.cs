using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WeatherReminder
{
    public partial class EmailChangeForm : Form
    {
        private BaseForm form;
        public EmailChangeForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            // checks for valid input
            if (String.IsNullOrEmpty(EmailTxtBox.Text) || 
                !IsValidEmail(EmailTxtBox.Text)) {
                MessageBox.Show("Please enter valid email.");
            }
            else
            {
                MailAddress userEmail = new MailAddress(EmailTxtBox.Text.ToLower());
                form.setUserEmail(userEmail);
                MessageBox.Show("Email Changed Successfully.");
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            EmailTxtBox.Clear();
            this.Close();
        }

        // uses MailAddress class to validate if inputted email is valid
        private bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
