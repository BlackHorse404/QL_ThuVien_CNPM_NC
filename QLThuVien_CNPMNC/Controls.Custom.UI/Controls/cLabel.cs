﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls.Custom.UI.Controls
{
    public class cLabel : Label
    {
        public cLabel() 
        {
            this.ForeColor = Color.SteelBlue;
            this.Font = new Font("Segoe UI", 12);
        }
    }
}
