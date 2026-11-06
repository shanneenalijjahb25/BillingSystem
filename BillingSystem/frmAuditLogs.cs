using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BillingSystem.Database;
using BillingSystem.Utils;

namespace BillingSystem
{
    public partial class frmAuditLogs : Form
    {
        private readonly Font _boldFont = new Font("Segoe UI Semibold", 9.5F);

        public frmAuditLogs()
        {
            InitializeComponent();
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            BackColor = AppTheme.LightBackground;
            ForeColor = AppTheme.TextColor;

            pnlHeader.BackColor = AppTheme.PrimaryColor;
            lblTitle.ForeColor = Color.White;
            lblSubtitle.ForeColor = AppTheme.AccentColor;

            pnlFilter.BackColor = AppTheme.CardColor;
            pnlFooter.BackColor = AppTheme.CardColor;
            lblCount.ForeColor = AppTheme.MutedTextColor;

            AppTheme.StylePrimaryButton(btnSearch);
            AppTheme.StyleSecondaryButton(btnReset);
            AppTheme.StyleSecondaryButton(btnClose);

            AppTheme.StyleGrid(dgvAuditLogs);
            dgvAuditLogs.CellFormatting += dgvAuditLogs_CellFormatting;

            // Smoother scrolling
            typeof(DataGridView).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                .SetValue(dgvAuditLogs, true);
        }

        private void frmAuditLogs_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;

            // Log muna bago i-load para lumabas agad sa report
            AuditLogger.Log("VIEW_AUDIT_LOG",
                $"{AppSession.CurrentUsername} viewed the Audit Log Report.");

            LoadAuditLogs(dtpFrom.Value, dtpTo.Value);
        }

        private void LoadAuditLogs(DateTime from, DateTime to)
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT LogID, Username, Role, Action,
                                          Details, LogDate
                                   FROM   AuditLogs
                                   WHERE  LogDate BETWEEN @From AND @To
                                   ORDER  BY LogDate DESC;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@From", from.Date);
                        cmd.Parameters.AddWithValue("@To",
                            to.Date.AddDays(1).AddSeconds(-1));

                        using (var adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvAuditLogs.DataSource = dt;
                            FormatColumns();
                            lblCount.Text = $"{dt.Rows.Count} record(s) found";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading audit logs:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatColumns()
        {
            var g = dgvAuditLogs;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            g.Columns["LogID"].Width = 70;
            g.Columns["Username"].Width = 120;
            g.Columns["Role"].Width = 100;
            g.Columns["Action"].Width = 180;
            g.Columns["Details"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            g.Columns["LogDate"].Width = 170;
            g.Columns["LogDate"].DefaultCellStyle.Format = "MMM dd, yyyy  hh:mm tt";
            g.Columns["LogID"].HeaderText = "ID";
            g.Columns["LogDate"].HeaderText = "Date & Time";
        }

        private void dgvAuditLogs_CellFormatting(object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null ||
                dgvAuditLogs.Columns[e.ColumnIndex].Name != "Action") return;

            string action = e.Value.ToString();
            if (action.StartsWith("LOGIN"))
                e.CellStyle.ForeColor = AppTheme.SuccessColor;
            else if (action.StartsWith("VIEW"))
                e.CellStyle.ForeColor = AppTheme.SecondaryColor;
            else if (action.Contains("DELETE") || action.Contains("FAIL"))
                e.CellStyle.ForeColor = AppTheme.DangerColor;
            else if (action.Contains("UPDATE") || action.Contains("EDIT"))
                e.CellStyle.ForeColor = AppTheme.WarningColor;

            e.CellStyle.Font = _boldFont;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Date > dtpTo.Value.Date)
            {
                MessageBox.Show("Start date cannot be later than end date.",
                    "Invalid Date Range", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            LoadAuditLogs(dtpFrom.Value, dtpTo.Value);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today;
            LoadAuditLogs(dtpFrom.Value, dtpTo.Value);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}