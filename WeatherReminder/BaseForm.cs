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
    public partial class BaseForm : Form
    {
        private string userName;
        private MailAddress userEmail;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            // TODO: Add first time check
            FirstTimeUserForm frm = new FirstTimeUserForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            WelcomeUserLabel.Text = "Welcome, " + userName;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        // GETTERS AND SETTERS 
        public void setUserName(string userN)
        {
            this.userName = userN;
        }

        public void setUserEmail(MailAddress userE) {
            this.userEmail = userE;
        }

        public string getUserName()
        {
            return this.userName;
        }

        public MailAddress getUserEmail()
        {
            return this.userEmail;
        }

        private void WelcomeUserLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
