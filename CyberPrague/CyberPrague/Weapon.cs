using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPrague
{
    public class weapon : UserControl
    {
        private Timer timerMove;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBoxWeapon;
        private int speed = 6;
        public weapon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxWeapon = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWeapon
            // 
            this.pictureBoxWeapon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWeapon.Image = global::CyberPrague.Properties.Resources.Sword_Pixel_art___Radin___kopie;
            this.pictureBoxWeapon.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxWeapon.Name = "pictureBoxWeapon";
            this.pictureBoxWeapon.Size = new System.Drawing.Size(80, 87);
            this.pictureBoxWeapon.TabIndex = 0;
            this.pictureBoxWeapon.TabStop = false;
            this.pictureBoxWeapon.Click += new System.EventHandler(this.pictureBoxWeapon_Click_1);
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 34;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // weapon
            // 
            this.Controls.Add(this.pictureBoxWeapon);
            this.Name = "weapon";
            this.Size = new System.Drawing.Size(57, 58);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).EndInit();
            this.ResumeLayout(false);

        }
        private bool isFlipped = false;
        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (Core.IsUp)
            {
                Top -= speed;
            }
            else if (Core.IsDown)
            {
                Top += speed;
            }
            else if (Core.IsLeft)
            {
                if (!isFlipped)
                {
                    Bitmap bm = new Bitmap(pictureBoxWeapon.Image);
                    bm.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBoxWeapon.Image = bm;
                    isFlipped = true;
                }
                Left -= speed;
            }
            else if (Core.IsRight)
            {
                if (isFlipped)
                {
                    Bitmap bm = new Bitmap(pictureBoxWeapon.Image);
                    bm.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBoxWeapon.Image = bm;
                    isFlipped = false;
                }
                Left += speed;
            }
        }
        private void pictureBoxWeapon_Click_1(object sender, EventArgs e)
        {

        }
    }
}
