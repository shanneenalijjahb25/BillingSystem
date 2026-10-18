namespace BillingSystem
{
    partial class frmManagePermissions
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
            lblRole = new Label();
            cmbRole = new ComboBox();
            chkAddCustomer = new CheckBox();
            chkEditCustomer = new CheckBox();
            chkDeleteCustomer = new CheckBox();
            chkAnalytics = new CheckBox();
            chkExportExcel = new CheckBox();
            chkExportPdf = new CheckBox();
            chkAuditLogs = new CheckBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(94, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 26);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Permissions";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(37, 100);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(84, 17);
            lblRole.TabIndex = 1;
            lblRole.Text = "Select Role:";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Cashier" });
            cmbRole.Location = new Point(139, 95);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(235, 28);
            cmbRole.TabIndex = 2;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // chkAddCustomer
            // 
            chkAddCustomer.AutoSize = true;
            chkAddCustomer.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAddCustomer.Location = new Point(55, 144);
            chkAddCustomer.Name = "chkAddCustomer";
            chkAddCustomer.Size = new Size(121, 21);
            chkAddCustomer.TabIndex = 3;
            chkAddCustomer.Text = "AddCustomer";
            chkAddCustomer.UseVisualStyleBackColor = true;
            // 
            // chkEditCustomer
            // 
            chkEditCustomer.AutoSize = true;
            chkEditCustomer.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkEditCustomer.Location = new Point(55, 171);
            chkEditCustomer.Name = "chkEditCustomer";
            chkEditCustomer.Size = new Size(124, 21);
            chkEditCustomer.TabIndex = 4;
            chkEditCustomer.Text = "Edit Customer";
            chkEditCustomer.UseVisualStyleBackColor = true;
            // 
            // chkDeleteCustomer
            // 
            chkDeleteCustomer.AutoSize = true;
            chkDeleteCustomer.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkDeleteCustomer.Location = new Point(55, 198);
            chkDeleteCustomer.Name = "chkDeleteCustomer";
            chkDeleteCustomer.Size = new Size(139, 21);
            chkDeleteCustomer.TabIndex = 5;
            chkDeleteCustomer.Text = "Delete Customer";
            chkDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // chkAnalytics
            // 
            chkAnalytics.AutoSize = true;
            chkAnalytics.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAnalytics.Location = new Point(55, 225);
            chkAnalytics.Name = "chkAnalytics";
            chkAnalytics.Size = new Size(91, 21);
            chkAnalytics.TabIndex = 6;
            chkAnalytics.Text = "Analytics";
            chkAnalytics.UseVisualStyleBackColor = true;
            // 
            // chkExportExcel
            // 
            chkExportExcel.AutoSize = true;
            chkExportExcel.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExportExcel.Location = new Point(55, 252);
            chkExportExcel.Name = "chkExportExcel";
            chkExportExcel.Size = new Size(131, 21);
            chkExportExcel.TabIndex = 7;
            chkExportExcel.Text = "Export to Excel";
            chkExportExcel.UseVisualStyleBackColor = true;
            // 
            // chkExportPdf
            // 
            chkExportPdf.AutoSize = true;
            chkExportPdf.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkExportPdf.Location = new Point(55, 279);
            chkExportPdf.Name = "chkExportPdf";
            chkExportPdf.Size = new Size(125, 21);
            chkExportPdf.TabIndex = 8;
            chkExportPdf.Text = "Export to PDF";
            chkExportPdf.UseVisualStyleBackColor = true;
            // 
            // chkAuditLogs
            // 
            chkAuditLogs.AutoSize = true;
            chkAuditLogs.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAuditLogs.Location = new Point(55, 306);
            chkAuditLogs.Name = "chkAuditLogs";
            chkAuditLogs.Size = new Size(102, 21);
            chkAuditLogs.TabIndex = 9;
            chkAuditLogs.Text = "Audit Logs";
            chkAuditLogs.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(70, 351);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(134, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Permissions";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(234, 351);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmManagePermissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 413);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(chkAuditLogs);
            Controls.Add(chkExportPdf);
            Controls.Add(chkExportExcel);
            Controls.Add(chkAnalytics);
            Controls.Add(chkDeleteCustomer);
            Controls.Add(chkEditCustomer);
            Controls.Add(chkAddCustomer);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmManagePermissions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Permissions";
            Load += frmManagePermissions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblRole;
        private ComboBox cmbRole;
        private CheckBox chkAddCustomer;
        private CheckBox chkEditCustomer;
        private CheckBox chkDeleteCustomer;
        private CheckBox chkAnalytics;
        private CheckBox chkExportExcel;
        private CheckBox chkExportPdf;
        private CheckBox chkAuditLogs;
        private Button btnSave;
        private Button btnClose;
    }
}