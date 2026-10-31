using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;

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
            _customerId = customerId;
            dataGridView1.AutoGenerateColumns = false;

            // Set up column data bindings
            dataGridView1.Columns["BillingMonth"].DataPropertyName = "BillingMonth";
            dataGridView1.Columns["PreviousReading"].DataPropertyName = "PreviousReading";
            dataGridView1.Columns["PresentReading"].DataPropertyName = "PresentReading";
            dataGridView1.Columns["Consumption"].DataPropertyName = "Consumption";
            dataGridView1.Columns["RatePerCubic"].DataPropertyName = "RatePerCubic";
            dataGridView1.Columns["TotalAmount"].DataPropertyName = "TotalAmount";
            dataGridView1.Columns["Status"].DataPropertyName = "Status";
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
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading billing history:\n {ex.Message}",
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

