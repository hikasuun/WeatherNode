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
using System.Diagnostics;
using Microsoft.Scripting.Hosting;
using System.IO;

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

            // REMOVE THIS FOR A BUTTON, TESTING ONLY
            RunPythonScript();
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\PythonScripts\htmlparse.txt");
            // Add index checking for 3 digit temps
            Location location1 = new Location(lines[0].Substring(12), lines[2].Substring(5,lines[2].Length-7)+ "°F",
                                    lines[3].Substring(9), lines[8].Substring(11,lines[8].Length-13) + "°F", lines[10].Substring(4));
            LocationLabel.Text = location1.GetLocation();
            TemperatureTxtBox.Text = location1.GetTemp();
            HumidityTxtBox.Text = location1.GetHumidity();
            WindChillTxtBox.Text = location1.GetWindChill();
        }

        private void RunPythonScript()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            startInfo.WorkingDirectory = Path.GetDirectoryName(@"..\..\..\PythonScripts\WeatherScrapper.exe");
            startInfo.FileName = @"..\..\..\PythonScripts\WeatherScrapper.exe";
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            { 
            }
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

        private void AddNotificationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
