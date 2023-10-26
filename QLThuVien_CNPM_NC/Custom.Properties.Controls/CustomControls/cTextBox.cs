using Bunifu.Framework.UI;
using System.Drawing;

namespace Custom.Properties.Controls.CustomControls
{
    public class cTextBox : BunifuMetroTextbox
    {
        public cTextBox()
        {
            this.BackColor = Color.White;
            this.BorderColorFocused = Color.SteelBlue;
            this.BorderColorIdle = Color.SteelBlue;
            this.BorderColorMouseHover = Color.SteelBlue;
            this.Font = new Font("Century Gothic", 10);
            this.BorderThickness = 1;
            this.TabIndex = 0;
            this.Size = new Size(203, 29);

        }
    }
}
