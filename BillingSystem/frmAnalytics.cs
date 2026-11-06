using BillingSystem.Database;
using BillingSystem.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DrawingColor = System.Drawing.Color;

namespace BillingSystem
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();

            dgvTop5.AutoGenerateColumns = false;
            dgvTop5.Columns["FullName"].DataPropertyName = "FullName";
            dgvTop5.Columns["TotalConsumption"].DataPropertyName = "TotalConsumption";
            dgvTop5.Columns["TotalBilled"].DataPropertyName = "TotalBilled";

            dgvTop5.Columns["TotalConsumption"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvTop5.Columns["TotalBilled"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvTop5.Columns["TotalBilled"].DefaultCellStyle.Format = "N2";
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            LoadKpiSummary();
            LoadMonthlyRevenueChart();
            LoadPaidUnpaidChart();
            LoadTop5Customers();
        }

        // ================= THEME ================= //

        private void ApplyTheme()
        {
            BackColor = AppTheme.LightBackground;
            ForeColor = AppTheme.TextColor;

            // Header
            pnlHeader.BackColor = AppTheme.PrimaryColor;
            lblTitle.ForeColor = DrawingColor.White;
            lblSubtitle.ForeColor = AppTheme.AccentColor;

            btnCloseAnalytics.FlatStyle = FlatStyle.Flat;
            btnCloseAnalytics.FlatAppearance.BorderColor = DrawingColor.White;
            btnCloseAnalytics.FlatAppearance.MouseOverBackColor = AppTheme.SecondaryColor;
            btnCloseAnalytics.BackColor = AppTheme.PrimaryColor;
            btnCloseAnalytics.ForeColor = DrawingColor.White;
            btnCloseAnalytics.Cursor = Cursors.Hand;
            btnCloseAnalytics.UseVisualStyleBackColor = false;

            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.FlatAppearance.BorderColor = DrawingColor.White;
            btnAnalytics.FlatAppearance.MouseOverBackColor = AppTheme.SecondaryColor;
            btnAnalytics.BackColor = AppTheme.PrimaryColor;
            btnAnalytics.ForeColor = DrawingColor.White;
            btnAnalytics.Cursor = Cursors.Hand;
            btnAnalytics.UseVisualStyleBackColor = false;

            // KPI cards
            StyleKpiCard(cardCustomers, accentCustomers, lblCapCustomers,
                lblTotalCustomers, AppTheme.PrimaryColor);
            StyleKpiCard(cardRevenue, accentRevenue, lblCapRevenue,
                lblTotalRevenue, AppTheme.SuccessColor);
            StyleKpiCard(cardUnpaid, accentUnpaid, lblCapUnpaid,
                lblTotalUnpaid, AppTheme.DangerColor);

            // Top 5 card
            pnlTop5.BackColor = AppTheme.CardColor;
            lblTop5Title.ForeColor = AppTheme.PrimaryColor;
            AppTheme.StyleGrid(dgvTop5);

            // Chart backgrounds (nagtatakip sa gilid kapag may margin)
            plotMonthlyRevenue.BackColor = AppTheme.CardColor;
            plotPaidUnpaid.BackColor = AppTheme.CardColor;
        }

        private void StyleKpiCard(Panel card, Panel accent, Label caption,
            Label value, DrawingColor accentColor)
        {
            card.BackColor = AppTheme.CardColor;
            accent.BackColor = accentColor;
            caption.ForeColor = AppTheme.MutedTextColor;
            caption.Font = new Font("Segoe UI Semibold", 8.5F);
            value.ForeColor = accentColor;
        }

        private static ScottPlot.Color Sp(DrawingColor c) => ScottPlot.Color.FromColor(c);

        private void StylePlot(ScottPlot.Plot plot)
        {
            plot.FigureBackground.Color = Sp(AppTheme.CardColor);
            plot.DataBackground.Color = Sp(AppTheme.CardColor);
            plot.Grid.MajorLineColor = Sp(AppTheme.BorderColor);
            plot.Axes.Color(Sp(AppTheme.MutedTextColor));
        }

        // ================= KPI =================

        private void LoadKpiSummary()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    using (var cmd = new MySqlCommand("SELECT COUNT(*) FROM Customers;", conn))
                    {
                        int totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
                        lblTotalCustomers.Text = totalCustomers.ToString("N0");
                    }

                    string sqlRevenue = @"SELECT IFNULL(SUM(TotalAmount), 0)
                                          FROM   Billing
                                          WHERE  Status = 'Paid';";
                    using (var cmd = new MySqlCommand(sqlRevenue, conn))
                    {
                        decimal totalRevenue = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalRevenue.Text = $"₱{totalRevenue:N2}";
                    }

                    string sqlUnpaid = @"SELECT IFNULL(SUM(TotalAmount), 0)
                                         FROM   Billing
                                         WHERE  Status = 'Unpaid';";
                    using (var cmd = new MySqlCommand(sqlUnpaid, conn))
                    {
                        decimal totalUnpaid = Convert.ToDecimal(cmd.ExecuteScalar());
                        lblTotalUnpaid.Text = $"₱{totalUnpaid:N2}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading KPI summary:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= CHARTS =================

        private void LoadMonthlyRevenueChart()
        {
            try
            {
                var months = new List<string>();
                var amounts = new List<double>();

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT BillingMonth,
                                          SUM(TotalAmount) AS MonthlyTotal
                                   FROM   Billing
                                   WHERE  Status = 'Paid'
                                   GROUP  BY BillingMonth
                                   ORDER  BY MIN(BillingDate);";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            months.Add(reader.GetString("BillingMonth"));
                            amounts.Add((double)reader.GetDecimal("MonthlyTotal"));
                        }
                    }
                }

                var plot = plotMonthlyRevenue.Plot;
                plot.Clear();
                StylePlot(plot);

                var barPlot = plot.Add.Bars(amounts.ToArray());
                foreach (var bar in barPlot.Bars)
                {
                    bar.FillColor = Sp(AppTheme.SecondaryColor);
                    bar.Label = bar.Value.ToString("N0");      // halaga sa ibabaw ng bar
                }
                barPlot.ValueLabelStyle.Bold = true;
                barPlot.ValueLabelStyle.FontSize = 11;

                double[] positions = Enumerable.Range(0, months.Count)
                                               .Select(i => (double)i).ToArray();
                string[] shortMonths = months
                    .Select(m => DateTime.Parse(m).ToString("MMM yy"))
                    .ToArray();

                plot.Axes.Bottom.SetTicks(positions, shortMonths);
                plot.Axes.Bottom.TickLabelStyle.FontSize = 11;

                // ₱ sa Y axis
                plot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.NumericAutomatic
                {
                    LabelFormatter = v => $"₱{v:N0}"
                };

                plot.Axes.Margins(bottom: 0, top: 0.15);   // may espasyo ang labels sa taas

                plot.Title("Monthly Revenue (Paid Bills)", 15);
                plot.Axes.Title.Label.ForeColor = Sp(AppTheme.PrimaryColor);

                plotMonthlyRevenue.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading monthly revenue chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaidUnpaidChart()
        {
            try
            {
                int paidCount = 0;
                int unpaidCount = 0;

                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT Status, COUNT(*) AS StatusCount
                                   FROM Billing
                                   GROUP BY Status;";

                    using (var cmd = new MySqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string status = reader.GetString("Status");
                            int count = reader.GetInt32("StatusCount");

                            if (status == "Paid") paidCount = count;
                            if (status == "Unpaid") unpaidCount = count;
                        }
                    }
                }

                var plot = plotPaidUnpaid.Plot;
                plot.Clear();
                StylePlot(plot);

                double[] values = { paidCount, unpaidCount };
                string[] labels = { "Paid", "Unpaid" };
                DrawingColor[] colors = { AppTheme.SecondaryColor, AppTheme.WarningColor };
                double total = paidCount + unpaidCount;

                var pie = plot.Add.Pie(values);

                for (int i = 0; i < pie.Slices.Count; i++)
                {
                    double pct = total > 0 ? values[i] / total : 0;
                    pie.Slices[i].FillColor = Sp(colors[i]);
                    pie.Slices[i].Label = $"{labels[i]}\n{pct:P0} ({values[i]:0} bills)";
                    pie.Slices[i].LabelFontSize = 12;
                    pie.Slices[i].LabelBold = true;
                }

                pie.SliceLabelDistance = 0.6;   // nasa loob ng slice, hindi nagbabanggaan

                plot.Axes.Frameless();
                plot.HideGrid();

                plot.Title("Paid vs Unpaid Bills", 15);
                plot.Axes.Title.Label.ForeColor = Sp(AppTheme.PrimaryColor);

                plotPaidUnpaid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Paid/Unpaid chart:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= TOP 5 =================

        private void LoadTop5Customers()
        {
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string sql = @"SELECT c.FullName,
                                          SUM(b.Consumption) AS TotalConsumption,
                                          SUM(b.TotalAmount) AS TotalBilled
                                   FROM   Customers c
                                   INNER JOIN Billing b ON c.CustomerID = b.CustomerID
                                   GROUP  BY c.CustomerID, c.FullName
                                   ORDER  BY TotalConsumption DESC
                                   LIMIT  5;";

                    using (var adapter = new MySqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvTop5.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Top 5 customers:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseAnalytics_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            frmAnalytics analyticsForm = new frmAnalytics();
            analyticsForm.ShowDialog(this);
        }
    }
}
