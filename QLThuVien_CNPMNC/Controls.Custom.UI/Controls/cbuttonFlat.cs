using Bunifu.Framework.UI;
using System.Drawing;

namespace Controls.Custom.UI.Controls
{
    public class cbuttonFlat : BunifuFlatButton
    {
        public cbuttonFlat() 
        {
            this.Normalcolor = Color.SteelBlue;
            this.OnHovercolor = Color.DeepSkyBlue;
            this.Activecolor = Color.SteelBlue;
            this.BackColor = Color.SteelBlue;
            this.TextFont = new Font("Segoe UI", 10);
            this.Textcolor = Color.White;
            //this.TabIndex = 5;
        }
    }
}
