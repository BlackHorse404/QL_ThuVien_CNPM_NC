using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom.Properties.Forms.Forms.Layout
{
    public partial class frmLayout : Form
    {
        public Point mouseLocation;

        public frmLayout()
        {
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += FrmLayout_MouseDown; 
            this.MouseMove += FrmLayout_MouseMove; 
        }

        private void FrmLayout_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void FrmLayout_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePose = Control.MousePosition;
            mousePose.Offset(mouseLocation.X, mouseLocation.Y);
            Location = mousePose;
        }

       
    }
}
