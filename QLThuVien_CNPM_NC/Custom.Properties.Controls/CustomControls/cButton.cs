using Bunifu.Framework.UI;
using System.Drawing;
using System.Windows.Forms;

namespace Custom.Properties.Controls.CustomControls
{
    public class cButton : BunifuThinButton2
    {
        public cButton()
        {
            this.ForeColor = Color.SteelBlue;
            this.Font = new Font("Segoe UI", 12);
            this.Margin = new Padding(4, 5, 4, 5);
            this.TabIndex = 22;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.IdleBorderThickness = 1;
            this.IdleCornerRadius = 20;
            this.ActiveFillColor = Color.SteelBlue;
            this.ActiveLineColor = Color.SteelBlue;
            this.IdleForecolor = Color.SteelBlue;
            this.IdleLineColor = Color.SteelBlue;
        }
    }
}
