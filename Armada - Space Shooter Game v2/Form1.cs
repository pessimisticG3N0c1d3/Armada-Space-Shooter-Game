using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WMPLib;

namespace Armada___Space_Shooter_Game_v2
{
    public partial class Armada : Form
    {
        // Declaring audio files variables
        WindowsMediaPlayer bgAudio;
        WindowsMediaPlayer shootAudio;
        WindowsMediaPlayer boomAudio;

        Random random;

        // Declaring PictureBox arrays and relative speed
        PictureBox[] stars;
        int bgSpeed;
        int playerSpeed;

        PictureBox[] ammo;
        int ammoSpeed;

        PictureBox[] enemies;
        int enemySpeed;

        PictureBox[] enemyBullet;
        int enemyBulletSpeed;

        // Declaring variables for score, level, difficulty
        int score;
        int level;
        int difficulty;

        // Boolean variables if the game is paused or if the game is over
        bool pause;
        bool isGameOver;

        public Armada()
        {
            InitializeComponent();
            WelcomeGame();
        }

        private void Armada_Load(object sender, EventArgs e)
        {
            // Initialize game values and load assets
            bgSpeed = 5;
            playerSpeed = 5;
            enemySpeed = 5;
            enemyBulletSpeed = 5;
            ammoSpeed = 20;
            ammo = new PictureBox[3];

            // Initialize default game state
            pause = false;
            isGameOver = false;
            score = 0;
            level = 1;
            difficulty = 9;

            //StartTimers();
            // Load images for the game
            Image bullet = Image.FromFile(@"assets\bullet.png");
            Image boss1 = Image.FromFile(@"assets\boss1.png");
            Image enemy1 = Image.FromFile(@"assets\enemy1.png");
            Image enemy2 = Image.FromFile(@"assets\enemy2.png");
            Image enemy3 = Image.FromFile(@"assets\enemy3.png");
            Image enemy4 = Image.FromFile(@"assets\enemy4.png");
            Image enemy5 = Image.FromFile(@"assets\enemy5.png");
            Image enemy6 = Image.FromFile(@"assets\enemy6.png");
            Image enemy7 = Image.FromFile(@"assets\enemy7.png");
            Image enemy8 = Image.FromFile(@"assets\enemy8.png");
            Image boss2 = Image.FromFile(@"assets\boss2.png");

            enemies = new PictureBox[10];

            // Initialize enemy picture boxes
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(50, 50);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].BackColor = Color.Transparent;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }

            // Assign images to enemies
            enemies[0].Image = boss1;
            enemies[1].Image = enemy1;
            enemies[2].Image = enemy2;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy4;
            enemies[5].Image = enemy5;
            enemies[6].Image = enemy6;
            enemies[7].Image = enemy7;
            enemies[8].Image = enemy8;
            enemies[9].Image = boss2;

            // Initialize ammo
            for (int i = 0; i < ammo.Length; i++)
            {
                ammo[i] = new PictureBox();
                ammo[i].Size = new Size(8, 8);
                ammo[i].Image = bullet;
                ammo[i].SizeMode = PictureBoxSizeMode.Zoom;
                ammo[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(ammo[i]);
            }

            // Windows Media Player Initialization
            bgAudio = new WindowsMediaPlayer();
            shootAudio = new WindowsMediaPlayer();
            boomAudio = new WindowsMediaPlayer();

            // Load audio files
            bgAudio.URL = @"audio\GameSong.mp3";
            shootAudio.URL = @"audio\shoot.mp3";
            boomAudio.URL = @"audio\boom.mp3";

            // Setup audio settings
            bgAudio.settings.setMode("loop", true);
            bgAudio.settings.volume = 5;
            shootAudio.settings.volume = 3;
            boomAudio.settings.volume = 6;

            stars = new PictureBox[10];
            random = new Random();

            // Initialize stars
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(random.Next(20, 580), random.Next(-10, 400));

                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Yellow;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }

                this.Controls.Add(stars[i]);
            }

            // Update star positions
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += bgSpeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }

            // Initialize enemy bullets
            enemyBullet = new PictureBox[10];

            for (int i = 0; i < enemyBullet.Length; i++)
            {
                enemyBullet[i] = new PictureBox();
                enemyBullet[i].Size = new Size(2, 25);
                enemyBullet[i].Visible = false;
                enemyBullet[i].BackColor = Color.Yellow;
                int x = random.Next(0, 10);
                enemyBullet[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add((enemyBullet[i]));
            }
            bgAudio.controls.play(); // Start background audio
        }

        private void MoveBgTimer_Tick(object sender, EventArgs e)
        {
            // Move background stars
            for (int i = 0; i < stars.Length / 2; i++)
            {
                stars[i].Top += bgSpeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += bgSpeed = 2;

                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMvTimer_Tick(object sender, EventArgs e)
        {
            // Move player left
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void UpMvTimer_Tick(object sender, EventArgs e)
        {
            // Move player up
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void DownMvTimer_Tick(object sender, EventArgs e)
        {
            // Move player down
            if (Player.Top < 600)
            {
                Player.Top += playerSpeed;
            }
        }

        private void RightMvTimer_Tick(object sender, EventArgs e)
        {
            // Move player right
            if (Player.Right < 600)
            {
                Player.Left += playerSpeed;
            }
        }

        private void Armada_KeyDown(object sender, KeyEventArgs e)
        {
            // Handle key press events
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMvTimer.Start();
                }
                else if (e.KeyCode == Keys.Left)
                {
                    LeftMvTimer.Start();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    UpMvTimer.Start();
                }
                else if (e.KeyCode == Keys.Down)
                {
                    DownMvTimer.Start();
                }
            }
        }

        private void Armada_KeyUp(object sender, KeyEventArgs e)
        {
            // Handle key release events
            RightMvTimer.Stop();
            LeftMvTimer.Stop();
            DownMvTimer.Stop();
            UpMvTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!isGameOver)
                {
                    if (pause)
                    {
                        StartTimers();
                        label1.Visible = false;
                        labelHelp.Visible = false;
                        panelHelp.Visible = false;
                        bgAudio.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label1.Text = "PAUSED";
                        label1.Visible = true;
                        labelHelp.Visible = true;
                        bgAudio.controls.pause();
                        StopTimers();
                        pause = true;
                    }
                }
            }
        }

        private void BulletMvTimer_Tick(object sender, EventArgs e)
        {
            // Move bullets and handle collisions
            shootAudio.controls.play();
            for (int i = 0; i < ammo.Length; i++)
            {
                if (ammo[i].Top > 0)
                {
                    ammo[i].Visible = true;
                    ammo[i].Top -= ammoSpeed;

                    Collision();
                }
                else
                {
                    ammo[i].Visible = false;
                    ammo[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void EnemyMvTimer_Tick(object sender, EventArgs e)
        {
            // Move enemies
            MoveEnemies(enemies, enemySpeed);
        }

        private void MoveEnemies(PictureBox[] array, int speed)
        {
            // Move enemies and reset their positions if needed
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Visible) // Check if enemy is already visible
                {
                    // Set random location based on form size
                    array[i].Location = new Point(random.Next(-50, this.ClientSize.Width + 50), random.Next(-200, -50));
                    array[i].Visible = true;
                }
                else
                {
                    array[i].Top += speed;

                    // Check if the enemy is outside form
                    if (array[i].Top > this.ClientSize.Height)
                    {
                        // Reset enemy position if it is outside the form 
                        array[i].Location = new Point(random.Next(-50, this.ClientSize.Width + 50), random.Next(-200, -50));
                    }
                }
            }
        }

        // Method for collision
        private void Collision()
        {
            // Handle collisions between bullets and enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                if (ammo[0].Bounds.IntersectsWith(enemies[i].Bounds) || ammo[1].Bounds.IntersectsWith(enemies[i].Bounds) || ammo[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    boomAudio.controls.play();

                    score += 1;
                    labelScore.Text = (score < 10) ? "Score: " + score.ToString() : "Score: " + score.ToString();

                    if (score % 30 == 0)
                    {
                        level += 1;
                        labelLevel.Text = (level < 10) ? "Level: 0" + level.ToString() : "Level: 0" + level.ToString();

                        if (enemySpeed <= 10 && enemyBulletSpeed <= 10 && difficulty >= 0)
                        {
                            difficulty--;
                            enemySpeed++;
                            enemyBulletSpeed++;
                        }

                        if (level == 10)
                        {
                            GameOver("Well Done!");
                        }
                    }

                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    boomAudio.settings.volume = 30;
                    boomAudio.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }

        // Method if the game is over with string parameter for prompt
        private void GameOver(String prompt)
        {
            // Display game over prompt and stop the game
            label1.Text = prompt;
            label1.Visible = true;
            labelPlay.Visible = true;
            labelExit.Visible = true;
            labelHelp.Visible = true;

            bgAudio.controls.stop();
            StopTimers();
        }

        // Method for stopping timers
        private void StopTimers()
        {
            // Stop all game timers
            BgMvTimer.Stop();
            EnemyMvTimer.Stop();
            BulletMvTimer.Stop();
            EnemyBulletTimer.Stop();
        }

        private void StartTimers()
        {
            // Start all game timers
            BgMvTimer.Start();
            EnemyMvTimer.Start();
            BulletMvTimer.Start();
            EnemyBulletTimer.Start();
        }

        private void EnemyBulletTimer_Tick(object sender, EventArgs e)
        {
            // Move enemy bullets and handle collisions
            for (int i = 0; i < enemyBullet.Length - difficulty; i++)
            {
                if (enemyBullet[i].Top < this.Height)
                {
                    enemyBullet[i].Visible = true;
                    enemyBullet[i].Top += enemyBulletSpeed;

                    CollisionWithEnemyBullet();
                }
                else
                {
                    enemyBullet[i].Visible = false;
                    int x = random.Next(0, 10);
                    enemyBullet[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }

        private void CollisionWithEnemyBullet()
        {
            // Handle collisions between enemy bullets and the player
            for (int i = 0; i < enemyBullet.Length; i++)
            {
                if (enemyBullet[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemyBullet[i].Visible = false;
                    boomAudio.settings.volume = 30;
                    boomAudio.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }

        private void labelPlay_Click(object sender, EventArgs e)
        {
            // Restart the game when Play label is clicked
            this.Controls.Clear();
            InitializeComponent();
            Armada_Load(e, e);
            StartTimers();
            pictureBoxWelcome.Visible = false;
        }

        private void labelHelp_Click(object sender, EventArgs e)
        {
            // Show the help panel
            panelHelp.Visible = true;
        }

        private void labelCloseHelp_Click(object sender, EventArgs e)
        {
            // Hide the help panel
            panelHelp.Visible = false;
        }

        private void WelcomeGame()
        {
            // Show welcome screen
            pictureBoxWelcome.Visible = true;
            labelPlay.Visible = true;
            labelExit.Visible = true;
            labelHelp.Visible = true;
        }

    // Change ForeColor when the mouse hovers over the label
    private void labelHelp_MouseHover(object sender, EventArgs e)
        {
            labelHelp.ForeColor = Color.Yellow;
        }

        private void labelPlay_MouseHover_1(object sender, EventArgs e)
        {
            labelPlay.ForeColor = Color.Yellow;
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.Yellow;
        }
        
        // Change ForeColor when the mouse leaves the label
        private void panelHelp_MouseLeave(object sender, EventArgs e)
        {
            labelHelp.ForeColor = Color.White;
        }

        private void labelPlay_MouseLeave(object sender, EventArgs e)
        {
            labelPlay.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();

            // Bring a message dialog box as confirmation prompt to exit the program
            dialog = MessageBox.Show("Do you really want to close?", "Exit?", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                System.Environment.Exit(1);
            }
        }
    }
}

