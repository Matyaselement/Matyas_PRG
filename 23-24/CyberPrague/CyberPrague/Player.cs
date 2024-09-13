using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPrague
{
    public class player : Gather
    {
        private Timer timerMove;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;
        private int speed = 6;
        
        public player()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CyberPrague.Properties.Resources.among_us_crewmate_icon_159244;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerMove
            // 
            this.timerMove.Enabled = true;
            this.timerMove.Interval = 33;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // player
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "player";
            this.Size = new System.Drawing.Size(77, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private bool isFlipped = false;
        private void timerMove_Tick(object sender, EventArgs e)
        {

            if (Core.IsUp && Top > 40)
            {
                Top -= speed;
            }
            else if (Core.IsDown && Bottom < Parent.ClientSize.Height - 40)
            {
                Top += speed;
            }
            else if (Core.IsLeft && Left > 40)
            {
                if (!isFlipped)
                {
                    Bitmap bm = new Bitmap(pictureBox1.Image);
                    bm.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBox1.Image = bm;
                    isFlipped = true;
                }
                Left -= speed;
            }
            else if (Core.IsRight && Right < Parent.ClientSize.Width - 40)
            {
                if (isFlipped)
                {
                    Bitmap bm = new Bitmap(pictureBox1.Image);
                    bm.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBox1.Image = bm;
                    isFlipped = false;
                }
                Left += speed;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
