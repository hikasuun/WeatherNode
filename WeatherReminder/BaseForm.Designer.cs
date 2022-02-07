namespace WeatherReminder
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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BaseFormSplitLayout = new System.Windows.Forms.TableLayoutPanel();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.WeatherFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NotificationFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.NotificationLabel = new System.Windows.Forms.Label();
            this.NotificationComboBox = new System.Windows.Forms.ComboBox();
            this.NotificationGroupBox = new System.Windows.Forms.GroupBox();
            this.NotificationInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNotificationButton = new System.Windows.Forms.Button();
            this.DeleteNotificationButton = new System.Windows.Forms.Button();
            this.EditNotificationButton = new System.Windows.Forms.Button();
            this.toolStripEmailTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.changeEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BaseFormMenuStrip.SuspendLayout();
            this.BaseFormSplitLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.NotificationFlowLayout.SuspendLayout();
            this.NotificationGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseFormMenuStrip
            // 
            this.BaseFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.BaseFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.BaseFormMenuStrip.Name = "BaseFormMenuStrip";
            this.BaseFormMenuStrip.Size = new System.Drawing.Size(565, 24);
            this.BaseFormMenuStrip.TabIndex = 0;
            this.BaseFormMenuStrip.Text = "menuStrip1";
            this.BaseFormMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BaseFormMenuStrip_ItemClicked);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEmailTextBox,
            this.changeEmailToolStripMenuItem});
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
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
            // BaseFormSplitLayout
            // 
            this.BaseFormSplitLayout.ColumnCount = 1;
            this.BaseFormSplitLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BaseFormSplitLayout.Controls.Add(this.WelcomeUserLabel, 0, 0);
            this.BaseFormSplitLayout.Controls.Add(this.splitContainer1, 0, 1);
            this.BaseFormSplitLayout.Location = new System.Drawing.Point(16, 28);
            this.BaseFormSplitLayout.Name = "BaseFormSplitLayout";
            this.BaseFormSplitLayout.RowCount = 2;
            this.BaseFormSplitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.956113F));
            this.BaseFormSplitLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.04388F));
            this.BaseFormSplitLayout.Size = new System.Drawing.Size(537, 487);
            this.BaseFormSplitLayout.TabIndex = 2;
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
            this.WelcomeUserLabel.Click += new System.EventHandler(this.WelcomeUserLabel_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 32);
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
            this.splitContainer1.Size = new System.Drawing.Size(531, 452);
            this.splitContainer1.SplitterDistance = 226;
            this.splitContainer1.TabIndex = 1;
            // 
            // WeatherFlowLayout
            // 
            this.WeatherFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.WeatherFlowLayout.Name = "WeatherFlowLayout";
            this.WeatherFlowLayout.Size = new System.Drawing.Size(531, 223);
            this.WeatherFlowLayout.TabIndex = 0;
            // 
            // NotificationFlowLayout
            // 
            this.NotificationFlowLayout.Controls.Add(this.NotificationGroupBox);
            this.NotificationFlowLayout.Controls.Add(this.NotificationInfoGroupBox);
            this.NotificationFlowLayout.Controls.Add(this.panel1);
            this.NotificationFlowLayout.Location = new System.Drawing.Point(0, -1);
            this.NotificationFlowLayout.Name = "NotificationFlowLayout";
            this.NotificationFlowLayout.Size = new System.Drawing.Size(531, 223);
            this.NotificationFlowLayout.TabIndex = 0;
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
            // NotificationComboBox
            // 
            this.NotificationComboBox.FormattingEnabled = true;
            this.NotificationComboBox.Location = new System.Drawing.Point(122, 17);
            this.NotificationComboBox.Name = "NotificationComboBox";
            this.NotificationComboBox.Size = new System.Drawing.Size(371, 23);
            this.NotificationComboBox.TabIndex = 1;
            // 
            // NotificationGroupBox
            // 
            this.NotificationGroupBox.Controls.Add(this.NotificationComboBox);
            this.NotificationGroupBox.Controls.Add(this.NotificationLabel);
            this.NotificationGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationGroupBox.Location = new System.Drawing.Point(3, 3);
            this.NotificationGroupBox.Name = "NotificationGroupBox";
            this.NotificationGroupBox.Size = new System.Drawing.Size(525, 50);
            this.NotificationGroupBox.TabIndex = 2;
            this.NotificationGroupBox.TabStop = false;
            this.NotificationGroupBox.Text = "Notifications";
            // 
            // NotificationInfoGroupBox
            // 
            this.NotificationInfoGroupBox.Location = new System.Drawing.Point(3, 59);
            this.NotificationInfoGroupBox.Name = "NotificationInfoGroupBox";
            this.NotificationInfoGroupBox.Size = new System.Drawing.Size(525, 124);
            this.NotificationInfoGroupBox.TabIndex = 3;
            this.NotificationInfoGroupBox.TabStop = false;
            this.NotificationInfoGroupBox.Text = "Information";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EditNotificationButton);
            this.panel1.Controls.Add(this.DeleteNotificationButton);
            this.panel1.Controls.Add(this.AddNotificationButton);
            this.panel1.Location = new System.Drawing.Point(3, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 31);
            this.panel1.TabIndex = 4;
            // 
            // AddNotificationButton
            // 
            this.AddNotificationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNotificationButton.Location = new System.Drawing.Point(447, 5);
            this.AddNotificationButton.Name = "AddNotificationButton";
            this.AddNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.AddNotificationButton.TabIndex = 0;
            this.AddNotificationButton.Text = "ADD";
            this.AddNotificationButton.UseVisualStyleBackColor = true;
            // 
            // DeleteNotificationButton
            // 
            this.DeleteNotificationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNotificationButton.Location = new System.Drawing.Point(9, 5);
            this.DeleteNotificationButton.Name = "DeleteNotificationButton";
            this.DeleteNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteNotificationButton.TabIndex = 1;
            this.DeleteNotificationButton.Text = "DELETE";
            this.DeleteNotificationButton.UseVisualStyleBackColor = true;
            this.DeleteNotificationButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditNotificationButton
            // 
            this.EditNotificationButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditNotificationButton.Location = new System.Drawing.Point(354, 5);
            this.EditNotificationButton.Name = "EditNotificationButton";
            this.EditNotificationButton.Size = new System.Drawing.Size(75, 23);
            this.EditNotificationButton.TabIndex = 2;
            this.EditNotificationButton.Text = "EDIT";
            this.EditNotificationButton.UseVisualStyleBackColor = true;
            // 
            // toolStripEmailTextBox
            // 
            this.toolStripEmailTextBox.AutoSize = false;
            this.toolStripEmailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripEmailTextBox.Name = "toolStripEmailTextBox";
            this.toolStripEmailTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripEmailTextBox.ReadOnly = true;
            this.toolStripEmailTextBox.Size = new System.Drawing.Size(275, 23);
            this.toolStripEmailTextBox.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // changeEmailToolStripMenuItem
            // 
            this.changeEmailToolStripMenuItem.Name = "changeEmailToolStripMenuItem";
            this.changeEmailToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.changeEmailToolStripMenuItem.Text = "Change Email";
            this.changeEmailToolStripMenuItem.Click += new System.EventHandler(this.changeEmailToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 527);
            this.Controls.Add(this.BaseFormSplitLayout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BaseFormMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.BaseFormMenuStrip;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Node";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.BaseFormMenuStrip.ResumeLayout(false);
            this.BaseFormMenuStrip.PerformLayout();
            this.BaseFormSplitLayout.ResumeLayout(false);
            this.BaseFormSplitLayout.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.NotificationFlowLayout.ResumeLayout(false);
            this.NotificationGroupBox.ResumeLayout(false);
            this.NotificationGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BaseFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel BaseFormSplitLayout;
        private System.Windows.Forms.Label WelcomeUserLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel WeatherFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel NotificationFlowLayout;
        private System.Windows.Forms.GroupBox NotificationGroupBox;
        private System.Windows.Forms.ComboBox NotificationComboBox;
        private System.Windows.Forms.Label NotificationLabel;
        private System.Windows.Forms.GroupBox NotificationInfoGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteNotificationButton;
        private System.Windows.Forms.Button AddNotificationButton;
        private System.Windows.Forms.Button EditNotificationButton;
        private System.Windows.Forms.ToolStripTextBox toolStripEmailTextBox;
        private System.Windows.Forms.ToolStripMenuItem changeEmailToolStripMenuItem;
    }
}