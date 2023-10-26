﻿using System.Drawing;
using System.Windows.Forms;

namespace Custom.Properties.Controls.CustomControls
{
    public class cGroupBox : GroupBox
    {
        public cGroupBox()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.SteelBlue;
            this.Font = new Font("Segoe UI", 12);
            this.Margin = new Padding(3, 3, 3, 3);

        }
    }
}
