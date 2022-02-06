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
    public partial class FirstTimeUserForm : Form
    {
        public FirstTimeUserForm()
        {
            InitializeComponent(); 
            // TODO:
            // check if first-time running
            // if first time, show FirstTimeUserForm
            // else show BaseForm
        }

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTxtBox.Clear();
            EmailTxtBox.Clear();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            // check if txt boxes are empty or email is valid, loops if not
            while (String.IsNullOrEmpty(NameTxtBox.Text) || 
                String.IsNullOrEmpty(EmailTxtBox.Text) || 
                !IsValidEmail(EmailTxtBox.Text))
            {
                MessageBox.Show("Please enter valid email / username.");
            }
            // save user input
            string userName = NameTxtBox.Text;
            string userEmail = EmailTxtBox.Text;

            // send user input to base form
            BaseForm baseForm = new BaseForm(userName,userEmail);
            baseForm.Show();
        }

        private void NameTxtBox_TextChanged(object sender, EventArgs e)
        {

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
