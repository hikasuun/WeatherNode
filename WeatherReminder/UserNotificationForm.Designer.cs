namespace WeatherNode
{
    partial class UserNotificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNotificationsForm));
            this.coldNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hotNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.rainCheck = new System.Windows.Forms.CheckBox();
            this.windCheck = new System.Windows.Forms.CheckBox();
            this.humidityCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.fogCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.coldNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // coldNumeric
            // 
            this.coldNumeric.BackColor = System.Drawing.Color.DodgerBlue;
            this.coldNumeric.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldNumeric.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.coldNumeric.Location = new System.Drawing.Point(333, 73);
            this.coldNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.coldNumeric.Name = "coldNumeric";
            this.coldNumeric.Size = new System.Drawing.Size(80, 22);
            this.coldNumeric.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "COLD NOTIFCATION:";
            // 
            // hotNumeric
            // 
            this.hotNumeric.BackColor = System.Drawing.Color.Red;
            this.hotNumeric.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hotNumeric.Location = new System.Drawing.Point(333, 40);
            this.hotNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.hotNumeric.Name = "hotNumeric";
            this.hotNumeric.Size = new System.Drawing.Size(80, 22);
            this.hotNumeric.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "HEAT NOTIFICATION:";
            // 
            // rainCheck
            // 
            this.rainCheck.AutoSize = true;
            this.rainCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rainCheck.Location = new System.Drawing.Point(21, 41);
            this.rainCheck.Name = "rainCheck";
            this.rainCheck.Size = new System.Drawing.Size(88, 17);
            this.rainCheck.TabIndex = 23;
            this.rainCheck.Text = "Rain / Snow";
            this.rainCheck.UseVisualStyleBackColor = true;
            // 
            // windCheck
            // 
            this.windCheck.AutoSize = true;
            this.windCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windCheck.Location = new System.Drawing.Point(21, 64);
            this.windCheck.Name = "windCheck";
            this.windCheck.Size = new System.Drawing.Size(54, 17);
            this.windCheck.TabIndex = 18;
            this.windCheck.Text = "Wind";
            this.windCheck.UseVisualStyleBackColor = true;
            // 
            // humidityCheck
            // 
            this.humidityCheck.AutoSize = true;
            this.humidityCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityCheck.Location = new System.Drawing.Point(21, 110);
            this.humidityCheck.Name = "humidityCheck";
            this.humidityCheck.Size = new System.Drawing.Size(72, 17);
            this.humidityCheck.TabIndex = 17;
            this.humidityCheck.Text = "Humidity";
            this.humidityCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "URGENT NOTIFICATIONS:";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(299, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 38);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(169, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(114, 38);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // fogCheck
            // 
            this.fogCheck.AutoSize = true;
            this.fogCheck.Location = new System.Drawing.Point(21, 87);
            this.fogCheck.Name = "fogCheck";
            this.fogCheck.Size = new System.Drawing.Size(46, 17);
            this.fogCheck.TabIndex = 28;
            this.fogCheck.Text = "Fog";
            this.fogCheck.UseVisualStyleBackColor = true;
            // 
            // UserNotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 190);
            this.ControlBox = false;
            this.Controls.Add(this.fogCheck);
            this.Controls.Add(this.coldNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rainCheck);
            this.Controls.Add(this.windCheck);
            this.Controls.Add(this.humidityCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserNotificationsForm";
            this.Text = "New Notification";
            this.Load += new System.EventHandler(this.UserSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coldNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown coldNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hotNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rainCheck;
        private System.Windows.Forms.CheckBox windCheck;
        private System.Windows.Forms.CheckBox humidityCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.CheckBox fogCheck;
    }
}