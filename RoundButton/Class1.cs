using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RoundedRectangleButton
{
    public class RoundedRectangleButton : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddArc(0, 0, 15, 15, 180, 90);
            grPath.AddArc(Width - 15, 0, 15, 20, 270, 90);
            grPath.AddArc(Width - 15, Height - 15, 15, 15, 0, 90);
            grPath.AddArc(0, Height - 15, 15, 15, 90, 90);
            grPath.CloseAllFigures();
            this.Region = new Region(grPath);
            base.OnPaint(e);
        }
    }
}