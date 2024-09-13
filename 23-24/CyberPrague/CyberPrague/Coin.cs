using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPrague
{
    public class Coin : UserControl
    {
        private PictureBox pictureBox2;

        public Coin(int x, int y)
        {
            Location = new System.Drawing.Point(x,y);
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CyberPrague.Properties.Resources.coin_euro_115099;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 34);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Coin
            // 
            this.Controls.Add(this.pictureBox2);
            this.Name = "Coin";
            this.Size = new System.Drawing.Size(38, 40);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
