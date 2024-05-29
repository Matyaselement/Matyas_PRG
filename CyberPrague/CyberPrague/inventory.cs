using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CyberPrague
{
    public partial class Form1 : Form
    {
        public static List<Coin> CoinsList = new List<Coin>();
        public static int coinCount = 0;


        public void AddCoinButton_Click(object sender, EventArgs e)
        {
            coinCount++;
            UpdateCoinCountLabel();
        }

        public void UpdateCoinCountLabel()
        {
            LabelCoinsGathered.Text = "Coins: " + coinCount.ToString();
        }
    }
}
