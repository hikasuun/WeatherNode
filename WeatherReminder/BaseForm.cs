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
using System.IO;

namespace WeatherNode
{
    public partial class BaseForm : Form
    {
        private string userName; // holds user's name
        private MailAddress userEmail; // holds user's email address
        private List<Location> locations = new List<Location>(); // vector list holding user's locations

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
            toolStripEmailTextBox.Text = userEmail.ToString();
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
                Console.WriteLine(ex.Message);
            }
        }


        private void ReadVector()
        {
            LocationLabel.Text = locations[0].GetLocation();
            TemperatureTxtBox.Text = locations[0].GetTemp();
            HumidityTxtBox.Text = locations[0].GetHumidity();
            WindChillTxtBox.Text = locations[0].GetWindChill();
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

        private void changeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailChangeForm frm = new EmailChangeForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            toolStripEmailTextBox.Text = userEmail.ToString();
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

        // testing purposes: add location button should have pop up with location fields and add new box to app.
        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            NewLocationForm frm = new NewLocationForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            RunPythonScript();
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\PythonScripts\htmlparse.txt"); // read the file

            // Add index checking for 3 digit temps
            locations.Add(new Location(lines[0].Substring(12), lines[2].Substring(5, lines[2].Length - 7) + "°F",
                lines[3].Substring(9), lines[8].Substring(11, lines[8].Length - 13) + "°F", lines[10].Substring(4)));
            ReadVector();
        }
    }
}
