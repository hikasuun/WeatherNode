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
using System.Globalization;
using System.Runtime.Serialization.Formatters.Soap;

namespace WeatherNode
{
    public partial class BaseForm : Form
    {
        private string userName; // holds user's name
        [NonSerialized()]private string userPassword; // hold user password in memory ONLY
        private MailAddress userEmail; // holds user's email address
        public string smtpServer; // hold email server
        public string smtpPort; // hold email port
        public int smtpAuthentication; // 0 - SSL, 1 - TLS
        private Location location; // user's location
        private List<Notification> notificationList = new List<Notification>(); // user's notification
        private int EXITCODE = 0; // EXITCODE used to facilitate form flow
        public int notificationListNumber = 0; // holds numbering for notification list, used for display purposes


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
            WeatherBox.Enabled = false;
            LocationLabel.Visible = false;
        }

        // deploys the webscrapping routine
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

        // populates text boxes with location info
        private void ReadList()
        {
            LocationLabel.Text = location.GetLocation();
            TemperatureTxtBox.Text = location.GetTemp();
            HumidityTxtBox.Text = location.GetHumidity();
            WindChillTxtBox.Text = location.GetWindChill();
            ForecastTxtBox.Text = location.GetForecast();
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
                DeleteUserNotification(NotificationComboBox.SelectedIndex);
                MessageBox.Show("Notification deleted.");
            }
            else
            {
                // do nothing
            }
        }

        // changes user's email
        private void changeEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailChangeForm frm = new EmailChangeForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            toolStripEmailTextBox.Text = userEmail.ToString();
            SetEmailPort();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // changes location
        private void AddLocationButton_Click(object sender, EventArgs e)
        {
            // window to cahnge to new location
            NewLocationForm frm = new NewLocationForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            if (EXITCODE == 0) // if Change Loc. btn pressed, change location
            {
                // window to indicate to user that program is loading location info
                LoadingForm loadfrm = new LoadingForm(this);
                loadfrm.StartPosition = FormStartPosition.CenterParent;
                loadfrm.TopMost = true;
                loadfrm.Show(this);
                RunPythonScript();
                loadfrm.Close(); // once finished, loading window closes

                string[] lines = System.IO.File.ReadAllLines(@"..\..\..\PythonScripts\htmlparse.txt"); // read the file

                // Add index checking for 3 digit temps
                location = new Location(lines[0].Substring(12), lines[1].Substring(10), lines[2].Substring(5, lines[2].Length - 7) + "°F",
                    lines[3].Substring(9), lines[8].Substring(11, lines[8].Length - 13) + "°F", ExtractForecast(lines[11]), lines[10].Substring(4));

                ReadList();
                ChangeWeatherImage();
                weatherPictureBox.Visible = true;
                WeatherBox.Enabled = true;
                LocationLabel.Visible = true;
            }
        }

        // clean up after the application closes
        private void BaseForm_Closing(object sender, FormClosingEventArgs e)
        {
            UserSaveStateHelper currentSaveState = new UserSaveStateHelper(this);
            currentSaveState.writeUserState("saveState.xml");

            if (File.Exists(@"..\..\..\PythonScripts\htmlparse.txt"))
            {
                File.Delete(@"..\..\..\PythonScripts\htmlparse.txt");
            }
            if (File.Exists(@"..\..\..\PythonScripts\location.txt"))
            {
                File.Delete(@"..\..\..\PythonScripts\location.txt");
            }
        }

        // extracts location's weather forecast from the final line in htmlparse.txt
        private string ExtractForecast(string str)
        {
            // list of different forecasts that FreeWeather.com has
            // may need to add more weather forecasts as need arises
            string[] forecastList =
                { "sunny", "mostly sunny", "partly sunny","clear", "partly clear", "mostly clear", "clearing",
                "partly cloudy", "mostly cloudy", "chance of rain", "chance of showers", "chance of t-storm",
                "rain/snow showers",  "fog", "patchy fog","windy", "overcast", "hazy", "blowing widespread dust",
                "rain and snow", "mist", "lightning observed"};
            for (int i = 0; i < forecastList.Length; i++)
            {
                if (str.ToLower().Contains(forecastList[i]))
                {
                    return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(forecastList[i]);
                }
            }
            return "ERROR";
        }

        // Changes the picture next to location to reflect current weather
        private void ChangeWeatherImage()
        {
            Bitmap image = null;
            // check if PictureBox is populated, needs to be cleared before new image is loaded
            if (weatherPictureBox.Image != null)
            {
                weatherPictureBox.Image.Dispose();
            }

            // select image depending on weather
            switch (location.GetWeather().ToLower())
            {
                case "sunny":
                case "clear":
                    image = new Bitmap(@"..\..\..\Icons\sunny.bmp");
                    break;
                case "mostly sunny":
                case "partly sunny":
                case "partly clear":
                case "mostly clear":
                case "clearing":
                    image = new Bitmap(@"..\..\..\Icons\day-cloudy.bmp");
                    break;
                case "partly cloudy":
                case "mostly cloudy":
                case "overcast":
                    image = new Bitmap(@"..\..\..\Icons\cloudy.bmp");
                    break;
                case "chance of rain":
                case "change of showers":
                case "rain/snow showers":
                case "rain and snow":
                case "mist":
                    image = new Bitmap(@"..\..\..\Icons\showers.bmp");
                    break;
                case "chance of t-storm":
                case "lightning observed":
                    image = new Bitmap(@"..\..\..\Icons\storm-showers.bmp");
                    break;
                case "fog":
                case "patchy fog":
                case "hazy":
                    image = new Bitmap(@"..\..\..\Icons\fog.bmp");
                    break;
                case "windy":
                case "blowing widespread dust":
                    image = new Bitmap(@"..\..\..\Icons\windy.bmp");
                    break;
                default:
                    weatherPictureBox = null;
                    break;
            }
            weatherPictureBox.Image = image; // display image
        }

        // UTILITY FUNCTIONS
        public void setUserName(string userN)
        {
            this.userName = userN;
        }
        public void setUserPassword(string userP)
        {
            this.userPassword = userP;
        }
        public void setUserEmail(MailAddress userE)
        {
            this.userEmail = userE;
        }
        public void setEXITCODE(int code)
        { 
            EXITCODE = code;
        }
        public string getUserName()
        {
            return this.userName;
        }
        public string getUserPassword()
        {
            return this.userPassword;
        }
        public MailAddress getUserEmail()
        {
            return this.userEmail;
        }

        public string[] getBasicLocationData()
        {
            String[] basicLocationData = new String[2] { location.GetLocation(), location.GetUrl() };
            return basicLocationData;
        }

        public List<Notification> getNotificationList()
        {
            return this.notificationList;
        }

        public int getEXITCODE() 
        { 
            return EXITCODE; 
        }

        private void AddNotificationButton_Click(object sender, EventArgs e)
        {
            UserNotificationsForm frm = new UserNotificationsForm(this);
            frm.TopMost = true;
            frm.ShowDialog();
            //NotificationLoading();
        }

        private void NotificationLoading()
        {
            // TODO: INDEX SELECTED NOTIFICATION
            int i = NotificationComboBox.SelectedIndex;
            rainCheck.Checked = notificationList[i].getNotificationOptions()[0];
            windCheck.Checked = notificationList[i].getNotificationOptions()[1];
            fogCheck.Checked = notificationList[i].getNotificationOptions()[2];
            humidityCheck.Checked = notificationList[i].getNotificationOptions()[3];
            hotNumeric.Value = notificationList[i].getNotificationHeat();
            coldNumeric.Value = notificationList[i].getNotificationCold();
            timePicker.Value = (notificationList[i].getNotificationDate().Date + notificationList[i].getNotificationDate().TimeOfDay);
        }
        public void AddUserNotification(Notification notif)
        {
            notificationList.Add(notif);
            NotificationComboBox.Items.Add("Notification " + notif.getNotificationID());
            notificationListNumber++;
        }
        public void DeleteUserNotification(int index)
        {
            notificationList.RemoveAt(index);
            NotificationComboBox.Items.RemoveAt(index);
        }

        private void NotificationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NotificationLoading();
        }

        private void sendTrayIcon(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayNotifyIcon.Visible = true;
            }
        }

        private void trayNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayNotifyIcon.Visible = false;
        }

        private void SetEmailPort()
        {
            switch(smtpServer)
            {
                case "smtp.gmail.com":
                    smtpPort = "465";
                    smtpAuthentication = 0;
                    break;
                case "smtp - mail.outlook.com":
                    smtpPort = "587";
                    smtpAuthentication = 1;
                    break;
                case "smtp.office365.com":
                    smtpPort = "587";
                    smtpAuthentication = 1;
                    break;
                case "smtp.mail.yahoo.com":
                    smtpPort = "465";
                    smtpAuthentication = 0;
                    break;
                case "smtp.aol.com":
                    smtpPort = "587";
                    smtpAuthentication = 1;
                    break;
            }
        }
    }
}
