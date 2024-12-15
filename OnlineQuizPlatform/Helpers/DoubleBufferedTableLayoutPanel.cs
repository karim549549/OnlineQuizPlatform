using System;
using System.Drawing;
using System.Windows.Forms;

namespace OnlineQuizPlatform.Helpers
{
    internal class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        public DoubleBufferedTableLayoutPanel()
        {
            EnableDoubleBuffering();
        }


        public DoubleBufferedTableLayoutPanel(TableLayoutPanel oldTable)
        {
            EnableDoubleBuffering();

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

            this.Font = oldTable.Font;
            this.ForeColor = oldTable.ForeColor;

            this.ColumnCount = oldTable.ColumnCount;
            this.ColumnStyles.Clear();
            foreach (ColumnStyle columnStyle in oldTable.ColumnStyles)
            {
                this.ColumnStyles.Add(new ColumnStyle(columnStyle.SizeType, columnStyle.Width));
            }

            this.RowStyles.Clear();
            foreach (RowStyle rowStyle in oldTable.RowStyles)
            {
                this.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
            }

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
