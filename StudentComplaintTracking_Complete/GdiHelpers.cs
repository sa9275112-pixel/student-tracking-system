using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace StudentComplaintTracking.Gdi
{
    /// <summary>
    /// Shared GDI+ drawing code used by every screen:
    /// colors, rounded shapes, gradients, shadows, status badges, charts,
    /// the complaint status tracker, icons and printing.
    /// Everything here draws with System.Drawing (Graphics, Pen, Brush, GraphicsPath).
    /// </summary>
    public static class GdiHelpers
    {
        // ───────────────────────── Colors ─────────────────────────

        public static readonly Color Navy = Color.FromArgb(14, 18, 62);
        public static readonly Color Blue = Color.FromArgb(42, 66, 180);

        /// <summary>Palette used by the charts.</summary>
        public static readonly Color[] ChartPalette =
        {
            Color.FromArgb(42, 66, 180),   // blue
            Color.FromArgb(0, 150, 136),   // teal
            Color.FromArgb(255, 152, 0),   // orange
            Color.FromArgb(76, 175, 80),   // green
            Color.FromArgb(156, 39, 176),  // purple
            Color.FromArgb(244, 67, 54),   // red
            Color.FromArgb(96, 125, 139),  // grey
        };

        /// <summary>One color per complaint status, used everywhere a status is shown.</summary>
        public static Color StatusColor(string? status)
        {
            switch ((status ?? "").Trim().ToLowerInvariant())
            {
                case "new": return Color.FromArgb(59, 130, 246);           // blue
                case "pending":
                case "pending...": return Color.FromArgb(217, 119, 6);     // amber
                case "under review": return Color.FromArgb(139, 92, 246);  // violet
                case "in progress": return Color.FromArgb(234, 88, 12);    // orange
                case "resolved": return Color.FromArgb(22, 163, 74);       // green
                case "closed": return Color.FromArgb(71, 85, 105);         // slate
                case "rejected": return Color.FromArgb(220, 38, 38);       // red
                default: return Color.FromArgb(107, 114, 128);             // grey
            }
        }

        /// <summary>One color per priority level.</summary>
        public static Color PriorityColor(string? priority)
        {
            switch ((priority ?? "").Trim().ToLowerInvariant())
            {
                case "low": return Color.FromArgb(22, 163, 74);      // green
                case "medium": return Color.FromArgb(217, 119, 6);   // amber
                case "high": return Color.FromArgb(234, 88, 12);     // orange
                case "urgent": return Color.FromArgb(220, 38, 38);   // red
                default: return Color.FromArgb(107, 114, 128);
            }
        }

        /// <summary>Mixes a color with white (amount 0..1 of the original color).</summary>
        public static Color Tint(Color c, float amount)
        {
            int Mix(int v) => (int)(255 - (255 - v) * amount);
            return Color.FromArgb(Mix(c.R), Mix(c.G), Mix(c.B));
        }

        // ───────────────────────── Setup helpers ─────────────────────────

        /// <summary>
        /// Turns on double buffering (draw off-screen first, then copy) so custom-drawn
        /// controls don't flicker when resized. DoubleBuffered is protected, so we set it via reflection.
        /// </summary>
        public static void EnableDoubleBuffering(Control control)
        {
            typeof(Control)
                .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)?
                .SetValue(control, true, null);
        }

        /// <summary>Repaints the control whenever it is resized.</summary>
        public static void RedrawOnResize(Control control)
        {
            control.Resize += (s, e) => control.Invalidate();
        }

        /// <summary>Common quality settings for smooth shapes and text.</summary>
        public static void HighQuality(Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
        }

        // ───────────────────────── Shapes ─────────────────────────

        /// <summary>Builds a rectangle with rounded corners as a GraphicsPath.</summary>
        public static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            var path = new GraphicsPath();
            int d = Math.Max(1, Math.Min(radius * 2, Math.Min(r.Width, r.Height)));
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static void FillRounded(Graphics g, Rectangle r, int radius, Color color)
        {
            using var path = RoundedRect(r, radius);
            using var brush = new SolidBrush(color);
            g.FillPath(brush, path);
        }

        public static void DrawRounded(Graphics g, Rectangle r, int radius, Color color, float width)
        {
            using var path = RoundedRect(r, radius);
            using var pen = new Pen(color, width);
            g.DrawPath(pen, path);
        }

        /// <summary>Fills an area with the app's navy-to-blue diagonal gradient.</summary>
        public static void FillGradient(Graphics g, Rectangle r, LinearGradientMode mode = LinearGradientMode.ForwardDiagonal)
        {
            if (r.Width <= 0 || r.Height <= 0) return;
            using var brush = new LinearGradientBrush(r, Navy, Blue, mode);
            g.FillRectangle(brush, r);
        }

        /// <summary>
        /// Paints a soft drop shadow around a control, on its parent's surface.
        /// Several transparent layers, each a bit bigger, fake a blur.
        /// </summary>
        public static void DrawShadow(Graphics g, Rectangle bounds, int layers = 6, int offsetY = 3)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;
            for (int i = layers; i >= 1; i--)
            {
                var r = bounds;
                r.Inflate(i, i);
                r.Offset(0, offsetY);
                using var path = RoundedRect(r, 6 + i);
                using var brush = new SolidBrush(Color.FromArgb(10, 0, 0, 0));
                g.FillPath(brush, path);
            }
        }

        // ───────────────────────── Sidebar ─────────────────────────

        /// <summary>Paints a sidebar panel with the gradient and keeps it updated on resize.</summary>
        public static void AttachSidebarGradient(Panel sidebar)
        {
            EnableDoubleBuffering(sidebar);
            sidebar.Paint += (s, e) => FillGradient(e.Graphics, sidebar.ClientRectangle);
            RedrawOnResize(sidebar);
        }

        // ───────────────────────── Badges in tables ─────────────────────────

        /// <summary>Draws a rounded "pill" badge: light tinted background, colored dot and text.</summary>
        public static void DrawBadge(Graphics g, Rectangle cell, string text, Color color, Font font)
        {
            HighQuality(g);
            SizeF textSize = g.MeasureString(text, font);

            // Narrow column: compact style (dot + colored text, no pill) so the text still fits
            if (textSize.Width + 26 > cell.Width - 4)
            {
                DrawCompactBadge(g, cell, text, color, font);
                return;
            }

            int height = Math.Min(cell.Height - 6, (int)textSize.Height + 4);
            int width = Math.Min(cell.Width - 8, (int)textSize.Width + 24);
            if (width <= 0 || height <= 0) return;

            var pill = new Rectangle(cell.X + 6, cell.Y + (cell.Height - height) / 2, width, height);
            FillRounded(g, pill, height / 2, Tint(color, 0.18f));

            int dot = Math.Max(4, height / 3);
            using (var dotBrush = new SolidBrush(color))
                g.FillEllipse(dotBrush, pill.X + 7, pill.Y + (pill.Height - dot) / 2, dot, dot);

            var textRect = new RectangleF(pill.X + 10 + dot, pill.Y, pill.Width - 10 - dot, pill.Height);
            using var format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.NoWrap,
            };
            using var textBrush = new SolidBrush(color);
            g.DrawString(text, font, textBrush, textRect, format);
        }

        /// <summary>Small colored dot followed by the text in the same color (for narrow cells).</summary>
        private static void DrawCompactBadge(Graphics g, Rectangle cell, string text, Color color, Font font)
        {
            const int dot = 6;
            using (var dotBrush = new SolidBrush(color))
                g.FillEllipse(dotBrush, cell.X + 4, cell.Y + (cell.Height - dot) / 2, dot, dot);

            using var regular = new Font(font, FontStyle.Regular);
            using var format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.NoWrap,
            };
            using var textBrush = new SolidBrush(color);
            g.DrawString(text, regular, textBrush,
                new RectangleF(cell.X + dot + 7, cell.Y, Math.Max(0, cell.Width - dot - 9), cell.Height), format);
        }

        /// <summary>
        /// Makes a DataGridView column show colored badges instead of plain text,
        /// using the CellPainting event. The cell value itself is not changed.
        /// </summary>
        public static void AttachBadges(DataGridView grid, string columnName, Func<string?, Color> colorFor)
        {
            EnableDoubleBuffering(grid);
            grid.CellPainting += (s, e) =>
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
                if (grid.Columns[e.ColumnIndex].Name != columnName) return;
                if (e.Graphics == null) return;

                string text = e.Value?.ToString() ?? "";
                if (text.Length == 0) return;

                // Let the grid paint the normal background/selection and borders first
                e.PaintBackground(e.ClipBounds, (e.State & DataGridViewElementStates.Selected) != 0);
                var font = e.CellStyle?.Font ?? grid.Font;
                using var badgeFont = new Font(font, FontStyle.Bold);
                DrawBadge(e.Graphics, e.CellBounds, text, colorFor(text), badgeFont);
                e.Handled = true;
            };
        }

        // ───────────────────────── Charts ─────────────────────────

        /// <summary>Donut chart with a legend on the right and the total in the middle.</summary>
        public static void DrawDonutChart(Graphics g, Rectangle area, IList<KeyValuePair<string, int>> data,
                                          Func<string, int, Color> colorFor, Font font)
        {
            HighQuality(g);
            int total = data.Sum(d => d.Value);
            if (total == 0)
            {
                g.DrawString("No complaints yet", font, Brushes.Gray, area.X + 10, area.Y + 10);
                return;
            }

            int size = Math.Min(area.Height - 20, area.Width / 2 - 20);
            if (size <= 0) return;
            var pie = new Rectangle(area.X + 15, area.Y + (area.Height - size) / 2, size, size);

            float startAngle = -90f; // start at 12 o'clock
            for (int i = 0; i < data.Count; i++)
            {
                float sweep = 360f * data[i].Value / total;
                using var brush = new SolidBrush(colorFor(data[i].Key, i));
                g.FillPie(brush, pie, startAngle, sweep);
                startAngle += sweep;

                // Legend row: colored square + "Label (count)"
                int legendY = area.Y + 15 + i * 22;
                g.FillRectangle(brush, pie.Right + 25, legendY, 12, 12);
                g.DrawString(data[i].Key + " (" + data[i].Value + ")", font, Brushes.Black, pie.Right + 43, legendY - 3);
            }

            // White separators between slices
            using (var sep = new Pen(Color.White, 2f))
            {
                float a = -90f;
                foreach (var d in data)
                {
                    a += 360f * d.Value / total;
                    double rad = a * Math.PI / 180.0;
                    var c = new PointF(pie.X + size / 2f, pie.Y + size / 2f);
                    g.DrawLine(sep, c, new PointF(c.X + (float)Math.Cos(rad) * size / 2f, c.Y + (float)Math.Sin(rad) * size / 2f));
                }
            }

            // Cut a white circle out of the middle to make it a donut
            int hole = size / 2;
            g.FillEllipse(Brushes.White, pie.X + (size - hole) / 2, pie.Y + (size - hole) / 2, hole, hole);

            using var totalFont = new Font(font.FontFamily, 14F, FontStyle.Bold);
            using var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            g.DrawString(total.ToString(), totalFont, Brushes.Black, pie, center);
        }

        /// <summary>Horizontal bar chart, biggest value first, with labels and values.</summary>
        public static void DrawBarChart(Graphics g, Rectangle area, IList<KeyValuePair<string, int>> data, Font font)
        {
            HighQuality(g);
            if (data.Count == 0)
            {
                g.DrawString("No complaints yet", font, Brushes.Gray, area.X + 10, area.Y + 10);
                return;
            }

            var sorted = data.OrderByDescending(d => d.Value).ToList();
            int max = sorted[0].Value;
            const int labelWidth = 110, rightPad = 35, topPad = 10;
            int rowHeight = (area.Height - topPad * 2) / sorted.Count;
            int maxBarWidth = area.Width - labelWidth - rightPad;
            if (rowHeight <= 0 || maxBarWidth <= 0 || max <= 0) return;

            using var labelFormat = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
            using var countFormat = new StringFormat { LineAlignment = StringAlignment.Center };
            using var gridPen = new Pen(Color.FromArgb(230, 230, 235)) { DashStyle = DashStyle.Dash };

            // Light vertical guide lines at 25 / 50 / 75 / 100 %
            for (int q = 1; q <= 4; q++)
            {
                int x = area.X + labelWidth + maxBarWidth * q / 4;
                g.DrawLine(gridPen, x, area.Y + topPad, x, area.Y + topPad + rowHeight * sorted.Count);
            }

            for (int i = 0; i < sorted.Count; i++)
            {
                int y = area.Y + topPad + i * rowHeight;
                int barWidth = Math.Max(4, (int)(maxBarWidth * (sorted[i].Value / (float)max)));
                var bar = new Rectangle(area.X + labelWidth, y + rowHeight / 4, barWidth, Math.Max(4, rowHeight / 2));

                var color = ChartPalette[i % ChartPalette.Length];
                using (var brush = new LinearGradientBrush(bar, Tint(color, 0.75f), color, LinearGradientMode.Horizontal))
                    FillRoundedWith(g, bar, Math.Min(4, bar.Height / 2), brush);

                g.DrawString(sorted[i].Key, font, Brushes.DimGray, new RectangleF(area.X, y, labelWidth - 8, rowHeight), labelFormat);
                g.DrawString(sorted[i].Value.ToString(), font, Brushes.Black, new RectangleF(bar.Right + 5, y, rightPad, rowHeight), countFormat);
            }
        }

        private static void FillRoundedWith(Graphics g, Rectangle r, int radius, Brush brush)
        {
            using var path = RoundedRect(r, radius);
            g.FillPath(brush, path);
        }

        /// <summary>Circular progress ring (DrawArc) with the percentage in the middle.</summary>
        public static void DrawProgressRing(Graphics g, Rectangle r, float fraction, Color color, string caption, Font captionFont)
        {
            HighQuality(g);
            fraction = Math.Max(0f, Math.Min(1f, fraction));
            int thickness = Math.Max(6, r.Width / 9);
            var ring = Rectangle.Inflate(r, -thickness / 2, -thickness / 2);

            using (var track = new Pen(Color.FromArgb(220, 224, 232), thickness))
                g.DrawEllipse(track, ring);

            if (fraction > 0)
            {
                using var arc = new Pen(color, thickness) { StartCap = LineCap.Round, EndCap = LineCap.Round };
                g.DrawArc(arc, ring, -90f, 360f * fraction);
            }

            using var pctFont = new Font("Segoe UI", Math.Max(9f, r.Height / 6f), FontStyle.Bold);
            using var center = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            using var textBrush = new SolidBrush(Color.FromArgb(35, 45, 90));
            g.DrawString((int)Math.Round(fraction * 100) + "%", pctFont, textBrush, r, center);

            var captionRect = new Rectangle(r.X - 30, r.Bottom + 4, r.Width + 60, 20);
            using var top = new StringFormat { Alignment = StringAlignment.Center };
            g.DrawString(caption, captionFont, Brushes.DimGray, captionRect, top);
        }

        // ───────────────────────── Status tracker ─────────────────────────

        /// <summary>
        /// Draws the follow-up steps of a complaint (e.g. Submitted → Pending → In Progress → Resolved)
        /// as circles joined by lines. Finished steps get a check mark, the current step is highlighted.
        /// </summary>
        public static void DrawStatusTracker(Graphics g, Rectangle area, string[] steps, int currentIndex, Font font)
        {
            HighQuality(g);
            if (steps.Length < 2 || area.Width <= 0) return;

            const int radius = 11;
            int cy = area.Y + radius + 4;
            float gap = (area.Width - 2f * radius) / (steps.Length - 1);
            var done = StatusColor("resolved");
            var current = StatusColor(steps[Math.Max(0, Math.Min(currentIndex, steps.Length - 1))]);
            var future = Color.FromArgb(203, 213, 225);
            bool allDone = currentIndex >= steps.Length - 1;

            // Connecting lines first, so the circles are drawn on top
            for (int i = 0; i < steps.Length - 1; i++)
            {
                float x1 = area.X + radius + i * gap, x2 = area.X + radius + (i + 1) * gap;
                using var pen = new Pen(i < currentIndex ? done : future, 3f);
                if (i >= currentIndex) pen.DashStyle = DashStyle.Dot;
                g.DrawLine(pen, x1 + radius, cy, x2 - radius, cy);
            }

            using var labelFormat = new StringFormat { Alignment = StringAlignment.Center };
            for (int i = 0; i < steps.Length; i++)
            {
                float cx = area.X + radius + i * gap;
                var circle = new RectangleF(cx - radius, cy - radius, radius * 2, radius * 2);

                if (i < currentIndex || (allDone && i == currentIndex))
                {
                    using var b = new SolidBrush(done);
                    g.FillEllipse(b, circle);
                    DrawCheck(g, circle, Color.White, 2.2f);
                }
                else if (i == currentIndex)
                {
                    using (var halo = new SolidBrush(Tint(current, 0.25f)))
                        g.FillEllipse(halo, RectangleF.Inflate(circle, 4, 4));
                    using var b = new SolidBrush(current);
                    g.FillEllipse(b, circle);
                    g.FillEllipse(Brushes.White, RectangleF.Inflate(circle, -radius + 4, -radius + 4));
                }
                else
                {
                    g.FillEllipse(Brushes.White, circle);
                    using var p = new Pen(future, 2f);
                    g.DrawEllipse(p, circle);
                }

                bool isCurrent = i == currentIndex;
                using var labelFont = new Font(font, isCurrent ? FontStyle.Bold : FontStyle.Regular);
                using var labelBrush = new SolidBrush(isCurrent ? current : (i < currentIndex ? Color.FromArgb(55, 65, 81) : Color.Gray));
                g.DrawString(steps[i], labelFont, labelBrush, new RectangleF(cx - gap / 2, cy + radius + 6, gap, 20), labelFormat);
            }
        }

        // ───────────────────────── Icons ─────────────────────────

        /// <summary>A check mark made of two lines.</summary>
        public static void DrawCheck(Graphics g, RectangleF r, Color color, float width)
        {
            using var pen = new Pen(color, width) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round };
            g.DrawLines(pen, new[]
            {
                new PointF(r.X + r.Width * 0.28f, r.Y + r.Height * 0.52f),
                new PointF(r.X + r.Width * 0.45f, r.Y + r.Height * 0.68f),
                new PointF(r.X + r.Width * 0.73f, r.Y + r.Height * 0.36f),
            });
        }

        /// <summary>Circle with a check inside (Resolved icon).</summary>
        public static void DrawCheckCircleIcon(Graphics g, Rectangle r, Color color)
        {
            HighQuality(g);
            using var pen = new Pen(color, 2f);
            g.DrawEllipse(pen, r);
            DrawCheck(g, r, color, 2f);
        }

        /// <summary>Clock face with two hands (Pending icon).</summary>
        public static void DrawClockIcon(Graphics g, Rectangle r, Color color)
        {
            HighQuality(g);
            using var pen = new Pen(color, 2f) { StartCap = LineCap.Round, EndCap = LineCap.Round };
            g.DrawEllipse(pen, r);
            var c = new PointF(r.X + r.Width / 2f, r.Y + r.Height / 2f);
            g.DrawLine(pen, c, new PointF(c.X, r.Y + r.Height * 0.25f));
            g.DrawLine(pen, c, new PointF(r.X + r.Width * 0.72f, c.Y));
        }

        /// <summary>Two overlapping rounded squares (Total icon).</summary>
        public static void DrawStackIcon(Graphics g, Rectangle r, Color color)
        {
            HighQuality(g);
            int s = (int)(r.Width * 0.68);
            var back = new Rectangle(r.Right - s, r.Y, s, s);
            var front = new Rectangle(r.X, r.Bottom - s, s, s);
            DrawRounded(g, back, 3, color, 2f);
            FillRounded(g, front, 3, Color.White);
            DrawRounded(g, front, 3, color, 2f);
        }

        // ───────────────────────── Printing ─────────────────────────

        /// <summary>
        /// Opens a print preview of a report: title, date, an optional drawing (e.g. charts)
        /// and the rows of a table, with status/priority badges. The same GDI+ Graphics
        /// calls used on screen draw on the printed page. Long tables continue on the next page.
        /// </summary>
        public static void ShowPrintPreview(IWin32Window owner, string title, DataGridView grid,
                                            Action<Graphics, Rectangle>? drawHeaderGraphic = null, int headerGraphicHeight = 0)
        {
            var columns = grid.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
            var rows = grid.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
            int nextRow = 0;
            bool firstPage = true;

            using var doc = new PrintDocument { DocumentName = title };
            doc.DefaultPageSettings.Landscape = true;
            doc.BeginPrint += (s, e) => { nextRow = 0; firstPage = true; };
            doc.PrintPage += (s, e) =>
            {
                var g = e.Graphics;
                if (g == null) return;
                HighQuality(g);
                var m = e.MarginBounds;
                int y = m.Top;

                using var titleFont = new Font("Segoe UI", 16F, FontStyle.Bold);
                using var smallFont = new Font("Segoe UI", 9F);
                using var headFont = new Font("Segoe UI", 9F, FontStyle.Bold);
                using var titleBrush = new SolidBrush(Navy);

                // Header band with the app gradient
                FillGradient(g, new Rectangle(m.Left, y, m.Width, 6), LinearGradientMode.Horizontal);
                y += 14;
                g.DrawString(title, titleFont, titleBrush, m.Left, y);
                g.DrawString("Printed " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), smallFont, Brushes.Gray,
                             m.Right - 170, y + 8);
                y += 40;

                if (firstPage && drawHeaderGraphic != null && headerGraphicHeight > 0)
                {
                    drawHeaderGraphic(g, new Rectangle(m.Left, y, m.Width, headerGraphicHeight));
                    y += headerGraphicHeight + 15;
                }
                firstPage = false;

                // Column widths proportional to the on-screen widths
                float totalWidth = columns.Sum(c => (float)c.Width);
                var widths = columns.Select(c => m.Width * c.Width / totalWidth).ToArray();
                const int rowHeight = 26;

                // Header row
                using (var headBrush = new SolidBrush(Tint(Blue, 0.15f)))
                    g.FillRectangle(headBrush, m.Left, y, m.Width, rowHeight);
                float x = m.Left;
                for (int c = 0; c < columns.Count; c++)
                {
                    g.DrawString(columns[c].HeaderText, headFont, titleBrush,
                                 new RectangleF(x + 4, y + 5, widths[c] - 6, rowHeight), StringFormat.GenericTypographic);
                    x += widths[c];
                }
                y += rowHeight;

                using var linePen = new Pen(Color.FromArgb(225, 228, 235));
                while (nextRow < rows.Count && y + rowHeight <= m.Bottom)
                {
                    x = m.Left;
                    for (int c = 0; c < columns.Count; c++)
                    {
                        string text = rows[nextRow].Cells[columns[c].Index].Value?.ToString() ?? "";
                        string header = columns[c].HeaderText.ToLowerInvariant();
                        var cell = Rectangle.Round(new RectangleF(x, y, widths[c], rowHeight));
                        if (header == "status" && text.Length > 0)
                            DrawBadge(g, cell, text, StatusColor(text), headFont);
                        else if (header == "priority" && text.Length > 0)
                            DrawBadge(g, cell, text, PriorityColor(text), headFont);
                        else
                            g.DrawString(text, smallFont, Brushes.Black,
                                         new RectangleF(x + 4, y + 6, widths[c] - 6, rowHeight - 6), StringFormat.GenericTypographic);
                        x += widths[c];
                    }
                    g.DrawLine(linePen, m.Left, y + rowHeight, m.Right, y + rowHeight);
                    y += rowHeight;
                    nextRow++;
                }

                e.HasMorePages = nextRow < rows.Count;
            };

            using var preview = new PrintPreviewDialog
            {
                Document = doc,
                Width = 1100,
                Height = 800,
                Text = "Print Preview - " + title,
            };
            preview.ShowDialog(owner);
        }
    }
}
