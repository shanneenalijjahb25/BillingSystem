namespace BillingSystem
{
    partial class AddCustomerForm
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
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblAddress = new Label();
            txtEmail = new TextBox();
            lblContact = new Label();
            txtContact = new TextBox();
            lblEmail = new Label();
            lblBalance = new Label();
            txtAddress = new TextBox();
            txtBalance = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(123, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Customer";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(85, 79);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(79, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(213, 76);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(125, 27);
            txtFullName.TabIndex = 2;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(85, 125);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(213, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(56, 167);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(121, 20);
            lblContact.TabIndex = 5;
            lblContact.Text = "Contact Number:";
            // 
            // txtContact
            // 
            txtContact.Location = new Point(213, 164);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(85, 210);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(63, 252);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(101, 20);
            lblBalance.TabIndex = 8;
            lblBalance.Text = "Inital Balance:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(213, 122);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 9;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(213, 249);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(125, 27);
            txtBalance.TabIndex = 10;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(56, 299);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 26);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(169, 298);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(278, 299);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // AddCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 373);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(btnSave);
            Controls.Add(txtBalance);
            Controls.Add(txtAddress);
            Controls.Add(lblBalance);
            Controls.Add(lblEmail);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(txtEmail);
            Controls.Add(lblAddress);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblAddress;
        private TextBox txtEmail;
        private Label lblContact;
        private TextBox txtContact;
        private Label lblEmail;
        private Label lblBalance;
        private TextBox txtAddress;
        private TextBox txtBalance;
        private Button btnSave;
        private Button btnClear;
        private Button btnBack;
    }
}