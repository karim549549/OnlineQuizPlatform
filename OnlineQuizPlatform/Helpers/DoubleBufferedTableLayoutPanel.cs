using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineQuizPlatform.Helpers
{
    internal class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        // Default constructor
        public DoubleBufferedTableLayoutPanel()
        {
            EnableDoubleBuffering();
        }

        // Constructor to copy properties from an existing TableLayoutPanel
        public DoubleBufferedTableLayoutPanel(TableLayoutPanel oldTable)
        {
            EnableDoubleBuffering();

            // Copy layout properties
            this.Dock = oldTable.Dock;
            this.Location = oldTable.Location;
            this.Size = oldTable.Size;
            this.BackColor = oldTable.BackColor;
            this.Padding = oldTable.Padding;
            this.Margin = oldTable.Margin;
            this.Anchor = oldTable.Anchor;
            this.CellBorderStyle = oldTable.CellBorderStyle;
            this.AutoSize = oldTable.AutoSize;
            this.GrowStyle = oldTable.GrowStyle;
            this.Visible = oldTable.Visible;

            // Copy fonts, foreground and background styles
            this.Font = oldTable.Font;
            this.ForeColor = oldTable.ForeColor;

            // Copy column and row styles
            this.ColumnCount = oldTable.ColumnCount;
            this.ColumnStyles.Clear();
            foreach (ColumnStyle columnStyle in oldTable.ColumnStyles)
            {
                this.ColumnStyles.Add(new ColumnStyle(columnStyle.SizeType, columnStyle.Width));
            }

            this.RowCount = oldTable.RowCount;
            this.RowStyles.Clear();
            foreach (RowStyle rowStyle in oldTable.RowStyles)
            {
                this.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
            }

            // Copy controls and their positions
            foreach (Control control in oldTable.Controls)
            {
                var position = oldTable.GetPositionFromControl(control);
                this.Controls.Add(control, position.Column, position.Row);

              
                control.Dock = control.Dock; 
                control.Padding = control.Padding;
                control.Margin = control.Margin;
                control.Anchor = control.Anchor;
                control.BackColor = control.BackColor;
                control.ForeColor = control.ForeColor;
                control.Font = control.Font;
            }
        }

        private void EnableDoubleBuffering()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
    }
}
