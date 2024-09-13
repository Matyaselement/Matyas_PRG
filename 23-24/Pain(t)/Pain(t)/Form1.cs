using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pain_t_
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height); //nastavení velikosti aplikace (formu)
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }

        //deklarování proměnných
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int index;

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;

                }
                pic.Refresh();
            }
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }
    }
}   
