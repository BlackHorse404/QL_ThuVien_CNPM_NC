using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Custom.UI.Controls
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
            //this.Dock = DockStyle.Fill;

        }   
    }
}
