namespace WeatherNode
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.BaseFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEmailTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.changeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WeatherFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.WeatherBox = new System.Windows.Forms.Panel();
            this.weatherPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HumidityTxtBox = new System.Windows.Forms.RichTextBox();
            this.ForecastTxtBox = new System.Windows.Forms.RichTextBox();
            this.WindChillTxtBox = new System.Windows.Forms.RichTextBox();
            this.TemperatureTxtBox = new System.Windows.Forms.RichTextBox();
            this.WindChillLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddLocationButton = new System.Windows.Forms.Button();
            this.NotificationFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NotificationGroupBox = new System.Windows.Forms.GroupBox();
            this.NotificationComboBox = new System.Windows.Forms.ComboBox();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.NotificationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteNotificationButton = new System.Windows.Forms.Button();
            this.AddNotificationButton = new System.Windows.Forms.Button();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.BaseFormSplitLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BaseFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.WeatherFlowLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.WeatherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.NotificationFlowLayout.SuspendLayout();
            this.NotificationGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BaseFormSplitLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseFormMenuStrip
            // 
            this.BaseFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.BaseFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.BaseFormMenuStrip.Name = "BaseFormMenuStrip";
            this.BaseFormMenuStrip.Size = new System.Drawing.Size(397, 24);
            this.BaseFormMenuStrip.TabIndex = 0;
            this.BaseFormMenuStrip.Text = "menuStrip1";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEmailTextBox,
            this.changeEmailToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // toolStripEmailTextBox
            // 
            this.toolStripEmailTextBox.AutoSize = false;
            this.toolStripEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripEmailTextBox.Name = "toolStripEmailTextBox";
            this.toolStripEmailTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripEmailTextBox.ReadOnly = true;
            this.toolStripEmailTextBox.Size = new System.Drawing.Size(275, 23);
            // 
            // changeEmailToolStripMenuItem
            // 
            this.changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            this.changeEmailToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.changeEmailToolStripMenuItem.Text = "Change Email";
            this.changeEmailToolStripMenuItem.Click += new System.EventHandler(this.changeEmailToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 38);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.WeatherFlowLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NotificationFlowLayout);
            this.splitContainer1.Size = new System.Drawing.Size(359, 548);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 1;
            // 
            // WeatherFlowLayout
            // 
            this.WeatherFlowLayout.Controls.Add(this.flowLayoutPanel1);
            this.WeatherFlowLayout.Controls.Add(this.panel3);
            this.WeatherFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.WeatherFlowLayout.Name = "WeatherFlowLayout";
            this.WeatherFlowLayout.Size = new System.Drawing.Size(357, 246);
            this.WeatherFlowLayout.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.WeatherBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(354, 193);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // WeatherBox
            // 
            this.WeatherBox.Controls.Add(this.weatherPictureBox);
            this.WeatherBox.Controls.Add(this.label2);
            this.WeatherBox.Controls.Add(this.HumidityTxtBox);
            this.WeatherBox.Controls.Add(this.ForecastTxtBox);
            this.WeatherBox.Controls.Add(this.WindChillTxtBox);
            this.WeatherBox.Controls.Add(this.TemperatureTxtBox);
            this.WeatherBox.Controls.Add(this.WindChillLabel);
            this.WeatherBox.Controls.Add(this.HumidityLabel);
            this.WeatherBox.Controls.Add(this.TemperatureLabel);
            this.WeatherBox.Controls.Add(this.LocationLabel);
            this.WeatherBox.Location = new System.Drawing.Point(3, 3);
            this.WeatherBox.Name = "WeatherBox";
            this.WeatherBox.Size = new System.Drawing.Size(269, 188);
            this.WeatherBox.TabIndex = 1;
            // 
            // weatherPictureBox
            // 
            this.weatherPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.weatherPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.weatherPictureBox.InitialImage = null;
            this.weatherPictureBox.Location = new System.Drawing.Point(9, 4);
            this.weatherPictureBox.Name = "weatherPictureBox";
            this.weatherPictureBox.Size = new System.Drawing.Size(70, 48);
            this.weatherPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weatherPictureBox.TabIndex = 9;
            this.weatherPictureBox.TabStop = false;
            this.weatherPictureBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Forecast:";
            // 
            // HumidityTxtBox
            // 
            this.HumidityTxtBox.Location = new System.Drawing.Point(86, 145);
            this.HumidityTxtBox.Name = "HumidityTxtBox";
            this.HumidityTxtBox.ReadOnly = true;
            this.HumidityTxtBox.Size = new System.Drawing.Size(136, 25);
            this.HumidityTxtBox.TabIndex = 5;
            this.HumidityTxtBox.Text = "";
            // 
            // ForecastTxtBox
            // 
            this.ForecastTxtBox.Location = new System.Drawing.Point(85, 83);
            this.ForecastTxtBox.Name = "ForecastTxtBox";
            this.ForecastTxtBox.ReadOnly = true;
            this.ForecastTxtBox.Size = new System.Drawing.Size(136, 25);
            this.ForecastTxtBox.TabIndex = 7;
            this.ForecastTxtBox.Text = "";
            // 
            // WindChillTxtBox
            // 
            this.WindChillTxtBox.Location = new System.Drawing.Point(86, 114);
            this.WindChillTxtBox.Name = "WindChillTxtBox";
            this.WindChillTxtBox.ReadOnly = true;
            this.WindChillTxtBox.Size = new System.Drawing.Size(136, 25);
            this.WindChillTxtBox.TabIndex = 6;
            this.WindChillTxtBox.Text = "";
            // 
            // TemperatureTxtBox
            // 
            this.TemperatureTxtBox.Location = new System.Drawing.Point(85, 52);
            this.TemperatureTxtBox.Name = "TemperatureTxtBox";
            this.TemperatureTxtBox.ReadOnly = true;
            this.TemperatureTxtBox.Size = new System.Drawing.Size(136, 25);
            this.TemperatureTxtBox.TabIndex = 4;
            this.TemperatureTxtBox.Text = "";
            // 
            // WindChillLabel
            // 
            this.WindChillLabel.AutoSize = true;
            this.WindChillLabel.Location = new System.Drawing.Point(17, 117);
            this.WindChillLabel.Name = "WindChillLabel";
            this.WindChillLabel.Size = new System.Drawing.Size(64, 13);
            this.WindChillLabel.TabIndex = 3;
            this.WindChillLabel.Text = "Wind Chill:";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(24, 148);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(56, 13);
            this.HumidityLabel.TabIndex = 2;
            this.HumidityLabel.Text = "Humidity:";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(6, 55);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(74, 13);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Temperature:";
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.Location = new System.Drawing.Point(82, 19);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(92, 20);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "PlaceHolder";
            this.LocationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AddLocationButton);
            this.panel3.Location = new System.Drawing.Point(3, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(353, 31);
            this.panel3.TabIndex = 2;
            // 
            // AddLocationButton
            // 
            this.AddLocationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocationButton.Location = new System.Drawing.Point(234, 5);
            this.AddLocationButton.Name = "AddLocationButton";
            this.AddLocationButton.Size = new System.Drawing.Size(104, 23);
            this.AddLocationButton.TabIndex = 0;
            this.AddLocationButton.Text = "NEW LOCATION";
            this.AddLocationButton.UseVisualStyleBackColor = true;
            this.AddLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // NotificationFlowLayout
            // 
            this.NotificationFlowLayout.Controls.Add(this.NotificationGroupBox);
            this.NotificationFlowLayout.Controls.Add(this.NotificationInfoGroupBox);
            this.NotificationFlowLayout.Controls.Add(this.panel1);
            this.NotificationFlowLayout.Location = new System.Drawing.Point(0, -1);
            this.NotificationFlowLayout.Name = "NotificationFlowLayout";
            this.NotificationFlowLayout.Size = new System.Drawing.Size(357, 309);
            this.NotificationFlowLayout.TabIndex = 0;
            // 
            // NotificationGroupBox
            // 
            this.NotificationGroupBox.Controls.Add(this.NotificationComboBox);
            this.NotificationGroupBox.Controls.Add(this.NotificationLabel);
            this.NotificationGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.NotificationGroupBox.Name = "NotificationGroupBox";
            this.NotificationGroupBox.Size = new System.Drawing.Size(354, 55);
            this.NotificationGroupBox.TabIndex = 2;
            this.NotificationGroupBox.TabStop = false;
            this.NotificationGroupBox.Text = "Notifications";
            // 
            // NotificationComboBox
            // 
            this.NotificationComboBox.FormattingEnabled = true;
            this.NotificationComboBox.Location = new System.Drawing.Point(122, 17);
            this.NotificationComboBox.Name = "NotificationComboBox";
            this.NotificationComboBox.Size = new System.Drawing.Size(216, 23);
            this.NotificationComboBox.TabIndex = 1;
            // 
            // NotificationLabel
            // 
            this.NotificationLabel.AutoSize = true;
            this.NotificationLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationLabel.Location = new System.Drawing.Point(6, 20);
            this.NotificationLabel.Name = "NotificationLabel";
            this.NotificationLabel.Size = new System.Drawing.Size(110, 15);
            this.NotificationLabel.TabIndex = 0;
            this.NotificationLabel.Text = "User Notifications : ";
            // 
            // NotificationInfoGroupBox
            // 
            this.NotificationInfoGroupBox.Location = new System.Drawing.Point(3, 64);
            this.NotificationInfoGroupBox.Name = "NotificationInfoGroupBox";
            this.NotificationInfoGroupBox.Size = new System.Drawing.Size(354, 202);
            this.NotificationInfoGroupBox.TabIndex = 3;
            this.NotificationInfoGroupBox.TabStop = false;
            this.NotificationInfoGroupBox.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteNotificationButton);
            this.panel1.Controls.Add(this.AddNotificationButton);
            this.panel1.Location = new System.Drawing.Point(3, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 30);
            this.panel1.TabIndex = 4;
            // 
            // DeleteNotificationButton
            // 
            this.DeleteNotificationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNotificationButton.Location = new System.Drawing.Point(182, 3);
            this.DeleteNotificationButton.Name = "DeleteNotificationButton";
            this.DeleteNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNotificationButton.TabIndex = 1;
            this.DeleteNotificationButton.Text = "DELETE";
            this.DeleteNotificationButton.UseVisualStyleBackColor = true;
            this.DeleteNotificationButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddNotificationButton
            // 
            this.AddNotificationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNotificationButton.Location = new System.Drawing.Point(263, 3);
            this.AddNotificationButton.Name = "AddNotificationButton";
            this.AddNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.AddNotificationButton.TabIndex = 0;
            this.AddNotificationButton.Text = "ADD";
            this.AddNotificationButton.UseVisualStyleBackColor = true;
            this.AddNotificationButton.Click += new System.EventHandler(this.AddNotificationButton_Click);
            // 
            // WelcomeUserLabel
            // 
            this.WelcomeUserLabel.AutoSize = true;
            this.WelcomeUserLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeUserLabel.Location = new System.Drawing.Point(3, 0);
            this.WelcomeUserLabel.Name = "WelcomeUserLabel";
            this.WelcomeUserLabel.Size = new System.Drawing.Size(85, 20);
            this.WelcomeUserLabel.TabIndex = 0;
            this.WelcomeUserLabel.Text = "Hello, User";
            // 
            // BaseFormSplitLayout
            // 
            this.BaseFormSplitLayout.ColumnCount = 1;
            this.BaseFormSplitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseFormSplitLayout.Controls.Add(this.WelcomeUserLabel, 0, 0);
            this.BaseFormSplitLayout.Controls.Add(this.splitContainer1, 0, 1);
            this.BaseFormSplitLayout.Location = new System.Drawing.Point(19, 28);
            this.BaseFormSplitLayout.Name = "BaseFormSplitLayout";
            this.BaseFormSplitLayout.RowCount = 2;
            this.BaseFormSplitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.956113F));
            this.BaseFormSplitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.04388F));
            this.BaseFormSplitLayout.Size = new System.Drawing.Size(365, 589);
            this.BaseFormSplitLayout.TabIndex = 2;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 625);
            this.Controls.Add(this.BaseFormSplitLayout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaseFormMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BaseFormMenuStrip;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Node";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_Closing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.BaseFormMenuStrip.ResumeLayout(false);
            this.BaseFormMenuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.WeatherFlowLayout.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.WeatherBox.ResumeLayout(false);
            this.WeatherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.NotificationFlowLayout.ResumeLayout(false);
            this.NotificationGroupBox.ResumeLayout(false);
            this.NotificationGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.BaseFormSplitLayout.ResumeLayout(false);
            this.BaseFormSplitLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripTextBox toolStripEmailTextBox;
        private System.Windows.Forms.ToolStripMenuItem changeEmailToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel WeatherFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel WeatherBox;
        private System.Windows.Forms.RichTextBox WindChillTxtBox;
        private System.Windows.Forms.RichTextBox HumidityTxtBox;
        private System.Windows.Forms.RichTextBox TemperatureTxtBox;
        private System.Windows.Forms.Label WindChillLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddLocationButton;
        private System.Windows.Forms.FlowLayoutPanel NotificationFlowLayout;
        private System.Windows.Forms.GroupBox NotificationGroupBox;
        private System.Windows.Forms.ComboBox NotificationComboBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.GroupBox NotificationInfoGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteNotificationButton;
        private System.Windows.Forms.Button AddNotificationButton;
        private System.Windows.Forms.Label WelcomeUserLabel;
        private System.Windows.Forms.TableLayoutPanel BaseFormSplitLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox ForecastTxtBox;
        private System.Windows.Forms.PictureBox weatherPictureBox;
    }
}