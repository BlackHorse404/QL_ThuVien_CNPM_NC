using System.Drawing;
using System.Windows.Forms;

namespace Custom.Properties.Controls.CustomControls
{
    public class cLableTitle : Label
    {
        public cLableTitle()
        {
            this.ForeColor = Color.SteelBlue;
            this.Font = new Font("Segoe UI", 21);
            this.Font = new Font(this.Font, FontStyle.Regular);
        }
    }
}
