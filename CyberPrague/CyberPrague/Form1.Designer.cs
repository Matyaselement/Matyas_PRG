namespace CyberPrague
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerCoin = new System.Windows.Forms.Timer(this.components);
            this.updateCoinPick = new System.Windows.Forms.Timer(this.components);
            this.LabelCoinsGathered = new System.Windows.Forms.Label();
            this.weapon1 = new CyberPrague.weapon();
            this.player2 = new CyberPrague.player();
            this.player1 = new CyberPrague.player();
            this.SuspendLayout();
            // 
            // timerCoin
            // 
            this.timerCoin.Enabled = true;
            this.timerCoin.Interval = 10000;
            this.timerCoin.Tick += new System.EventHandler(this.timerCoin_Tick);
            // 
            // updateCoinPick
            // 
            this.updateCoinPick.Enabled = true;
            this.updateCoinPick.Interval = 33;
            this.updateCoinPick.Tick += new System.EventHandler(this.updateCoinPick_Tick_1);
            // 
            // LabelCoinsGathered
            // 
            this.LabelCoinsGathered.AutoSize = true;
            this.LabelCoinsGathered.Location = new System.Drawing.Point(42, 37);
            this.LabelCoinsGathered.Name = "LabelCoinsGathered";
            this.LabelCoinsGathered.Size = new System.Drawing.Size(59, 20);
            this.LabelCoinsGathered.TabIndex = 1;
            this.LabelCoinsGathered.Text = "0 coins";
            // 
            // weapon1
            // 
            this.weapon1.AutoSize = true;
            this.weapon1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.weapon1.BackColor = System.Drawing.Color.Transparent;
            this.weapon1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weapon1.Location = new System.Drawing.Point(490, 174);
            this.weapon1.Name = "weapon1";
            this.weapon1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.weapon1.Size = new System.Drawing.Size(63, 123);
            this.weapon1.TabIndex = 4;
            this.weapon1.Load += new System.EventHandler(this.weapon1_Load);
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.Transparent;
            this.player2.Location = new System.Drawing.Point(490, 312);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(76, 80);
            this.player2.TabIndex = 3;
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(-22502, 206);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(84, 89);
            this.player1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.weapon1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.LabelCoinsGathered);
            this.Controls.Add(this.player1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerCoin;
        private player player1;
        private System.Windows.Forms.Timer updateCoinPick;
        private System.Windows.Forms.Label LabelCoinsGathered;
        private player player2;
        private weapon weapon1;
    }
}

