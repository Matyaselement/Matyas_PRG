using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CyberPrague2._0
{
    public partial class Form1 : Form
    {
        private Button restartButton; // Declare the restart button
        private bool healthBoxExists = false;
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(keyisdown);
            this.KeyUp += new KeyEventHandler(keyisup);
            this.KeyPreview = true; 

            // Initialize the restart button
            restartButton = new Button();  
            restartButton.Text = "Restart";
            restartButton.Size = new Size(100, 50);
            restartButton.Location = new Point((this.Width / 2) - 50, (this.Height / 2) - 25);
            restartButton.Visible = false; // Initially hidden
            restartButton.Click += RestartButton_Click; // Attach the click event handler
            this.Controls.Add(restartButton);
        }
        private void CreateButton()
        {
            restartButton = new Button();  
            restartButton.Text = "Restart";
            restartButton.Size = new Size(100, 50);
            restartButton.Location = new Point((this.Width / 2) - 50, (this.Height / 2) - 25);
            restartButton.Visible = false; // Initially hidden
            restartButton.Click += RestartButton_Click; 
            this.Controls.Add(restartButton);
        }

        bool goup; //  player to go up the screen
        bool godown; // player to go down the screen
        bool goleft; //  player to go left to the screen
        bool goright; //  player to right to the screen
        string facing = "up"; // this string is called facing and it will be used to guide the bullets
        double HP = 100; //  player health
        int speed = 10; //  speed of the player
        int ammo = 10; //  number of ammo the player has start of the game
        int enemy1Speed = 3; // this integer will hold the speed which the enemys move in the game
        int enemy2Speed = 2;
        int score = 0; 
        bool gameOver = false; // this boolean is false in the beginning and it will be used when the game is finished
        Random rnd = new Random(); 
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (gameOver) return; // if game over is true then do nothing in this event
                                  // if the left key is pressed then do the following

            if (e.KeyCode == Keys.Left)
            {
                goleft = true; 
                facing = "left"; 
                player.Image = Properties.Resources.playerCharacterLeft; //  image to LEFT image
            }
            // end of left key selection
            // if the right key is pressed then do the following
            if (e.KeyCode == Keys.Right)
            {
                goright = true; 
                facing = "right"; 
                player.Image = Properties.Resources.playerCharacterRight; // image to right
            }
            // end of right key selection
            // if the up key is pressed then do the following
            if (e.KeyCode == Keys.Up)
            {
                facing = "up"; 
                goup = true; 
                player.Image = Properties.Resources.playerCharacterUp; //  image to up
            }
            // end of up key selection
            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.Down)
            {
                facing = "down"; 
                godown = true; 
                player.Image = Properties.Resources.playerCharacterDown; //image to down
            }
            // end of the down key selection
        }
        // extra different way for the pictureboxes to rotate, not functional
        /*if (e.KeyCode == Keys.Left && currentFacing != "left")
            {
                goleft = true; // change go left to true
                facing = "left"; //change facing to left
                switch (currentFacing)
                {
                    case "up":
                        FlipPlayerImage(RotateFlipType.Rotate270FlipNone);
                        break;
                    case "down":
                        FlipPlayerImage(RotateFlipType.Rotate90FlipNone);
                        break;
                    case "right":
                        FlipPlayerImage(RotateFlipType.Rotate180FlipNone);
                        break;
                }
                // change the player image to LEFT image

                currentFacing = "left";
            }
            // end of left key selection
            // if the right key is pressed then do the following
            if (e.KeyCode == Keys.Right && currentFacing != "right")
            {
                goright = true; // change go right to true
                facing = "right"; // change facing to right
                switch (currentFacing)
                {
                    case "up":
                        FlipPlayerImage(RotateFlipType.Rotate90FlipNone);
                        break;
                    case "down":
                        FlipPlayerImage(RotateFlipType.Rotate270FlipNone);
                        break;
                    case "left":
                        FlipPlayerImage(RotateFlipType.Rotate180FlipNone);
                        break;
                }

                currentFacing = "right";
            }
            // end of right key selection
            // if the up key is pressed then do the following
            if (e.KeyCode == Keys.Up && currentFacing != "up")
            {
                facing = "up"; // change facing to up
                goup = true; // change go up to true
                switch (currentFacing)
                {
                    case "left":
                        FlipPlayerImage(RotateFlipType.Rotate90FlipNone);
                        break;
                    case "right":
                        FlipPlayerImage(RotateFlipType.Rotate270FlipNone);
                        break;
                    case "down":
                        FlipPlayerImage(RotateFlipType.Rotate180FlipNone);
                        break;
                }

                currentFacing = "up";
            }
            // end of up key selection
            // if the down key is pressed then do the following
            if (e.KeyCode == Keys.Down && currentFacing != "down")
            {
                facing = "down"; // change facing to down
                godown = true; // change go down to true
                switch (currentFacing)
                {
                    case "left":
                        FlipPlayerImage(RotateFlipType.Rotate270FlipNone);
                        break;
                    case "right":
                        FlipPlayerImage(RotateFlipType.Rotate90FlipNone);
                        break;
                    case "up":
                        FlipPlayerImage(RotateFlipType.Rotate180FlipNone);
                        break;
                }

                currentFacing = "down";
        */

        //vresion that didnt work
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (gameOver) return; // if game is over then do nothing in this event
            // below is the key up selection for the left key
            if (e.KeyCode == Keys.Left)
            {
                goleft = false; 
            }
            // below is the key up selection for the right key
            if (e.KeyCode == Keys.Right)
            {
                goright = false; 
            }
           
            if (e.KeyCode == Keys.Up)
            {
                goup = false; 
            }
           
            if (e.KeyCode == Keys.Down)
            {
                godown = false; 
            }
            
            if (e.KeyCode == Keys.Space && ammo > 0) // in this if statement we are checking if the space bar is up and ammo is more than 0
            {
                ammo--; // reduce ammo by 1
                shoot(facing); // invoke the shoot function with the facing string inside it
                //facing will transfer up, down, left or right to the function and that will shoot the bullet that way. 
                if (ammo < 1) // if ammo is less than 1
                {
                    DropAmmo(); // drop ammo function
                }
            }
            if (healthBar.Value < 20)
            {
                DropHP();
            }
        }
        private void gameEngine(object sender, EventArgs e)
        {

            if (HP > 1) // if player health is greater than 1
            {
                healthBar.Value = Convert.ToInt32(HP); // assign the progress bar to the player health integer
            }
            else
            {
                // extras
                // if the player health is below 1
                //player.Image = Properties.Resources.dead; // show the player dead image
                // stop the timer
                // change game over to true
                timer1.Stop();
                gameOver = true;
                restartButton.Visible = true; // Show the restart button
                restartButton.BringToFront();
            }
            ammoLabel.Text = "   Ammo:  " + ammo; // show the ammo amount on label 1
            killCountLabel.Text = "Kills: " + score; // show the total kills on the score
            // if the player health is less than 20
            if (healthBar.Value < 20)
            {
                healthBar.ForeColor = System.Drawing.Color.Red; // change the progress bar colour to red. 
                
            }
            if (goleft && player.Left > 0)
            {
                player.Left -= speed;
                // if moving left is true AND pacman is 1 pixel more from the left 
                // then move the player to the LEFT
            }
            if (goright && player.Left + player.Width < ClientSize.Width)
            {
                player.Left += speed;
                // if moving RIGHT is true AND player left + player width is less than 930 pixels
                // then move the player to the RIGHT
            }
            if (goup && player.Top > 60)
            {
                player.Top -= speed;
                // if moving TOP is true AND player is 60 pixel more from the top 
                // then move the player to the UP
            }
            if (godown && player.Top + player.Height < ClientSize.Height)
            {
                player.Top += speed;
                // if moving DOWN is true AND player top + player height is less than 700 pixels
                // then move the player to the DOWN
            }
            // run the first for each loop below
            // X is a control and we will search for all controls in this loop
            foreach (Control x in this.Controls)
            {
                // if the X is a picture box and X has a tag AMMO
                if (x is PictureBox && x.Tag == "ammo")
                {
                    // check is X in hitting the player picture box
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        // once the player picks up the ammo
                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box
                        ((PictureBox)x).Dispose(); // dispose the picture box completely from the program
                        ammo += 7; // add 5 ammo to the integer
                    }
                }
                foreach (Control y in this.Controls)
                {
                    if (y is PictureBox && y.Tag == "HP")
                    {
                        if (((PictureBox)y).Bounds.IntersectsWith(player.Bounds))
                        {
                            this.Controls.Remove(((PictureBox)y));
                            ((PictureBox)y).Dispose();
                            HP += 20;

                            healthBoxExists = false;
                        }
                    }
                }

                    // if the bullets hits the 4 borders of the game
                    // if x is a picture box and x has the tag of bullet
                    if (x is PictureBox && x.Tag == "bullet")
                {
                    // if the shot bullet is within the bounds
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 2500 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 1500)
                    {
                        this.Controls.Remove(((PictureBox)x)); // remove the bullet from the display
                        ((PictureBox)x).Dispose(); // dispose the bullet from the program
                    }
                }
                // below is the if statement which will be checking if the player hits a enemy
                if (x is PictureBox && x.Tag == "enemy")
                {
                    // below is the if statament thats checking the bounds of the player and the enemy
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        HP -= 2; // if the enemy hits the player then we decrease the health by 1
                    }
                    //move enemy towards the player picture box
                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= enemy1Speed; // move enemy towards the left of the player
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter1Left; // change the enemy image to the left
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= enemy1Speed; // move enemy upwards towards the players top
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter1Up; // change the enemy picture to the top pointing image
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += enemy1Speed; // move enemy towards the right of the player
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter1Right; // change the image to the right image
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += enemy1Speed; // move the enemy towards the bottom of the player
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter1Down; // change the image to the down enemy
                    }
                }
                if (x is PictureBox && x.Tag == "enemy2")
                {
                    // just a copy for otherr enemy, prolly better way to do it but i am lazyy
                    if (((PictureBox)x).Bounds.IntersectsWith(player.Bounds))
                    {
                        HP -= 4; // different stats
                    }
                    
                    if (((PictureBox)x).Left > player.Left)
                    {
                        ((PictureBox)x).Left -= enemy2Speed; 
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter2Left; 
                    }
                    if (((PictureBox)x).Top > player.Top)
                    {
                        ((PictureBox)x).Top -= enemy2Speed; 
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter2Up; 
                    }
                    if (((PictureBox)x).Left < player.Left)
                    {
                        ((PictureBox)x).Left += enemy2Speed; 
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter2Right;
                    }
                    if (((PictureBox)x).Top < player.Top)
                    {
                        ((PictureBox)x).Top += enemy2Speed; 
                        ((PictureBox)x).Image = Properties.Resources.enemyCharacter2Down; 
                    }
                }
                // below is the second for loop, this is nexted inside the first one
                // the bullet and enemy needs to be different than each other
                //  determine if the hit each other
                foreach (Control j in this.Controls)
                {
                    // below is the selection thats identifying the bullet and enemy
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "enemy"))
                    {
                        // below is the if statement thats checking if bullet hits the enemy
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; 
                            this.Controls.Remove(j); 
                            j.Dispose(); 
                            this.Controls.Remove(x); 
                            x.Dispose(); 
                            makeEnemy(); 
                        }
                    }
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "enemy2"))
                    {
                        // below is the if statement thats checking if bullet hits the enemy
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++; // increase scoore by 1
                            this.Controls.Remove(j); 
                            j.Dispose(); 
                            this.Controls.Remove(x); 
                            x.Dispose(); 
                            makeEnemy2(); //resets the enemy
                        }
                    }
                }
            }
        }

        private void DropAmmo()
        {
          
            PictureBox ammo = new PictureBox(); 
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.Size = new System.Drawing.Size(64, 64);
            ammo.SizeMode = PictureBoxSizeMode.StretchImage; 
            ammo.Left = rnd.Next(10, ClientSize.Width - 64);
            ammo.Top = rnd.Next(50, ClientSize.Height - 64);
            ammo.Tag = "ammo"; // set the tag to ammo
            this.Controls.Add(ammo); 
            ammo.BringToFront(); 
            player.BringToFront(); 
        }
        private void DropHP()
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag == "HP")
                {
                    return; // Exit the method if an HP box is already present
                }
            }
            PictureBox Hp = new PictureBox();
            Hp.Image = Properties.Resources.HP_Image;// assignment the ammo image to the picture box
            Hp.Size = new System.Drawing.Size(64, 64);
            Hp.SizeMode = PictureBoxSizeMode.StretchImage; // set the size to auto size
            Hp.Left = rnd.Next(10, ClientSize.Width - 64); // set the location to a random left
            Hp.Top = rnd.Next(50, ClientSize.Height - 64); // set the location to a random top
            Hp.Tag = "HP"; // set the tag to ammo
            this.Controls.Add(Hp); // add the ammo picture box to the screen
            Hp.BringToFront(); // bring it to front
            player.BringToFront(); // bring the player to front
            healthBoxExists = true;
        }
        private void shoot(string direct)
        {
            // this is the function thats makes the new bullets in this game
            bullet shoot = new bullet();
            shoot.direction = direct; 
            shoot.bulletLeft = player.Left + (player.Width / 2); 
            shoot.bulletTop = player.Top + (player.Height / 2); 
            shoot.mkBullet(this); 
        }

        private void makeEnemy()
        {
            // when this function is called it will make enemys in the game
            PictureBox enemy = new PictureBox(); 
            enemy.Size = new System.Drawing.Size(50, 50);
            enemy.Tag = "enemy"; 
            enemy.Image = Properties.Resources.enemyCharacter1Down;
            enemy.Left = rnd.Next(0, ClientSize.Width - 64); 
            enemy.Top = rnd.Next(0, ClientSize.Height - 64); 
            enemy.SizeMode = PictureBoxSizeMode.StretchImage; 
            this.Controls.Add(enemy); // add the picture box to the screen
            DoubleBuffered = true;
            player.BringToFront(); // bring the player to the front
        }
        private void makeEnemy2()
        {
            // when this function is called it will make ´different enemy in the game
            PictureBox enemy2 = new PictureBox(); 
            enemy2.Size = new System.Drawing.Size(50, 50);
            enemy2.Tag = "enemy2"; 
            enemy2.Image = Properties.Resources.enemyCharacter2Down; 
            enemy2.Left = rnd.Next(0, ClientSize.Width - 64); 
            enemy2.Top = rnd.Next(0, ClientSize.Height - 64); 
            enemy2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(enemy2); 
            DoubleBuffered = true;
            player.BringToFront(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.playerCharacterLeft;
            DoubleBuffered = true;
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.Location = new Point(100, 100);  // Set initial position
            this.Controls.Add(player);
            timer1.Interval = 20;  // Set the interval for the timer (50 milliseconds in this case)
            timer1.Tick += new EventHandler(gameEngine);
            timer1.Start();  // Start the timer
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            // Reset game state
            HP = 100;
            score = 0;
            ammo = 10;
            gameOver = false;
            restartButton.Visible = false;

            // Clear existing enemys and bullets
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control x = this.Controls[i];
                if (x is PictureBox && (x.Tag == "enemy" || x.Tag == "bullet" || x.Tag == "enemy2"))
                {
                    this.Controls.Remove(x);
                    x.Dispose();
                }
            }

            // Unsubscribe from key events to avoid multiple subscriptions
            this.KeyDown -= keyisdown;
            this.KeyUp -= keyisup;

            // Restart the game elements
            for (int i = 0; i < 2; i++)
            {
                makeEnemy();
            }
            for (int i = 0; i < 1; i++)
            {
                makeEnemy2();
            }
            


            timer1.Start();
            player.Image = Properties.Resources.playerCharacterLeft;
            player.Location = new Point(100, 100); // Reset player position
            healthBar.Value = 100;
            healthBar.ForeColor = System.Drawing.Color.Green;
            ammoLabel.Text = "   Ammo:  " + ammo;
            killCountLabel.Text = "Kills: " + score;

            // Re-subscribe to key events
            this.KeyDown += keyisdown;
            this.KeyUp += keyisup;

            this.Focus();
        }

        
    }
}
