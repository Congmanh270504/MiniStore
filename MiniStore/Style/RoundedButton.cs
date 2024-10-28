using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace MiniStore.Style
{
    public class RoundedButton : Button
    {
        private int borderRadius = 20;

        public int BorderRadius { get => borderRadius; set => borderRadius = value; }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, BorderRadius, BorderRadius, 180, 90);
            graphicsPath.AddArc(Width - BorderRadius, 0, BorderRadius, BorderRadius, 270, 90);
            graphicsPath.AddArc(Width - BorderRadius, Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
            graphicsPath.AddArc(0, Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);
            graphicsPath.CloseAllFigures();

            this.Region = new Region(graphicsPath);

            using (Pen pen = new Pen(this.ForeColor, 1))
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                pevent.Graphics.DrawPath(pen, graphicsPath);
            }
        }
    }
}
