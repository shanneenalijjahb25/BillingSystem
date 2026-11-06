namespace BillingSystem
{
    partial class frmAnalytics
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
            pnlHeader = new Panel();
            btnAnalytics = new Button();
            btnCloseAnalytics = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlKpi = new Panel();
            tlpKpi = new TableLayoutPanel();
            cardCustomers = new Panel();
            lblTotalCustomers = new Label();
            lblCapCustomers = new Label();
            accentCustomers = new Panel();
            cardRevenue = new Panel();
            lblTotalRevenue = new Label();
            lblCapRevenue = new Label();
            accentRevenue = new Panel();
            cardUnpaid = new Panel();
            lblTotalUnpaid = new Label();
            lblCapUnpaid = new Label();
            accentUnpaid = new Panel();
            tlpMain = new TableLayoutPanel();
            plotMonthlyRevenue = new ScottPlot.WinForms.FormsPlot();
            plotPaidUnpaid = new ScottPlot.WinForms.FormsPlot();
            pnlTop5 = new Panel();
            dgvTop5 = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            TotalConsumption = new DataGridViewTextBoxColumn();
            TotalBilled = new DataGridViewTextBoxColumn();
            lblTop5Title = new Label();
            pnlHeader.SuspendLayout();
            pnlKpi.SuspendLayout();
            tlpKpi.SuspendLayout();
            cardCustomers.SuspendLayout();
            cardRevenue.SuspendLayout();
            cardUnpaid.SuspendLayout();
            tlpMain.SuspendLayout();
            pnlTop5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(btnAnalytics);
            pnlHeader.Controls.Add(btnCloseAnalytics);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 76);
            pnlHeader.TabIndex = 0;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnalytics.Location = new Point(739, 20);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Size = new Size(96, 34);
            btnAnalytics.TabIndex = 0;
            btnAnalytics.Text = "Analytics";
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // btnCloseAnalytics
            // 
            btnCloseAnalytics.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseAnalytics.Location = new Point(884, 20);
            btnCloseAnalytics.Name = "btnCloseAnalytics";
            btnCloseAnalytics.Size = new Size(96, 34);
            btnCloseAnalytics.TabIndex = 0;
            btnCloseAnalytics.Text = "Close";
            btnCloseAnalytics.Click += btnCloseAnalytics_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(23, 46);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(383, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Revenue, billing status, and top consumers at a glance";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(268, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Analytics Dashboard";
            // 
            // pnlKpi
            // 
            pnlKpi.Controls.Add(tlpKpi);
            pnlKpi.Dock = DockStyle.Top;
            pnlKpi.Location = new Point(0, 76);
            pnlKpi.Name = "pnlKpi";
            pnlKpi.Padding = new Padding(14, 14, 14, 2);
            pnlKpi.Size = new Size(1000, 108);
            pnlKpi.TabIndex = 1;
            // 
            // tlpKpi
            // 
            tlpKpi.ColumnCount = 3;
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tlpKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.34F));
            tlpKpi.Controls.Add(cardCustomers, 0, 0);
            tlpKpi.Controls.Add(cardRevenue, 1, 0);
            tlpKpi.Controls.Add(cardUnpaid, 2, 0);
            tlpKpi.Dock = DockStyle.Fill;
            tlpKpi.Location = new Point(14, 14);
            tlpKpi.Name = "tlpKpi";
            tlpKpi.RowCount = 1;
            tlpKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpKpi.Size = new Size(972, 92);
            tlpKpi.TabIndex = 0;
            // 
            // cardCustomers
            // 
            cardCustomers.Controls.Add(lblTotalCustomers);
            cardCustomers.Controls.Add(lblCapCustomers);
            cardCustomers.Controls.Add(accentCustomers);
            cardCustomers.Dock = DockStyle.Fill;
            cardCustomers.Location = new Point(6, 0);
            cardCustomers.Margin = new Padding(6, 0, 6, 0);
            cardCustomers.Name = "cardCustomers";
            cardCustomers.Size = new Size(311, 92);
            cardCustomers.TabIndex = 0;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.Location = new Point(20, 38);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(39, 46);
            lblTotalCustomers.TabIndex = 0;
            lblTotalCustomers.Text = "0";
            // 
            // lblCapCustomers
            // 
            lblCapCustomers.AutoSize = true;
            lblCapCustomers.Location = new Point(22, 14);
            lblCapCustomers.Name = "lblCapCustomers";
            lblCapCustomers.Size = new Size(147, 21);
            lblCapCustomers.TabIndex = 1;
            lblCapCustomers.Text = "TOTAL CUSTOMERS";
            // 
            // accentCustomers
            // 
            accentCustomers.Dock = DockStyle.Left;
            accentCustomers.Location = new Point(0, 0);
            accentCustomers.Name = "accentCustomers";
            accentCustomers.Size = new Size(6, 92);
            accentCustomers.TabIndex = 2;
            // 
            // cardRevenue
            // 
            cardRevenue.Controls.Add(lblTotalRevenue);
            cardRevenue.Controls.Add(lblCapRevenue);
            cardRevenue.Controls.Add(accentRevenue);
            cardRevenue.Dock = DockStyle.Fill;
            cardRevenue.Location = new Point(329, 0);
            cardRevenue.Margin = new Padding(6, 0, 6, 0);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Size = new Size(311, 92);
            cardRevenue.TabIndex = 1;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.Location = new Point(20, 38);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(106, 46);
            lblTotalRevenue.TabIndex = 0;
            lblTotalRevenue.Text = "₱0.00";
            // 
            // lblCapRevenue
            // 
            lblCapRevenue.AutoSize = true;
            lblCapRevenue.Location = new Point(22, 14);
            lblCapRevenue.Name = "lblCapRevenue";
            lblCapRevenue.Size = new Size(171, 21);
            lblCapRevenue.TabIndex = 1;
            lblCapRevenue.Text = "TOTAL REVENUE (PAID)";
            // 
            // accentRevenue
            // 
            accentRevenue.Dock = DockStyle.Left;
            accentRevenue.Location = new Point(0, 0);
            accentRevenue.Name = "accentRevenue";
            accentRevenue.Size = new Size(6, 92);
            accentRevenue.TabIndex = 2;
            // 
            // cardUnpaid
            // 
            cardUnpaid.Controls.Add(lblTotalUnpaid);
            cardUnpaid.Controls.Add(lblCapUnpaid);
            cardUnpaid.Controls.Add(accentUnpaid);
            cardUnpaid.Dock = DockStyle.Fill;
            cardUnpaid.Location = new Point(652, 0);
            cardUnpaid.Margin = new Padding(6, 0, 6, 0);
            cardUnpaid.Name = "cardUnpaid";
            cardUnpaid.Size = new Size(314, 92);
            cardUnpaid.TabIndex = 2;
            // 
            // lblTotalUnpaid
            // 
            lblTotalUnpaid.AutoSize = true;
            lblTotalUnpaid.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUnpaid.Location = new Point(20, 38);
            lblTotalUnpaid.Name = "lblTotalUnpaid";
            lblTotalUnpaid.Size = new Size(106, 46);
            lblTotalUnpaid.TabIndex = 0;
            lblTotalUnpaid.Text = "₱0.00";
            // 
            // lblCapUnpaid
            // 
            lblCapUnpaid.AutoSize = true;
            lblCapUnpaid.Location = new Point(22, 14);
            lblCapUnpaid.Name = "lblCapUnpaid";
            lblCapUnpaid.Size = new Size(113, 21);
            lblCapUnpaid.TabIndex = 1;
            lblCapUnpaid.Text = "TOTAL UNPAID";
            // 
            // accentUnpaid
            // 
            accentUnpaid.Dock = DockStyle.Left;
            accentUnpaid.Location = new Point(0, 0);
            accentUnpaid.Name = "accentUnpaid";
            accentUnpaid.Size = new Size(6, 92);
            accentUnpaid.TabIndex = 2;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));
            tlpMain.Controls.Add(plotMonthlyRevenue, 0, 0);
            tlpMain.Controls.Add(plotPaidUnpaid, 1, 0);
            tlpMain.Controls.Add(pnlTop5, 0, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 184);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(14, 8, 14, 14);
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 56F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 44F));
            tlpMain.Size = new Size(1000, 476);
            tlpMain.TabIndex = 2;
            // 
            // plotMonthlyRevenue
            // 
            plotMonthlyRevenue.Dock = DockStyle.Fill;
            plotMonthlyRevenue.Location = new Point(20, 14);
            plotMonthlyRevenue.Margin = new Padding(6);
            plotMonthlyRevenue.Name = "plotMonthlyRevenue";
            plotMonthlyRevenue.Size = new Size(551, 242);
            plotMonthlyRevenue.TabIndex = 0;
            // 
            // plotPaidUnpaid
            // 
            plotPaidUnpaid.Dock = DockStyle.Fill;
            plotPaidUnpaid.Location = new Point(583, 14);
            plotPaidUnpaid.Margin = new Padding(6);
            plotPaidUnpaid.Name = "plotPaidUnpaid";
            plotPaidUnpaid.Size = new Size(397, 242);
            plotPaidUnpaid.TabIndex = 1;
            // 
            // pnlTop5
            // 
            tlpMain.SetColumnSpan(pnlTop5, 2);
            pnlTop5.Controls.Add(dgvTop5);
            pnlTop5.Controls.Add(lblTop5Title);
            pnlTop5.Dock = DockStyle.Fill;
            pnlTop5.Location = new Point(20, 268);
            pnlTop5.Margin = new Padding(6);
            pnlTop5.Name = "pnlTop5";
            pnlTop5.Size = new Size(960, 188);
            pnlTop5.TabIndex = 2;
            // 
            // dgvTop5
            // 
            dgvTop5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5.ColumnHeadersHeight = 29;
            dgvTop5.Columns.AddRange(new DataGridViewColumn[] { FullName, TotalConsumption, TotalBilled });
            dgvTop5.Dock = DockStyle.Fill;
            dgvTop5.Location = new Point(0, 40);
            dgvTop5.Name = "dgvTop5";
            dgvTop5.RowHeadersWidth = 51;
            dgvTop5.Size = new Size(960, 148);
            dgvTop5.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.FillWeight = 50F;
            FullName.HeaderText = "Customer Name";
            FullName.MinimumWidth = 80;
            FullName.Name = "FullName";
            // 
            // TotalConsumption
            // 
            TotalConsumption.FillWeight = 25F;
            TotalConsumption.HeaderText = "Consumption (kWh)";
            TotalConsumption.MinimumWidth = 80;
            TotalConsumption.Name = "TotalConsumption";
            // 
            // TotalBilled
            // 
            TotalBilled.FillWeight = 25F;
            TotalBilled.HeaderText = "Total Billed (₱)";
            TotalBilled.MinimumWidth = 80;
            TotalBilled.Name = "TotalBilled";
            // 
            // lblTop5Title
            // 
            lblTop5Title.Dock = DockStyle.Top;
            lblTop5Title.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop5Title.Location = new Point(0, 0);
            lblTop5Title.Name = "lblTop5Title";
            lblTop5Title.Padding = new Padding(14, 0, 0, 0);
            lblTop5Title.Size = new Size(960, 40);
            lblTop5Title.TabIndex = 1;
            lblTop5Title.Text = "Top 5 Customers by Consumption";
            lblTop5Title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmAnalytics
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1000, 660);
            Controls.Add(tlpMain);
            Controls.Add(pnlKpi);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(900, 580);
            Name = "frmAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing System - Analytics Dashboard";
            Load += frmAnalytics_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlKpi.ResumeLayout(false);
            tlpKpi.ResumeLayout(false);
            cardCustomers.ResumeLayout(false);
            cardCustomers.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            cardUnpaid.ResumeLayout(false);
            cardUnpaid.PerformLayout();
            tlpMain.ResumeLayout(false);
            pnlTop5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTop5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Button btnCloseAnalytics;
        private Panel pnlKpi;
        private TableLayoutPanel tlpKpi;
        private Panel cardCustomers;
        private Panel accentCustomers;
        private Label lblCapCustomers;
        private Label lblTotalCustomers;
        private Panel cardRevenue;
        private Panel accentRevenue;
        private Label lblCapRevenue;
        private Label lblTotalRevenue;
        private Panel cardUnpaid;
        private Panel accentUnpaid;
        private Label lblCapUnpaid;
        private Label lblTotalUnpaid;
        private TableLayoutPanel tlpMain;
        private ScottPlot.WinForms.FormsPlot plotMonthlyRevenue;
        private ScottPlot.WinForms.FormsPlot plotPaidUnpaid;
        private Panel pnlTop5;
        private Label lblTop5Title;
        private DataGridView dgvTop5;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn TotalConsumption;
        private DataGridViewTextBoxColumn TotalBilled;
        private Button btnAnalytics;
    }
}