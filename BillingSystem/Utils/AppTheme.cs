using System.Drawing;

namespace BillingSystem.Utils
{
    /// <summary>
    /// Defines the standard color palette used across
    /// all forms in the Billing System.
    /// Change a color here to update it everywhere.
    /// </summary>
    public static class AppTheme
    {
        // Primary deep blue — form headers, main buttons
        public static Color PrimaryColor = Color.FromArgb(31, 78, 121);

        // Medium blue — sub-headers, active panels
        public static Color SecondaryColor = Color.FromArgb(46, 117, 182);

        // Light blue — DataGridView headers, light backgrounds
        public static Color AccentColor = Color.FromArgb(189, 215, 238);

        // Red — delete buttons, danger actions
        public static Color DangerColor = Color.FromArgb(192, 0, 0);

        // Dark green — save/add buttons, success actions
        public static Color SuccessColor = Color.FromArgb(55, 86, 35);

        // White — form backgrounds
        public static Color BackgroundColor = Color.White;

        // Dark grey — all regular body text
        public static Color TextColor = Color.FromArgb(64, 64, 64);

        // Light grey — alternating DataGridView rows
        public static Color GridRowAlt = Color.FromArgb(240, 245, 255);

        // Light green — active customer rows
        public static Color ActiveRowColor = Color.FromArgb(198, 224, 180);

        // Light red — inactive customer rows
        public static Color InactiveRowColor = Color.FromArgb(255, 199, 206);

        // Additional dashboard colors

        public static Color CardColor =
            Color.White;

        public static Color LightBackground =
            Color.FromArgb(245, 247, 250);

        public static Color BorderColor =
            Color.FromArgb(220, 226, 235);

        public static Color MutedTextColor =
            Color.FromArgb(120, 130, 145);

        public static Color WarningColor =
            Color.FromArgb(237, 156, 40);

        // ============ HELPER METHODS ============


        /// Darkens a color by a specified percentage for hover effects
        public static Color DarkenColor(Color color, int percent)
        {
            return Color.FromArgb(
                Math.Max(0, color.R - (color.R * percent / 100)),
                Math.Max(0, color.G - (color.G * percent / 100)),
                Math.Max(0, color.B - (color.B * percent / 100))
            );
        }


        public static void StylePrimaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = SecondaryColor;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            btn.MouseEnter += (s, e) => btn.BackColor = DarkenColor(SecondaryColor, 15);
            btn.MouseLeave += (s, e) => btn.BackColor = SecondaryColor;
        }

        public static void StyleSecondaryButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = BorderColor;
            btn.BackColor = CardColor;
            btn.ForeColor = TextColor;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;
            btn.MouseEnter += (s, e) => btn.BackColor = LightBackground;
            btn.MouseLeave += (s, e) => btn.BackColor = CardColor;
        }

        public static void StyleGrid(DataGridView g)
        {
            g.BorderStyle = BorderStyle.None;
            g.BackgroundColor = CardColor;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersDefaultCellStyle.BackColor = AccentColor;       // light blue headers
            g.ColumnHeadersDefaultCellStyle.ForeColor = PrimaryColor;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5F);
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = AccentColor;
            g.ColumnHeadersDefaultCellStyle.SelectionForeColor = PrimaryColor;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 38;
            g.RowHeadersVisible = false;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = BorderColor;
            g.RowTemplate.Height = 32;
            g.DefaultCellStyle.ForeColor = TextColor;
            g.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
            g.DefaultCellStyle.SelectionBackColor = AccentColor;
            g.DefaultCellStyle.SelectionForeColor = PrimaryColor;
            g.AlternatingRowsDefaultCellStyle.BackColor = GridRowAlt;
            g.ReadOnly = true;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.MultiSelect = false;
        }

        public static void StyleSolidButton(Button btn, Color color)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = DarkenColor(color, 15);
            btn.FlatAppearance.MouseDownBackColor = DarkenColor(color, 25);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.Cursor = Cursors.Hand;
            btn.UseVisualStyleBackColor = false;

        
            btn.EnabledChanged += (s, e) =>
                btn.BackColor = btn.Enabled ? color : Color.FromArgb(225, 229, 235);
        }
    }
}


