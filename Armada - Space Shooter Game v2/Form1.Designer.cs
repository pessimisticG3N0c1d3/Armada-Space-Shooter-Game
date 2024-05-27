namespace Armada___Space_Shooter_Game_v2
{
    partial class Armada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Armada));
            this.BgMvTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.LeftMvTimer = new System.Windows.Forms.Timer(this.components);
            this.UpMvTimer = new System.Windows.Forms.Timer(this.components);
            this.DownMvTimer = new System.Windows.Forms.Timer(this.components);
            this.RightMvTimer = new System.Windows.Forms.Timer(this.components);
            this.BulletMvTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyMvTimer = new System.Windows.Forms.Timer(this.components);
            this.EnemyBulletTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelPlay = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.labelHelp = new System.Windows.Forms.Label();
            this.panelHelp = new System.Windows.Forms.Panel();
            this.labelCloseHelp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDirections = new System.Windows.Forms.Label();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.panelHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // BgMvTimer
            // 
            this.BgMvTimer.Interval = 10;
            this.BgMvTimer.Tick += new System.EventHandler(this.MoveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(348, 691);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // LeftMvTimer
            // 
            this.LeftMvTimer.Interval = 5;
            this.LeftMvTimer.Tick += new System.EventHandler(this.LeftMvTimer_Tick);
            // 
            // UpMvTimer
            // 
            this.UpMvTimer.Interval = 5;
            this.UpMvTimer.Tick += new System.EventHandler(this.UpMvTimer_Tick);
            // 
            // DownMvTimer
            // 
            this.DownMvTimer.Interval = 5;
            this.DownMvTimer.Tick += new System.EventHandler(this.DownMvTimer_Tick);
            // 
            // RightMvTimer
            // 
            this.RightMvTimer.Interval = 5;
            this.RightMvTimer.Tick += new System.EventHandler(this.RightMvTimer_Tick);
            // 
            // BulletMvTimer
            // 
            this.BulletMvTimer.Interval = 5;
            this.BulletMvTimer.Tick += new System.EventHandler(this.BulletMvTimer_Tick);
            // 
            // EnemyMvTimer
            // 
            this.EnemyMvTimer.Tick += new System.EventHandler(this.EnemyMvTimer_Tick);
            // 
            // EnemyBulletTimer
            // 
            this.EnemyBulletTimer.Interval = 20;
            this.EnemyBulletTimer.Tick += new System.EventHandler(this.EnemyBulletTimer_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Unispace", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(207, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Over!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.SystemColors.Control;
            this.labelScore.Location = new System.Drawing.Point(12, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(94, 23);
            this.labelScore.TabIndex = 4;
            this.labelScore.Text = "Score: ";
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelLevel.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLevel.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLevel.Location = new System.Drawing.Point(612, 9);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(106, 23);
            this.labelLevel.TabIndex = 5;
            this.labelLevel.Text = "Level: 0";
            // 
            // labelPlay
            // 
            this.labelPlay.AutoSize = true;
            this.labelPlay.BackColor = System.Drawing.Color.Transparent;
            this.labelPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPlay.Font = new System.Drawing.Font("Unispace", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPlay.Location = new System.Drawing.Point(327, 418);
            this.labelPlay.Name = "labelPlay";
            this.labelPlay.Size = new System.Drawing.Size(87, 36);
            this.labelPlay.TabIndex = 6;
            this.labelPlay.Text = "PLAY";
            this.labelPlay.Visible = false;
            this.labelPlay.Click += new System.EventHandler(this.labelPlay_Click);
            this.labelPlay.MouseLeave += new System.EventHandler(this.labelPlay_MouseLeave);
            this.labelPlay.MouseHover += new System.EventHandler(this.labelPlay_MouseHover_1);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BackColor = System.Drawing.Color.Transparent;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Unispace", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelExit.Location = new System.Drawing.Point(327, 500);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(87, 36);
            this.labelExit.TabIndex = 7;
            this.labelExit.Text = "EXIT";
            this.labelExit.Visible = false;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click_1);
            this.labelExit.MouseLeave += new System.EventHandler(this.labelExit_MouseLeave);
            this.labelExit.MouseHover += new System.EventHandler(this.labelExit_MouseHover);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelHelp.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelHelp.Location = new System.Drawing.Point(629, 720);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(107, 18);
            this.labelHelp.TabIndex = 8;
            this.labelHelp.Text = "How to play";
            this.labelHelp.Visible = false;
            this.labelHelp.Click += new System.EventHandler(this.labelHelp_Click);
            this.labelHelp.MouseHover += new System.EventHandler(this.labelHelp_MouseHover);
            // 
            // panelHelp
            // 
            this.panelHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHelp.Controls.Add(this.labelCloseHelp);
            this.panelHelp.Controls.Add(this.label2);
            this.panelHelp.Controls.Add(this.labelDirections);
            this.panelHelp.Location = new System.Drawing.Point(91, 192);
            this.panelHelp.Name = "panelHelp";
            this.panelHelp.Size = new System.Drawing.Size(581, 397);
            this.panelHelp.TabIndex = 9;
            this.panelHelp.Visible = false;
            this.panelHelp.MouseLeave += new System.EventHandler(this.panelHelp_MouseLeave);
            // 
            // labelCloseHelp
            // 
            this.labelCloseHelp.AutoSize = true;
            this.labelCloseHelp.BackColor = System.Drawing.Color.Transparent;
            this.labelCloseHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelCloseHelp.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCloseHelp.ForeColor = System.Drawing.Color.Red;
            this.labelCloseHelp.Location = new System.Drawing.Point(478, 352);
            this.labelCloseHelp.Name = "labelCloseHelp";
            this.labelCloseHelp.Size = new System.Drawing.Size(70, 23);
            this.labelCloseHelp.TabIndex = 2;
            this.labelCloseHelp.Text = "Close";
            this.labelCloseHelp.Click += new System.EventHandler(this.labelCloseHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Unispace", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "How to Play";
            // 
            // labelDirections
            // 
            this.labelDirections.AutoSize = true;
            this.labelDirections.BackColor = System.Drawing.Color.Black;
            this.labelDirections.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirections.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDirections.Location = new System.Drawing.Point(14, 83);
            this.labelDirections.Name = "labelDirections";
            this.labelDirections.Size = new System.Drawing.Size(399, 171);
            this.labelDirections.TabIndex = 0;
            this.labelDirections.Text = "Press the arrow keys to steer your ship\r\n\r\n               ← ↑ ↓ → \r\n\r\n    Press s" +
    "pacebar to pause the game\r\n\r\n  Blast down enemy ship to gain points\r\n\r\n         " +
    "Reach Level 10 to win!\r\n";
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxWelcome.BackgroundImage")));
            this.pictureBoxWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWelcome.Location = new System.Drawing.Point(56, 174);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(704, 220);
            this.pictureBoxWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWelcome.TabIndex = 10;
            this.pictureBoxWelcome.TabStop = false;
            this.pictureBoxWelcome.Visible = false;
            // 
            // Armada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.panelHelp);
            this.Controls.Add(this.pictureBoxWelcome);
            this.Controls.Add(this.labelHelp);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 800);
            this.MinimumSize = new System.Drawing.Size(800, 800);
            this.Name = "Armada";
            this.Text = "Armada: Space Shooter Game";
            this.Load += new System.EventHandler(this.Armada_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Armada_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Armada_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.panelHelp.ResumeLayout(false);
            this.panelHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer BgMvTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer LeftMvTimer;
        private System.Windows.Forms.Timer UpMvTimer;
        private System.Windows.Forms.Timer DownMvTimer;
        private System.Windows.Forms.Timer RightMvTimer;
        private System.Windows.Forms.Timer BulletMvTimer;
        private System.Windows.Forms.Timer EnemyMvTimer;
        private System.Windows.Forms.Timer EnemyBulletTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelPlay;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Panel panelHelp;
        private System.Windows.Forms.Label labelDirections;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCloseHelp;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
    }
}

