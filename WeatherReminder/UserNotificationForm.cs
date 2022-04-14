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
