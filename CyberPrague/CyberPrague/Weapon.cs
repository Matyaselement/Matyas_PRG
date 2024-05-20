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
            this.DoubleBuffered = true;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxWeapon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 33;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // pictureBoxWeapon
            // 
            this.pictureBoxWeapon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWeapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeapon.Image = global::CyberPrague.Properties.Resources.pixil_frame_0__1_;
            this.pictureBoxWeapon.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxWeapon.Name = "pictureBoxWeapon";
            this.pictureBoxWeapon.Size = new System.Drawing.Size(57, 120);
            this.pictureBoxWeapon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWeapon.TabIndex = 0;
            this.pictureBoxWeapon.TabStop = false;
            this.pictureBoxWeapon.Click += new System.EventHandler(this.pictureBoxWeapon_Click_1);
            // 
            // weapon
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBoxWeapon);
            this.DoubleBuffered = true;
            this.Name = "weapon";
            this.Size = new System.Drawing.Size(63, 123);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeapon)).EndInit();
            this.ResumeLayout(false);

        }
        private bool isFlipped = false;
        private void timerMove_Tick(object sender, EventArgs e)
        {
            if (Core.IsUp && Top > 40 - 91) //player topleft corner - 91
            {
                Top -= speed;
            }
            else if (Core.IsDown && Bottom < Parent.ClientSize.Height -181) // player top left corner - 65
            {
                Top += speed;
            }
            else if (Core.IsLeft && Left > 40)
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
            else if (Core.IsRight && Right < Parent.ClientSize.Width - 100)
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
