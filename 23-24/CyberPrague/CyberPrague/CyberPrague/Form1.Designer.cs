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
            this.player1 = new CyberPrague.player();
            this.SuspendLayout();
            // 
            // timerCoin
            // 
            this.timerCoin.Enabled = true;
            this.timerCoin.Interval = 1000;
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
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(556, 206);
            this.player1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(84, 89);
            this.player1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1425, 757);
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
    }
}

