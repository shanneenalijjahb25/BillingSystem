namespace BillingSystem
{
    partial class frmBillingHistory
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
            lblBillingHistory = new Label();
            dgvBillingHistory = new DataGridView();
            btnClose = new Button();
            BillingMonth = new DataGridViewTextBoxColumn();
            PreviousReading = new DataGridViewTextBoxColumn();
            PresentReading = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).BeginInit();
            SuspendLayout();
            // 
            // lblBillingHistory
            // 
            lblBillingHistory.AutoSize = true;
            lblBillingHistory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillingHistory.ForeColor = Color.FromArgb(31, 78, 121);
            lblBillingHistory.Location = new Point(78, 45);
            lblBillingHistory.Name = "lblBillingHistory";
            lblBillingHistory.Size = new Size(205, 38);
            lblBillingHistory.TabIndex = 0;
            lblBillingHistory.Text = "Billing History";
            // 
            // dgvBillingHistory
            // 
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.AllowUserToDeleteRows = false;
            dgvBillingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillingHistory.BackgroundColor = Color.White;
            dgvBillingHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBillingHistory.Columns.AddRange(new DataGridViewColumn[] { BillingMonth, PreviousReading, PresentReading, Consumption, Rate, TotalAmount, Status });
            dgvBillingHistory.GridColor = Color.Gainsboro;
            dgvBillingHistory.Location = new Point(40, 100);
            dgvBillingHistory.Name = "dgvBillingHistory";
            dgvBillingHistory.ReadOnly = true;
            dgvBillingHistory.RowHeadersVisible = false;
            dgvBillingHistory.RowHeadersWidth = 51;
            dgvBillingHistory.ScrollBars = ScrollBars.Vertical;
            dgvBillingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillingHistory.Size = new Size(698, 245);
            dgvBillingHistory.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.ForeColor = Color.FromArgb(31, 78, 121);
            btnClose.Location = new Point(625, 371);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 30);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // BillingMonth
            // 
            BillingMonth.FillWeight = 105F;
            BillingMonth.HeaderText = "Billing Month";
            BillingMonth.MinimumWidth = 7;
            BillingMonth.Name = "BillingMonth";
            BillingMonth.ReadOnly = true;
            // 
            // PreviousReading
            // 
            PreviousReading.HeaderText = "Previous Reading";
            PreviousReading.MinimumWidth = 6;
            PreviousReading.Name = "PreviousReading";
            PreviousReading.ReadOnly = true;
            // 
            // PresentReading
            // 
            PresentReading.HeaderText = "Present Reading";
            PresentReading.MinimumWidth = 6;
            PresentReading.Name = "PresentReading";
            PresentReading.ReadOnly = true;
            // 
            // Consumption
            // 
            Consumption.HeaderText = "Consumption";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            Consumption.ReadOnly = true;
            // 
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.MinimumWidth = 6;
            Rate.Name = "Rate";
            Rate.ReadOnly = true;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnClose);
            Controls.Add(dgvBillingHistory);
            Controls.Add(lblBillingHistory);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            Load += frmBillingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBillingHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBillingHistory;
        private DataGridView dgvBillingHistory;
        private Button btnClose;
        private DataGridViewTextBoxColumn BillingMonth;
        private DataGridViewTextBoxColumn PreviousReading;
        private DataGridViewTextBoxColumn PresentReading;
        private DataGridViewTextBoxColumn Consumption;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
    }
}