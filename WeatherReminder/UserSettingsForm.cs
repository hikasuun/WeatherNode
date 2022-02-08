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
    public partial class UserSettingsForm : Form
    {
        private BaseForm form;
        public UserSettingsForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void UserSettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
