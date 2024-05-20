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

        public void RemoveCoinButton_Click(object sender, EventArgs e)
        {
            if (coinCount > 0)
            {
                coinCount--;
                UpdateCoinCountLabel();
            }
            else
            {
                MessageBox.Show("You don't have any coins to remove.");
            }
        }

        public void UpdateCoinCountLabel()
        {
            LabelCoinsGathered.Text = "Coins: " + coinCount.ToString();
        }
        public void InventoryContent()
        {
            if (coinCount > 0)
            {
                MessageBox.Show("Coins: " + coinCount.ToString());
            }
        }
    }
}
