namespace WeatherReminder
{
    partial class FirstTimeUserForm
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
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserEmailLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(12, 27);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(63, 13);
            this.UserNameLabel.TabIndex = 0;
            this.UserNameLabel.Text = "User Name:";
            // 
            // UserEmailLabel
            // 
            this.UserEmailLabel.AutoSize = true;
            this.UserEmailLabel.Location = new System.Drawing.Point(15, 64);
            this.UserEmailLabel.Name = "UserEmailLabel";
            this.UserEmailLabel.Size = new System.Drawing.Size(60, 13);
            this.UserEmailLabel.TabIndex = 1;
            this.UserEmailLabel.Text = "User Email:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(274, 97);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 2;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(355, 97);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 3;
            this.EnterBtn.Text = "ENTER";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(81, 24);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(349, 20);
            this.NameTxtBox.TabIndex = 4;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.NameTxtBox_TextChanged);
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(81, 61);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(349, 20);
            this.EmailTxtBox.TabIndex = 5;
            this.EmailTxtBox.TextChanged += new System.EventHandler(this.EmailTxtBox_TextChanged);
            // 
            // FirstTimeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 132);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.UserEmailLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Name = "FirstTimeUserForm";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserEmailLabel;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.TextBox NameTxtBox;
        private System.Windows.Forms.TextBox EmailTxtBox;
    }
}

