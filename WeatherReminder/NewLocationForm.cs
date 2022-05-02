/*
 * NewLocationForm.cs
 * Language: C#
 * User selects location and the file writes it out formatted
 * to the location.txt file
 * February 2022 - April 2022
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNode
{
    public partial class NewLocationForm : Form
    {
        private BaseForm form;
        public NewLocationForm(BaseForm frm)
        {
            InitializeComponent();
            form = frm;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            form.setEXITCODE(1); // form does not need to be refreshed
            this.Close();
        }

        private void AddLocationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // check if either city txt box or the state is empty / not selected
                if (String.IsNullOrEmpty(CityTxtBox.Text) || StateComboBox.SelectedItem == null)
                {
                    MessageBox.Show("CANNOT LEAVE OPTIONS EMPTY");
                }
                else
                {
                    string cityLine = CityTxtBox.Text.ToLower();
                    string stateLine = GetFormatedState(StateComboBox.SelectedItem.ToString()).ToLower();

                    string[] lines = {cityLine, stateLine};
                    // FORMATTING
                    //   CityName: san antonio
                    //      State: tx
                    File.WriteAllLines(@"..\..\..\PythonScripts\location.txt", lines); // write out location to location.txt
                    form.setEXITCODE(0); // form needs to be refreshed
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // converts state full name to abberivation
        private string GetFormatedState(string state) 
        {
            switch (state.ToUpper())
            {
                case "ALABAMA":
                    return "AL";

                case "ALASKA":
                    return "AK";

                case "ARIZONA":
                    return "AZ";

                case "ARKANSAS":
                    return "AR";

                case "CALIFORNIA":
                    return "CA";

                case "COLORADO":
                    return "CO";

                case "CONNECTICUT":
                    return "CT";

                case "DELAWARE":
                    return "DE";

                case "FLORIDA":
                    return "FL";

                case "GEORGIA":
                    return "GA";

                case "HAWAII":
                    return "HI";

                case "IDAHO":
                    return "ID";

                case "ILLINOIS":
                    return "IL";

                case "INDIANA":
                    return "IN";

                case "IOWA":
                    return "IA";

                case "KANSAS":
                    return "KS";

                case "KENTUCKY":
                    return "KY";

                case "LOUISIANA":
                    return "LA";

                case "MAINE":
                    return "ME";

                case "MARYLAND":
                    return "MD";

                case "MASSACHUSETTS":
                    return "MA";

                case "MICHIGAN":
                    return "MI";

                case "MINNESOTA":
                    return "MN";

                case "MISSISSIPPI":
                    return "MS";

                case "MISSOURI":
                    return "MO";

                case "MONTANA":
                    return "MT";

                case "NEBRASKA":
                    return "NE";

                case "NEVADA":
                    return "NV";

                case "NEW HAMPSHIRE":
                    return "NH";

                case "NEW JERSEY":
                    return "NJ";

                case "NEW MEXICO":
                    return "NM";

                case "NEW YORK":
                    return "NY";

                case "NORTH CAROLINA":
                    return "NC";

                case "NORTH DAKOTA":
                    return "ND";

                case "OHIO":
                    return "OH";

                case "OKLAHOMA":
                    return "OK";

                case "OREGON":
                    return "OR";

                case "PENNSYLVANIA":
                    return "PA";

                case "RHODE ISLAND":
                    return "RI";

                case "SOUTH CAROLINA":
                    return "SC";

                case "SOUTH DAKOTA":
                    return "SD";

                case "TENNESSEE":
                    return "TN";

                case "TEXAS":
                    return "TX";

                case "UTAH":
                    return "UT";

                case "VERMONT":
                    return "VT";

                case "VIRGINIA":
                    return "VA";

                case "WASHINGTON":
                    return "WA";

                case "WEST VIRGINIA":
                    return "WV";

                case "WISCONSIN":
                    return "WI";

                case "WYOMING":
                    return "WY";
            }
            throw new Exception("Not Available");
        }

    }
}
