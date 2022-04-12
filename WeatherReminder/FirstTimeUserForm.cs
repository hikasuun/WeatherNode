/*
 * FirstTimeUserForm.cs
 * Language: C#
 * Form that appears when user is running application 
 * for the first time
 * January 2022 - April 2022
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
    public partial class FirstTimeUserForm : Form
    {
        private BaseForm form;
        
        public FirstTimeUserForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void FirstTimeUserForm_Load(object sender, EventArgs e)
        {
        }

        // Clears email and name txt boxes
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTxtBox.Clear();
            EmailTxtBox.Clear();
        }

        // Enter user's name and email into application
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            // check if txt boxes are empty or email is valid
            if (String.IsNullOrEmpty(NameTxtBox.Text) ||
                String.IsNullOrEmpty(EmailTxtBox.Text) ||
                !IsValidEmail(EmailTxtBox.Text))
            {
                MessageBox.Show("Please enter valid email / username.");
            }
            else
            {
                // save user input
                string userName = NameTxtBox.Text;
                MailAddress userEmail = new MailAddress(EmailTxtBox.Text.ToLower());

                form.setUserName(userName);
                form.setUserEmail(userEmail);
                this.Close();
            }
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
