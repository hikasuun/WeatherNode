namespace WeatherNode
{
    partial class EmailChangeForm
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.EmailCancelButton = new System.Windows.Forms.Button();
            this.smtpCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionLabel.Location = new System.Drawing.Point(9, 19);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(158, 17);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Enter new email address :";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(173, 19);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(344, 22);
            this.EmailTxtBox.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(361, 85);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "ENTER";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // EmailCancelButton
            // 
            this.EmailCancelButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailCancelButton.Location = new System.Drawing.Point(442, 85);
            this.EmailCancelButton.Name = "EmailCancelButton";
            this.EmailCancelButton.Size = new System.Drawing.Size(75, 23);
            this.EmailCancelButton.TabIndex = 3;
            this.EmailCancelButton.Text = "CANCEL";
            this.EmailCancelButton.UseVisualStyleBackColor = true;
            this.EmailCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // smtpCombo
            // 
            this.smtpCombo.FormattingEnabled = true;
            this.smtpCombo.Items.AddRange(new object[] {
            "smtp.gmail.com",
            "smtp-mail.outlook.com",
            "smtp.office365.com",
            "smtp.mail.yahoo.com",
            "smtp.aol.com"});
            this.smtpCombo.Location = new System.Drawing.Point(173, 49);
            this.smtpCombo.Name = "smtpCombo";
            this.smtpCombo.Size = new System.Drawing.Size(282, 21);
            this.smtpCombo.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose SMTP Server:";
            // 
            // EmailChangeForm
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 128);
            this.ControlBox = false;
            this.Controls.Add(this.smtpCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailCancelButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.InstructionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EmailChangeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Email Update";
            this.Load += new System.EventHandler(this.EmailChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button EmailCancelButton;
        private System.Windows.Forms.ComboBox smtpCombo;
        private System.Windows.Forms.Label label2;
    }
}