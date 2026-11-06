namespace BillingSystem
{
    partial class frmAuditLogs
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubtitle = new Label();
            pnlFilter = new Panel();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            btnReset = new Button();
            dgvAuditLogs = new DataGridView();
            pnlFooter = new Panel();
            lblCount = new Label();
            btnClose = new Button();
            pnlHeader.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).BeginInit();
            SuspendLayout();
            //
            // pnlHeader
            //
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(882, 80);
            pnlHeader.TabIndex = 0;
            //
            // lblTitle
            //
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(24, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Audit Log Report";
            //
            // lblSubtitle
            //
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(26, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Track user activity across the system";
            //
            // pnlFilter
            //
            pnlFilter.Controls.Add(lblFrom);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(btnSearch);
            pnlFilter.Controls.Add(btnReset);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(882, 64);
            pnlFilter.TabIndex = 1;
            //
            // lblFrom
            //
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(24, 22);
            lblFrom.Name = "lblFrom";
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From";
            //
            // dtpFrom
            //
            dtpFrom.CustomFormat = "MMM dd, yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(72, 17);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 27);
            dtpFrom.TabIndex = 1;
            //
            // lblTo
            //
            lblTo.AutoSize = true;
            lblTo.Location = new Point(246, 22);
            lblTo.Name = "lblTo";
            lblTo.TabIndex = 2;
            lblTo.Text = "To";
            //
            // dtpTo
            //
            dtpTo.CustomFormat = "MMM dd, yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(274, 17);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 27);
            dtpTo.TabIndex = 3;
            //
            // btnSearch
            //
            btnSearch.Location = new Point(448, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(96, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            //
            // btnReset
            //
            btnReset.Location = new Point(552, 15);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 32);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.Click += btnReset_Click;
            //
            // dgvAuditLogs
            //
            dgvAuditLogs.Dock = DockStyle.Fill;
            dgvAuditLogs.Name = "dgvAuditLogs";
            dgvAuditLogs.RowHeadersWidth = 51;
            dgvAuditLogs.TabIndex = 2;
            //
            // pnlFooter
            //
            pnlFooter.Controls.Add(lblCount);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(882, 56);
            pnlFooter.TabIndex = 3;
            //
            // lblCount
            //
            lblCount.AutoSize = true;
            lblCount.Location = new Point(24, 18);
            lblCount.Name = "lblCount";
            lblCount.TabIndex = 0;
            lblCount.Text = "0 record(s) found";
            //
            // btnClose
            //
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(762, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(96, 32);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.Click += btnClose_Click;
            //
            // frmAuditLogs
            //
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(882, 503);
            Controls.Add(dgvAuditLogs);   // Fill muna, tapos Bottom, tapos Top panels
            Controls.Add(pnlFooter);
            Controls.Add(pnlFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(760, 400);
            Name = "frmAuditLogs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit Log Report";
            Load += frmAuditLogs_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAuditLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlFilter;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnSearch;
        private Button btnReset;
        private DataGridView dgvAuditLogs;
        private Panel pnlFooter;
        private Label lblCount;
        private Button btnClose;
    }
}