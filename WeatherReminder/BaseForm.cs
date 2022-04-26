/*
 * BaseForm.cs
 * Language: C# 
 * Base form for the WeatherNode application
 * Form contains main GUI that user interacts with
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
using System.Diagnostics;
using System.IO;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Net;

namespace WeatherNode
{
    public partial class BaseForm : Form
    {
        private string userName; // holds user's name
        [NonSerialized()]private string userPassword; // hold user password in memory ONLY
        private MailAddress userEmail; // holds user's email address
        public string smtpServer; // hold email server
        public int smtpPort; // hold email port
        public int smtpAuthentication; // 0 - SSL, 1 - TLS
        private Location location; // user's location
        private List<Notification> notificationList = new List<Notification>(); // user's notification
        private int EXITCODE = 0; // EXITCODE used to facilitate form flow
        private UserSaveStateHelper saveStateHelper = null;
        public int notificationListNumber = 0; // holds numbering for notification list, used for display purposes

        System.Timers.Timer myTimer = new System.Timers.Timer(4 * 60 * 60 *1000); // 4 hours in milliseconds

        public BaseForm()
        {
            InitializeComponent();
            myTimer.Elapsed += new System.Timers.ElapsedEventHandler(everyFourHour);
            myTimer.Start();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            //first time check
            if (File.Exists(@"..\..\..\WeatherReminder\saveState.xml"))
            {
                saveStateHelper = new UserSaveStateHelper();
                saveStateHelper.readUserState(@"..\..\..\WeatherReminder\saveState.xml");
                //load vars from save
                userName = saveStateHelper.currentSaveState.UserName;
                userEmail = saveStateHelper.deserializedEmail;
                smtpServer = saveStateHelper.currentSaveState.SmtpServer;
                smtpPort = saveStateHelper.currentSaveState.SmtpPort;
                smtpAuthentication = saveStateHelper.currentSaveState.SmtpAuthentication;
                // restoring the state of the notification list requires the use of the addNotification Fxn 
                foreach(Notification notification in saveStateHelper.deserializedNotifications)
                {
                    AddUserNotification(notification);
                }
                WelcomeUserLabel.Text = "Welcome, " + userName;
                toolStripEmailTextBox.Text = userEmail.ToString();
                WeatherBox.Enabled = false;
                LocationLabel.Visible = false;
                EmailPasswordForm pfrm = new EmailPasswordForm(this);
                pfrm.ShowDialog();
            }
            else
            {//end first time check
                FirstTimeUserForm frm = new FirstTimeUserForm(this);
                frm.TopMost = true;
                frm.ShowDialog();
                WelcomeUserLabel.Text = "Welcome, " + userName;
                toolStripEmailTextBox.Text = userEmail.ToString();
                WeatherBox.Enabled = false;
                LocationLabel.Visible = false;
                EmailPasswordForm pfrm = new EmailPasswordForm(this);
                pfrm.ShowDialog();
            }
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
                rainCheck.Checked = false;
                windCheck.Checked = false;
                fogCheck.Checked  = false;
                hotNumeric.Value = 0;
                coldNumeric.Value = 0;

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
            SetEmailPort();
            EmailPasswordForm pfrm = new EmailPasswordForm(this);
            pfrm.ShowDialog();
            toolStripEmailTextBox.Text = userEmail.ToString();
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
                NotificationCheck();
            }
        }

        // clean up after the application closes
        private void BaseForm_Closing(object sender, FormClosingEventArgs e)
        {
            saveStateHelper = new UserSaveStateHelper(this);
            saveStateHelper.writeUserState(@"..\..\..\WeatherReminder\saveState.xml");
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
                "rain and snow", "mist", "lightning observed","thunder storms", "light rain"};
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
                case "light rain":
                case "chance of rain":
                case "chance of showers":
                case "rain/snow showers":
                case "rain and snow":
                case "mist":
                    image = new Bitmap(@"..\..\..\Icons\showers.bmp");
                    break;
                case "chance of t-storm":
                case "lightning observed":
                case "thunder storms":
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

        public string getLocationName()
        {
            return location.GetLocation();
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
            int i = NotificationComboBox.SelectedIndex;
            rainCheck.Checked = notificationList[i].getNotificationOptions()[0];
            windCheck.Checked = notificationList[i].getNotificationOptions()[1];
            fogCheck.Checked = notificationList[i].getNotificationOptions()[2];
            hotNumeric.Value = notificationList[i].getNotificationHeat();
            coldNumeric.Value = notificationList[i].getNotificationCold();
            NotificationCheck();
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
            NotificationCheck();
        }

        private void sendTrayIcon(object sender, EventArgs e) // send to tray
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                trayNotifyIcon.Visible = true;
            }
        }

        private void trayNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e) // restore from tray
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            trayNotifyIcon.Visible = false;
        }

        private void SetEmailPort() // selects email port according to server
        {
            switch(smtpServer)
            {
                case "smtp.gmail.com":
                    smtpPort = 587;
                    smtpAuthentication = 0;
                    break;
                case "smtp-mail.outlook.com":
                    smtpPort = 587;
                    smtpAuthentication = 1;
                    break;
                case "smtp.office365.com":
                    smtpPort = 587;
                    smtpAuthentication = 1;
                    break;
                case "smtp.mail.yahoo.com":
                    smtpPort = 465;
                    smtpAuthentication = 0;
                    break;
                case "smtp.aol.com":
                    smtpPort = 587;
                    smtpAuthentication = 1;
                    break;
            }
        }

        public void SendEmail() // generates email and sends
        {
            var fromAddress = new MailAddress(userEmail.ToString(), "WeatherNode");
            var toAddress = new MailAddress(userEmail.ToString(), userName);
            string fromPassword = userPassword;
            string subject = "Weather Forecast Notification";
            string body = GenerateMessage();

            var smtp = new SmtpClient
            {
                Host = smtpServer,
                Port = smtpPort,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress,toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public string GenerateMessage() // generates body of email
        {
            string msg;
            msg = $"Hello {userName}! The current weather for {location.GetLocation()} is:\n" +
                $"    {location.GetWeather()}\n" +
                $"    {location.GetTemp()}\n" +
                $"    {location.GetWindChill()}\n" +
                $"    {location.GetHumidity()}\n\n" +
                $"The forecasted weather for later is: {ForecastTxtBox.Text}\n\n";
            switch(ForecastTxtBox.Text.ToLower())
            {
                case "chance of rain":
                case "light rain":
                case "chance of showers":
                case "rain/snow showers":
                case "rain and snow":
                case "mist":
                case "chance of t-storm":
                case "lightning observed":
                case "thunder storms":
                    msg = msg + "Make sure to bring an umbrella so you dont get wet!";
                    break;
                default:
                    // do nothing
                    break;
            }
            return msg;
        }

        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Notification was sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void everyFourHour(object src, EventArgs e) // every four hours send email
        {
            RunPythonScript();
            string[] lines = System.IO.File.ReadAllLines(@"..\..\..\PythonScripts\htmlparse.txt"); // read the file

            // Add index checking for 3 digit temps
            location = new Location(lines[0].Substring(12), lines[1].Substring(10), lines[2].Substring(5, lines[2].Length - 7) + "°F",
                lines[3].Substring(9), lines[8].Substring(11, lines[8].Length - 13) + "°F", ExtractForecast(lines[11]), lines[10].Substring(4));

            ReadList();
            ChangeWeatherImage();
            weatherPictureBox.Visible = true;
            WeatherBox.Enabled = true;
            LocationLabel.Visible = true;
            NotificationCheck();
            SetEmailPort();
            SendEmail();
            MessageBox.Show("Email sent.");
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            SetEmailPort();
            SendEmail();
            MessageBox.Show("Email sent.");
        }

        // check notification flags against weather
        private void NotificationCheck()
        {
            for (int i = 0; i < notificationList.Count; i++)
            {
                if ((notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "chance of rain") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "chance of showers") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "rain/snow showers") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "rain and snow") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "mist") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "chance of t-storm") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "lightning observed") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "thunder storms") ||
                    (notificationList[i].getNotificationOptions()[0] == true && ForecastTxtBox.Text.ToLower() == "light rain") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "chance of rain") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "chance of showers") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "rain/snow showers") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "rain and snow") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "mist") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "chance of t-storm") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "lightning observed") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "thunder storms") ||
                    (notificationList[i].getNotificationOptions()[0] == true && location.GetWeather().ToLower() == "light rain"))
                {
                    SetEmailPort();
                    SendEmail();
                }
                if ((notificationList[i].getNotificationOptions()[1] == true && ForecastTxtBox.Text.ToLower() == "windy") ||
                    (notificationList[i].getNotificationOptions()[1] == true && ForecastTxtBox.Text.ToLower() == "blowing widespread dust") ||
                    (notificationList[i].getNotificationOptions()[1] == true && location.GetWeather().ToLower() == "windy") ||
                    (notificationList[i].getNotificationOptions()[1] == true && location.GetWeather().ToLower() == "blowing widespread dust")) {
                    SetEmailPort();
                    SendEmail();
                }
                if ((notificationList[i].getNotificationOptions()[2] == true && ForecastTxtBox.Text.ToLower() == "fog") ||
                    (notificationList[i].getNotificationOptions()[2] == true && ForecastTxtBox.Text.ToLower() == "patchy fog") ||
                    (notificationList[i].getNotificationOptions()[2] == true && ForecastTxtBox.Text.ToLower() == "hazy") ||
                    (notificationList[i].getNotificationOptions()[2] == true && location.GetWeather().ToLower() == "fog") ||
                    (notificationList[i].getNotificationOptions()[2] == true && location.GetWeather().ToLower() == "patchy fog") ||
                    (notificationList[i].getNotificationOptions()[2] == true && location.GetWeather().ToLower() == "hazy"))
                {
                    SetEmailPort();
                    SendEmail();
                }

                if (Int32.Parse(location.GetTemp().Substring(0,2)) <= notificationList[i].getNotificationCold() || 
                    Int32.Parse(location.GetTemp().Substring(0,2)) >= notificationList[i].getNotificationHeat())
                {
                    SetEmailPort();
                    SendEmail();
                }
            }
            
        }
    }
}
