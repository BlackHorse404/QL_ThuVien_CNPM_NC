
using System.Drawing;
using System.Windows.Forms;

namespace Controls.Custom.UI.Controls
{
    public class cLabelTitle : Label
    {
        public cLabelTitle() 
        {
            this.ForeColor = Color.SteelBlue;
            this.Font = new Font("Segoe UI", 21);
            this.Font = new Font(this.Font, FontStyle.Regular);
        }
    }
}
