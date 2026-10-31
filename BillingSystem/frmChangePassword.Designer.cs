namespace BillingSystem
{
    partial class frmChangePassword
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
            lblTitleChangePass = new Label();
            lblCurrentPass = new Label();
            lblNewPass = new Label();
            lblRetypePass = new Label();
            tbCurrentPassword = new TextBox();
            tbNewPassword = new TextBox();
            tbRetypePassword = new TextBox();
            btnSavePassword = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitleChangePass
            // 
            lblTitleChangePass.AutoSize = true;
            lblTitleChangePass.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleChangePass.Location = new Point(109, 24);
            lblTitleChangePass.Name = "lblTitleChangePass";
            lblTitleChangePass.Size = new Size(200, 31);
            lblTitleChangePass.TabIndex = 0;
            lblTitleChangePass.Text = "Change Password";
            // 
            // lblCurrentPass
            // 
            lblCurrentPass.AutoSize = true;
            lblCurrentPass.Location = new Point(56, 92);
            lblCurrentPass.Name = "lblCurrentPass";
            lblCurrentPass.Size = new Size(125, 20);
            lblCurrentPass.TabIndex = 1;
            lblCurrentPass.Text = "Current Password:";
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Location = new Point(56, 157);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(107, 20);
            lblNewPass.TabIndex = 2;
            lblNewPass.Text = "New Password:";
            // 
            // lblRetypePass
            // 
            lblRetypePass.AutoSize = true;
            lblRetypePass.Location = new Point(56, 227);
            lblRetypePass.Name = "lblRetypePass";
            lblRetypePass.Size = new Size(123, 20);
            lblRetypePass.TabIndex = 3;
            lblRetypePass.Text = "Retype Password:";
            // 
            // tbCurrentPassword
            // 
            tbCurrentPassword.Location = new Point(242, 92);
            tbCurrentPassword.Name = "tbCurrentPassword";
            tbCurrentPassword.Size = new Size(125, 27);
            tbCurrentPassword.TabIndex = 4;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(242, 157);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(125, 27);
            tbNewPassword.TabIndex = 5;
            // 
            // tbRetypePassword
            // 
            tbRetypePassword.Location = new Point(242, 220);
            tbRetypePassword.Name = "tbRetypePassword";
            tbRetypePassword.Size = new Size(125, 27);
            tbRetypePassword.TabIndex = 6;
            // 
            // btnSavePassword
            // 
            btnSavePassword.Location = new Point(93, 287);
            btnSavePassword.Name = "btnSavePassword";
            btnSavePassword.Size = new Size(122, 29);
            btnSavePassword.TabIndex = 7;
            btnSavePassword.Text = "Save Password";
            btnSavePassword.UseVisualStyleBackColor = true;
            btnSavePassword.Click += btnSavePassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 287);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 353);
            Controls.Add(btnCancel);
            Controls.Add(btnSavePassword);
            Controls.Add(tbRetypePassword);
            Controls.Add(tbNewPassword);
            Controls.Add(tbCurrentPassword);
            Controls.Add(lblRetypePass);
            Controls.Add(lblNewPass);
            Controls.Add(lblCurrentPass);
            Controls.Add(lblTitleChangePass);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmChangePassword";
            Text = "frmChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitleChangePass;
        private Label lblCurrentPass;
        private Label lblNewPass;
        private Label lblRetypePass;
        private TextBox tbCurrentPassword;
        private TextBox tbNewPassword;
        private TextBox tbRetypePassword;
        private Button btnSavePassword;
        private Button btnCancel;
    }
}