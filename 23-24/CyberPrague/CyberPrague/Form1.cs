using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberPrague
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            coinCount = 0;
            UpdateCoinCountLabel();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = true;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = true;
            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = true;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = false;
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = false;
            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = false;
            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;
        }



        private void timerCoin_Tick(object sender, EventArgs e)
        {
            Random r = new Random();

            int x = r.Next(40, ClientSize.Width - 78);
            int y = r.Next(40, ClientSize.Height - 80);

            Coin c = new Coin(x, y);
            Controls.Add(c);

            CoinsList.Add(c);
        }
        private void updateCoinPick_Tick_1(object sender, EventArgs e)
        {
            try
            {


                foreach (Coin coin in CoinsList)
                {
                    foreach (Gather g in Controls.OfType<Gather>())
                    {
                        if (g.Bounds.IntersectsWith(coin.Bounds))
                        {
                            CoinsList.Remove(coin);
                            Controls.Remove(coin);
                            AddCoin();
                        }
                    }
                }
            }
            catch { }
        }

        void AddCoin()
        {
            coinCount++;
            LabelCoinsGathered.Text = $"{coinCount+" coins"}";

        }


        private void weapon1_Load(object sender, EventArgs e)
        {

        }
    }
}
