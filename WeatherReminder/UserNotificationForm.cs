/*
 * UserNotificationForm.cs
 * Language: C#
 * Allows user to add new notification
 * Janurary 2022 - April 2022
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

namespace WeatherNode
{
    public partial class UserNotificationsForm : Form
    {
        private BaseForm form;
        public UserNotificationsForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            /*
            * ARRAY SPACE      NOTIFICATION
            *           0      RAIN
            *           1      WIND
            *           2      FOG
            *           3      HUMIDITY
            */
            bool[] notificationOptions =
                {rainCheck.Checked, windCheck.Checked, fogCheck.Checked, humidityCheck.Checked};
            int hot = Convert.ToInt32(Math.Round(hotNumeric.Value, 0));
            int cold = Convert.ToInt32(Math.Round(coldNumeric.Value, 0));

            Notification newNotification = new Notification(form.notificationListNumber,hot,cold,notificationOptions);
            form.AddUserNotification(newNotification);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
