using BillingSystem.Utils;

namespace BillingSystem
{
    partial class CustomerListForm
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
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            btnManagePermissions = new Button();
            lblCount = new Label();
            lblTitle = new Label();
            pnlToolbar = new Panel();
            btnViewBilling = new Button();
            btnAnalytics = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvCustomers = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            ContactNumber = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Balance = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlActions = new Panel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExportPdf = new Button();
            btnExportExcel = new Button();
            btnAuditLog = new Button();
            btnChangePassword = new Button();
            btnLogout = new Button();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            lblStatusSep = new ToolStripStatusLabel();
            lblStatusTime = new ToolStripStatusLabel();
            statusTimer = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            pnlActions.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnManagePermissions);
            pnlHeader.Controls.Add(lblCount);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(960, 76);
            pnlHeader.TabIndex = 0;
            // 
            // btnManagePermissions
            // 
            btnManagePermissions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnManagePermissions.Location = new Point(834, 21);
            btnManagePermissions.Name = "btnManagePermissions";
            btnManagePermissions.Size = new Size(110, 34);
            btnManagePermissions.TabIndex = 2;
            btnManagePermissions.Text = "👤 Manage";
            btnManagePermissions.Click += btnManagePermissions_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(23, 46);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(85, 21);
            lblCount.TabIndex = 1;
            lblCount.Text = "0 record(s)";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(185, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Customer List";
            // 
            // pnlToolbar
            // 
            pnlToolbar.Controls.Add(btnViewBilling);
            pnlToolbar.Controls.Add(btnAnalytics);
            pnlToolbar.Controls.Add(txtSearch);
            pnlToolbar.Controls.Add(btnSearch);
            pnlToolbar.Dock = DockStyle.Top;
            pnlToolbar.Location = new Point(0, 76);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(960, 56);
            pnlToolbar.TabIndex = 1;
            // 
            // btnViewBilling
            // 
            btnViewBilling.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewBilling.Location = new Point(16, 12);
            btnViewBilling.Name = "btnViewBilling";
            btnViewBilling.Size = new Size(140, 32);
            btnViewBilling.TabIndex = 0;
            btnViewBilling.Text = "📄 View Billing";
            btnViewBilling.Click += btnViewBilling_Click;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Location = new Point(164, 12);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(130, 32);
            btnAnalytics.TabIndex = 1;
            btnAnalytics.Text = "📊 Analytics";
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(596, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search name, address, contact...";
            txtSearch.Size = new Size(240, 27);
            txtSearch.TabIndex = 2;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(844, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "🔍 Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnHeadersHeight = 29;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { CustomerID, FullName, Address, ContactNumber, Email, Balance, Status });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 132);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(960, 342);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.CellDoubleClick += dgvCustomers_CellDoubleClick;
            dgvCustomers.CellFormatting += dgvCustomers_CellFormatting;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.FillWeight = 35F;
            CustomerID.HeaderText = "ID";
            CustomerID.MinimumWidth = 40;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FullName
            // 
            FullName.FillWeight = 110F;
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 80;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            // 
            // Address
            // 
            Address.FillWeight = 130F;
            Address.HeaderText = "Address";
            Address.MinimumWidth = 80;
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // ContactNumber
            // 
            ContactNumber.FillWeight = 90F;
            ContactNumber.HeaderText = "Contact No.";
            ContactNumber.MinimumWidth = 80;
            ContactNumber.Name = "ContactNumber";
            ContactNumber.ReadOnly = true;
            // 
            // Email
            // 
            Email.FillWeight = 130F;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 80;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Balance
            // 
            Balance.FillWeight = 75F;
            Balance.HeaderText = "Balance (₱)";
            Balance.MinimumWidth = 70;
            Balance.Name = "Balance";
            Balance.ReadOnly = true;
            // 
            // Status
            // 
            Status.FillWeight = 65F;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 60;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnAdd);
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnExportPdf);
            pnlActions.Controls.Add(btnExportExcel);
            pnlActions.Controls.Add(btnAuditLog);
            pnlActions.Controls.Add(btnChangePassword);
            pnlActions.Controls.Add(btnLogout);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 474);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(960, 64);
            pnlActions.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(16, 14);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Add Customer";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(174, 14);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 36);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(300, 14);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(100, 36);
            btnExportPdf.TabIndex = 2;
            btnExportPdf.Text = "📋 PDF";
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(408, 14);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(100, 36);
            btnExportExcel.TabIndex = 3;
            btnExportExcel.Text = "📊 Excel";
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnAuditLog
            // 
            btnAuditLog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAuditLog.Location = new Point(558, 14);
            btnAuditLog.Name = "btnAuditLog";
            btnAuditLog.Size = new Size(110, 36);
            btnAuditLog.TabIndex = 4;
            btnAuditLog.Text = "📝 Audit Log";
            btnAuditLog.Click += btnAuditLog_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePassword.Location = new Point(676, 14);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(160, 36);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "🔐 Change Password";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.Location = new Point(844, 14);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 36);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "🚪 Logout";
            btnLogout.Click += btnLogout_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser, lblStatusSep, lblStatusTime });
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(960, 22);
            statusStrip1.TabIndex = 4;
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(0, 16);
            // 
            // lblStatusSep
            // 
            lblStatusSep.Name = "lblStatusSep";
            lblStatusSep.Size = new Size(945, 16);
            lblStatusSep.Spring = true;
            // 
            // lblStatusTime
            // 
            lblStatusTime.Name = "lblStatusTime";
            lblStatusTime.Size = new Size(0, 16);
            // 
            // statusTimer
            // 
            statusTimer.Enabled = true;
            statusTimer.Interval = 1000;
            statusTimer.Tick += statusTimer_Tick;
            // 
            // CustomerListForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(960, 560);
            Controls.Add(dgvCustomers);
            Controls.Add(pnlActions);
            Controls.Add(statusStrip1);
            Controls.Add(pnlToolbar);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(900, 480);
            Name = "CustomerListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System v1.0 – Customer List(J.R.)";
            Load += CustomerListForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            pnlActions.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblCount;
        private Button btnManagePermissions;
        private Panel pnlToolbar;
        private Button btnViewBilling;
        private Button btnAnalytics;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn ContactNumber;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Balance;
        private DataGridViewTextBoxColumn Status;
        private Panel pnlActions;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExportPdf;
        private Button btnExportExcel;
        private Button btnAuditLog;
        private Button btnChangePassword;
        private Button btnLogout;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusUser;
        private ToolStripStatusLabel lblStatusSep;
        private ToolStripStatusLabel lblStatusTime;
        private System.Windows.Forms.Timer statusTimer;
     }
}