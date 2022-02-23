/*
 * BaseForm.cs
 * Language: C# 
 * Base form for the WeatherNode application
 * Form contains main GUI that user interacts with
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

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripEmailTextBox.Text = getUserEmail().ToString();
        }

        private void BaseFormMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeUserLabel_Click(object sender, EventArgs e)
        {

        }

        // Deletion of selected notification
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // confirm user deletion
            //
            var confirmResult = MessageBox.Show("Do you wish to delete this entry?",
                "Confirm Deletion", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                // Delete Entry in combo box
                MessageBox.Show("Notification deleted.");
            } 
            else
            {
                // do nothing
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void changeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailChangeForm frm = new EmailChangeForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserSettingsForm frm = new UserSettingsForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //
        // GETTERS AND SETTERS 
        public void setUserName(string userN)
        {
            this.userName = userN;
        }

        public void setUserEmail(MailAddress userE)
        {
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
        //
        //
    }
}
