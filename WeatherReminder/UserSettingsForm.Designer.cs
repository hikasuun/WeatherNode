namespace WeatherNode
{
    partial class UserSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettingsForm));
            this.coldNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.hotNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.stormCheck = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.hurricaneCheck = new System.Windows.Forms.CheckBox();
            this.tornadoCheck = new System.Windows.Forms.CheckBox();
            this.windCheck = new System.Windows.Forms.CheckBox();
            this.humidityCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coldNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // coldNumeric
            // 
            this.coldNumeric.BackColor = System.Drawing.Color.DodgerBlue;
            this.coldNumeric.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coldNumeric.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.coldNumeric.Location = new System.Drawing.Point(305, 188);
            this.coldNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.coldNumeric.Name = "coldNumeric";
            this.coldNumeric.Size = new System.Drawing.Size(120, 22);
            this.coldNumeric.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "NOTIFY ME IF IT IS GOING TO BE COLDER THAN:";
            // 
            // hotNumeric
            // 
            this.hotNumeric.BackColor = System.Drawing.Color.Red;
            this.hotNumeric.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hotNumeric.Location = new System.Drawing.Point(305, 110);
            this.hotNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.hotNumeric.Name = "hotNumeric";
            this.hotNumeric.Size = new System.Drawing.Size(120, 22);
            this.hotNumeric.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "NOTIFY ME IF IT IS GOING TO BE WARMER THAN:";
            // 
            // stormCheck
            // 
            this.stormCheck.AutoSize = true;
            this.stormCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stormCheck.Location = new System.Drawing.Point(56, 155);
            this.stormCheck.Name = "stormCheck";
            this.stormCheck.Size = new System.Drawing.Size(63, 17);
            this.stormCheck.TabIndex = 23;
            this.stormCheck.Text = "STORM";
            this.stormCheck.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(55, 277);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(77, 17);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.Text = "HUMIDITY";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(55, 243);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(74, 17);
            this.checkBox5.TabIndex = 21;
            this.checkBox5.Text = "TSUNAMI";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // hurricaneCheck
            // 
            this.hurricaneCheck.AutoSize = true;
            this.hurricaneCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hurricaneCheck.Location = new System.Drawing.Point(55, 212);
            this.hurricaneCheck.Name = "hurricaneCheck";
            this.hurricaneCheck.Size = new System.Drawing.Size(87, 17);
            this.hurricaneCheck.TabIndex = 20;
            this.hurricaneCheck.Text = "HURRICANE";
            this.hurricaneCheck.UseVisualStyleBackColor = true;
            // 
            // tornadoCheck
            // 
            this.tornadoCheck.AutoSize = true;
            this.tornadoCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tornadoCheck.Location = new System.Drawing.Point(55, 183);
            this.tornadoCheck.Name = "tornadoCheck";
            this.tornadoCheck.Size = new System.Drawing.Size(79, 17);
            this.tornadoCheck.TabIndex = 19;
            this.tornadoCheck.Text = "TORNADO";
            this.tornadoCheck.UseVisualStyleBackColor = true;
            // 
            // windCheck
            // 
            this.windCheck.AutoSize = true;
            this.windCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windCheck.Location = new System.Drawing.Point(56, 122);
            this.windCheck.Name = "windCheck";
            this.windCheck.Size = new System.Drawing.Size(86, 17);
            this.windCheck.TabIndex = 18;
            this.windCheck.Text = "HIGH WIND";
            this.windCheck.UseVisualStyleBackColor = true;
            // 
            // humidityCheck
            // 
            this.humidityCheck.AutoSize = true;
            this.humidityCheck.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityCheck.Location = new System.Drawing.Point(56, 93);
            this.humidityCheck.Name = "humidityCheck";
            this.humidityCheck.Size = new System.Drawing.Size(77, 17);
            this.humidityCheck.TabIndex = 17;
            this.humidityCheck.Text = "HUMIDITY";
            this.humidityCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "NOTIFICATION ALERT";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.Black;
            this.BackButton.Location = new System.Drawing.Point(410, 320);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(142, 38);
            this.BackButton.TabIndex = 15;
            this.BackButton.Text = "BACK";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(577, 320);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(142, 38);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 395);
            this.Controls.Add(this.coldNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hotNumeric);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stormCheck);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.hurricaneCheck);
            this.Controls.Add(this.tornadoCheck);
            this.Controls.Add(this.windCheck);
            this.Controls.Add(this.humidityCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettingsForm";
            this.Text = "Settings";
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
        private System.Windows.Forms.CheckBox stormCheck;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox hurricaneCheck;
        private System.Windows.Forms.CheckBox tornadoCheck;
        private System.Windows.Forms.CheckBox windCheck;
        private System.Windows.Forms.CheckBox humidityCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveButton;
    }
}