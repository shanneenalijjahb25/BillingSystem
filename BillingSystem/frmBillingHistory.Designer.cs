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
            dataGridView1 = new DataGridView();
            BillingMonth = new DataGridViewTextBoxColumn();
            PreviousReading = new DataGridViewTextBoxColumn();
            PresentReading = new DataGridViewTextBoxColumn();
            Consumption = new DataGridViewTextBoxColumn();
            RatePerCubic = new DataGridViewTextBoxColumn();
            TotalAmount = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblBillingHistory
            // 
            lblBillingHistory.AutoSize = true;
            lblBillingHistory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBillingHistory.Location = new Point(72, 44);
            lblBillingHistory.Name = "lblBillingHistory";
            lblBillingHistory.Size = new Size(171, 31);
            lblBillingHistory.TabIndex = 0;
            lblBillingHistory.Text = "Billing History";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BillingMonth, PreviousReading, PresentReading, Consumption, RatePerCubic, TotalAmount, Status });
            dataGridView1.Location = new Point(72, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(640, 245);
            dataGridView1.TabIndex = 1;
            // 
            // BillingMonth
            // 
            BillingMonth.HeaderText = "Billing Month";
            BillingMonth.MinimumWidth = 6;
            BillingMonth.Name = "BillingMonth";
            BillingMonth.Width = 90;
            // 
            // PreviousReading
            // 
            PreviousReading.HeaderText = "Previous Reading";
            PreviousReading.MinimumWidth = 6;
            PreviousReading.Name = "PreviousReading";
            PreviousReading.Width = 80;
            // 
            // PresentReading
            // 
            PresentReading.HeaderText = "Present Reading";
            PresentReading.MinimumWidth = 6;
            PresentReading.Name = "PresentReading";
            PresentReading.Width = 80;
            // 
            // Consumption
            // 
            Consumption.HeaderText = "Consumption";
            Consumption.MinimumWidth = 6;
            Consumption.Name = "Consumption";
            Consumption.Width = 99;
            // 
            // RatePerCubic
            // 
            RatePerCubic.HeaderText = "Rate";
            RatePerCubic.MinimumWidth = 6;
            RatePerCubic.Name = "RatePerCubic";
            RatePerCubic.Width = 80;
            // 
            // TotalAmount
            // 
            TotalAmount.HeaderText = "Total Amount";
            TotalAmount.MinimumWidth = 6;
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Width = 80;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.Width = 80;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(618, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmBillingHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(lblBillingHistory);
            Name = "frmBillingHistory";
            Text = "frmBillingHistory";
            Load += frmBillingHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBillingHistory;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BillingMonth;
        private DataGridViewTextBoxColumn PreviousReading;
        private DataGridViewTextBoxColumn PresentReading;
        private DataGridViewTextBoxColumn Consumption;
        private DataGridViewTextBoxColumn RatePerCubic;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn Status;
        private Button btnClose;
    }
}