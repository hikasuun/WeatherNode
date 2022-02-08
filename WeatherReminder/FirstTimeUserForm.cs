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

        private void EmailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        // Clears email and name txt boxes easily 
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            NameTxtBox.Clear();
            EmailTxtBox.Clear();
        }

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirstTimeUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
