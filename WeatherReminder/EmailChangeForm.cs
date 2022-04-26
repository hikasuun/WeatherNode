/*
 * EmailChangeForm.cs
 * Language : C#
 * Form for changing user email address
 * January 2022 - 
 */
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

namespace WeatherNode
{
    public partial class EmailChangeForm : Form
    {
        private BaseForm form;
        public EmailChangeForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }
        private void EmailChangeForm_Load(object sender, EventArgs e)
        {
        }

        // Change user email function
        private void EnterButton_Click(object sender, EventArgs e)
        {
            // checks for valid email input
            if (String.IsNullOrEmpty(EmailTxtBox.Text) || 
                !IsValidEmail(EmailTxtBox.Text) || smtpCombo.SelectedItem == null) {
                MessageBox.Show("Please enter valid email.");
            }
            // if valid, change email
            else
            {
                MailAddress userEmail = new MailAddress(EmailTxtBox.Text.ToLower());
                form.setUserEmail(userEmail);
                form.smtpServer = smtpCombo.SelectedItem.ToString();
                MessageBox.Show("Email Changed Successfully.");
                this.Close();
            }
        }

        // Cancels email change
        private void CancelButton_Click(object sender, EventArgs e)
        {
            EmailTxtBox.Clear();
            this.Close();
        }

        // uses MailAddress class to validate if inputted email is valid
        // Simply checks for char@char
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
