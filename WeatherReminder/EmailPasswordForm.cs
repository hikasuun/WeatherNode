/*
 * EmailPasswordForm.cs
 * Language : C#
 * Form for inputing user password / app password
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

namespace WeatherNode
{
    public partial class EmailPasswordForm : Form
    {
        private BaseForm form;
        public EmailPasswordForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void ClearBtn_Click(object sender, EventArgs e) // clear password txt field
        {
            passwordTxtBox.Text = "";
        }

        private void EnterBtn_Click(object sender, EventArgs e) // set password for session
        {
            form.setUserPassword(passwordTxtBox.Text);
            this.Close();
        }
    }
}
