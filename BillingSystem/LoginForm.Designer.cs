namespace BillingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            label2 = new Label();
            lblUsername = new Label();
            btnLogin = new Button();
            btnCancel = new Button();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(92, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(194, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BILLING SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 27);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(74, 78);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(92, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(192, 184);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(173, 78);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(74, 132);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(lblUsername);
            Controls.Add(label2);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label2;
        private Label lblUsername;
        private Button btnLogin;
        private Button btnCancel;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblPassword;
    }
}
