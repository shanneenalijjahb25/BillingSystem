using BillingSystem.Database;
using BillingSystem.Utils;
using DocumentFormat.OpenXml.Drawing;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        private int _customerId = 0;
        private string _customerName = string.Empty;

        // Constructor that receives customer ID and name
        public frmBillingHistory(int customerId)
        {
            InitializeComponent();
            Theme();
            _customerId = customerId;
            dgvBillingHistory.AutoGenerateColumns = false;

            // Set up column data bindings
            dgvBillingHistory.Columns["BillingMonth"].DataPropertyName = "BillingMonth";
            dgvBillingHistory.Columns["PreviousReading"].DataPropertyName = "PreviousReading";
            dgvBillingHistory.Columns["PresentReading"].DataPropertyName = "PresentReading";
            dgvBillingHistory.Columns["Consumption"].DataPropertyName = "Consumption";
            dgvBillingHistory.Columns["Rate"].DataPropertyName = "Rate";
            dgvBillingHistory.Columns["TotalAmount"].DataPropertyName = "TotalAmount";
            dgvBillingHistory.Columns["Status"].DataPropertyName = "Status";
        }

        private void frmBillingHistory_Load(object sender, EventArgs e)
        {
            // Step 1: Load the customer's name from the database
            if (!LoadCustomerName())
            {
                MessageBox.Show("Failed to load customer information.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Step 2: Update the title label with the customer's name
            lblBillingHistory.Text = $"Billing History for {_customerName}";

            // Step 3: Load the billing history for the chosen customer
            LoadBillingHistory();
        }

        private bool LoadCustomerName()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT FullName
                        FROM Customers 
                        WHERE CustomerID = @CustomerID";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", _customerId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _customerName = reader.GetString("FullName");
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer name:\n {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void LoadBillingHistory()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Parameterized query — retrieves billing records for this customer only
                    // Sorted by billing month in descending order (newest first)
                    string sql = @"SELECT BillingMonth,
                                  PreviousReading,
                                  PresentReading,
                                  Consumption,
                                  RatePerCubic,
                                  TotalAmount,
                                  Status
                           FROM   Billing
                           WHERE  CustomerID = @CustomerID
                           ORDER  BY BillingMonth DESC;";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", _customerId);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Check if any records were found
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                $"No billing records found for {_customerName}.",
                                "No Records",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }

                        // Bind the DataTable to the grid (whether empty or not)
                        dgvBillingHistory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading billing history:\n {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Theme()
        {
            // DataGridView Styling
            dgvBillingHistory.EnableHeadersVisualStyles = false;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.BackColor =
                AppTheme.PrimaryColor;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvBillingHistory.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvBillingHistory.AlternatingRowsDefaultCellStyle.BackColor =
                AppTheme.GridRowAlt;

            dgvBillingHistory.DefaultCellStyle.SelectionBackColor =
                AppTheme.AccentColor;

            dgvBillingHistory.DefaultCellStyle.SelectionForeColor =
                AppTheme.TextColor;

            dgvBillingHistory.RowTemplate.Height = 30;

            // Make DataGridView read-only
            dgvBillingHistory.ReadOnly = true;
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.AllowUserToDeleteRows = false;
            dgvBillingHistory.RowHeadersVisible = false;

            dgvBillingHistory.ColumnHeadersHeight = 45;
            dgvBillingHistory.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvBillingHistory.DefaultCellStyle.Padding =
                new Padding(5, 0, 5, 0);

            // DataGridView Styling
            dgvBillingHistory.BackgroundColor = Color.White;
            dgvBillingHistory.BorderStyle = BorderStyle.FixedSingle;
            dgvBillingHistory.GridColor = Color.Gainsboro;

            dgvBillingHistory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBillingHistory.RowHeadersVisible = false;
            dgvBillingHistory.ReadOnly = true;
            dgvBillingHistory.AllowUserToAddRows = false;
            dgvBillingHistory.AllowUserToDeleteRows = false;
            dgvBillingHistory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvBillingHistory.EnableHeadersVisualStyles = false;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.BackColor =
                AppTheme.PrimaryColor;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvBillingHistory.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);

            dgvBillingHistory.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgvBillingHistory.DefaultCellStyle.BackColor = Color.White;

            dgvBillingHistory.AlternatingRowsDefaultCellStyle.BackColor =
                AppTheme.GridRowAlt;

            dgvBillingHistory.DefaultCellStyle.SelectionBackColor =
                AppTheme.AccentColor;

            dgvBillingHistory.DefaultCellStyle.SelectionForeColor =
                AppTheme.TextColor;

            dgvBillingHistory.ColumnHeadersHeight = 40;
            dgvBillingHistory.RowTemplate.Height = 30;

            // Close Button Styling
            btnClose.BackColor = AppTheme.PrimaryColor;
            btnClose.ForeColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.FlatAppearance.BorderSize = 0;

            btnClose.FlatAppearance.MouseOverBackColor =
                AppTheme.DarkenColor(AppTheme.PrimaryColor, 20);

            btnClose.Cursor = Cursors.Hand;
            btnClose.UseVisualStyleBackColor = false;

            dgvBillingHistory.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

            dgvBillingHistory.Columns["BillingMonth"].FillWeight = 110;
            dgvBillingHistory.Columns["PreviousReading"].FillWeight = 110;
            dgvBillingHistory.Columns["PresentReading"].FillWeight = 115;
            dgvBillingHistory.Columns["Consumption"].FillWeight = 125;
            dgvBillingHistory.Columns["Rate"].FillWeight = 85;
            dgvBillingHistory.Columns["TotalAmount"].FillWeight = 110;
            dgvBillingHistory.Columns["Status"].FillWeight = 90;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

