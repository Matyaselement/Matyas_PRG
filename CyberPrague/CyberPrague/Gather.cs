using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPrague
{
    public class Gather : UserControl
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Gather
            // 
            this.Name = "Gather";
            this.Load += new System.EventHandler(this.Gather_Load);
            this.ResumeLayout(false);

        }

        private void Gather_Load(object sender, EventArgs e)
        {

        }
    }
}
