


using System.Drawing.Drawing2D;

namespace StudentComplaintTracking.Forms
{
    /// <summary>
    /// Shared look for the sidebar used by the admin screens.
    /// </summary>
    internal static class SidebarStyle
    {
        private static readonly Color Top = Color.FromArgb(14, 18, 62);
        private static readonly Color Bottom = Color.FromArgb(42, 66, 180);

        /// <summary>Paints a navy-to-blue gradient over the whole panel.</summary>
        public static void PaintGradient(Panel panel, PaintEventArgs e)
        {
            var rect = panel.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using var brush = new LinearGradientBrush(rect, Top, Bottom, LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(brush, rect);
        }
    }
}
