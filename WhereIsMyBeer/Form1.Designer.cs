namespace WhereIsMyBeer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Screen = new System.Windows.Forms.Panel();
            this.highScoreLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NakovCharacter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.beerometer = new System.Windows.Forms.ProgressBar();
            this.Ground = new System.Windows.Forms.Panel();
            this.PauseScreen = new System.Windows.Forms.Panel();
            this.PlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesCreation = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesMovement = new System.Windows.Forms.Timer(this.components);
            this.ColdBeersCreation = new System.Windows.Forms.Timer(this.components);
            this.ColdBeersMovement = new System.Windows.Forms.Timer(this.components);
            this.WalkAnimation = new System.Windows.Forms.Timer(this.components);
            this.Nakov = new System.Windows.Forms.PictureBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NakovCharacter)).BeginInit();
            this.PauseScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.highScoreLbl);
            this.Screen.Controls.Add(this.label4);
            this.Screen.Controls.Add(this.label3);
            this.Screen.Controls.Add(this.label2);
            this.Screen.Controls.Add(this.NakovCharacter);
            this.Screen.Controls.Add(this.label1);
            this.Screen.Controls.Add(this.beerometer);
            this.Screen.Controls.Add(this.Ground);
            this.Screen.Controls.Add(this.PauseScreen);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(624, 441);
            this.Screen.TabIndex = 0;
            // 
            // highScoreLbl
            // 
            this.highScoreLbl.AutoSize = true;
            this.highScoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highScoreLbl.Location = new System.Drawing.Point(585, 35);
            this.highScoreLbl.Name = "highScoreLbl";
            this.highScoreLbl.Size = new System.Drawing.Size(15, 16);
            this.highScoreLbl.TabIndex = 7;
            this.highScoreLbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(493, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "High Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(585, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(493, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // NakovCharacter
            // 
            this.NakovCharacter.BackColor = System.Drawing.Color.Transparent;
            this.NakovCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NakovCharacter.Image = ((System.Drawing.Image)(resources.GetObject("NakovCharacter.Image")));
            this.NakovCharacter.ImageLocation = "";
            this.NakovCharacter.Location = new System.Drawing.Point(13, 321);
            this.NakovCharacter.Name = "NakovCharacter";
            this.NakovCharacter.Size = new System.Drawing.Size(44, 108);
            this.NakovCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NakovCharacter.TabIndex = 0;
            this.NakovCharacter.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Beer-o-meter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            this.label1.UseWaitCursor = true;
            // 
            // beerometer
            // 
            this.beerometer.Location = new System.Drawing.Point(214, 28);
            this.beerometer.Name = "beerometer";
            this.beerometer.Size = new System.Drawing.Size(163, 23);
            this.beerometer.TabIndex = 2;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ground.Location = new System.Drawing.Point(0, 429);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(624, 12);
            this.Ground.TabIndex = 1;
            // 
            // PauseScreen
            // 
            this.PauseScreen.BackColor = System.Drawing.Color.Transparent;
            this.PauseScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PauseScreen.BackgroundImage")));
            this.PauseScreen.Controls.Add(this.label6);
            this.PauseScreen.Controls.Add(this.label5);
            this.PauseScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseScreen.Enabled = false;
            this.PauseScreen.Location = new System.Drawing.Point(0, 0);
            this.PauseScreen.Name = "PauseScreen";
            this.PauseScreen.Size = new System.Drawing.Size(624, 441);
            this.PauseScreen.TabIndex = 8;
            this.PauseScreen.Visible = false;
            // 
            // PlayerMovement
            // 
            this.PlayerMovement.Enabled = true;
            this.PlayerMovement.Interval = 23;
            this.PlayerMovement.Tick += new System.EventHandler(this.PlayerMovement_Tick);
            // 
            // ObstaclesCreation
            // 
            this.ObstaclesCreation.Enabled = true;
            this.ObstaclesCreation.Interval = 7000;
            this.ObstaclesCreation.Tick += new System.EventHandler(this.ObstaclesCreation_Tick);
            // 
            // ObstaclesMovement
            // 
            this.ObstaclesMovement.Enabled = true;
            this.ObstaclesMovement.Interval = 40;
            this.ObstaclesMovement.Tick += new System.EventHandler(this.ObstaclesMovement_Tick);
            // 
            // ColdBeersCreation
            // 
            this.ColdBeersCreation.Enabled = true;
            this.ColdBeersCreation.Interval = 7000;
            this.ColdBeersCreation.Tick += new System.EventHandler(this.ColdBeersCreation_Tick);
            // 
            // ColdBeersMovement
            // 
            this.ColdBeersMovement.Enabled = true;
            this.ColdBeersMovement.Interval = 40;
            this.ColdBeersMovement.Tick += new System.EventHandler(this.ColdBeersMovement_Tick);
            // 
            // WalkAnimation
            // 
            this.WalkAnimation.Enabled = true;
            this.WalkAnimation.Interval = 300;
            this.WalkAnimation.Tick += new System.EventHandler(this.WalkAnimation_Tick);
            // 
            // Nakov
            // 
            this.Nakov.BackColor = System.Drawing.Color.Transparent;
            this.Nakov.ErrorImage = null;
            this.Nakov.ImageLocation = "";
            this.Nakov.Location = new System.Drawing.Point(15, 230);
            this.Nakov.Name = "Nakov";
            this.Nakov.Size = new System.Drawing.Size(77, 200);
            this.Nakov.TabIndex = 0;
            this.Nakov.TabStop = false;
            // 
            // ScoreTimer
            // 
            this.ScoreTimer.Enabled = true;
            this.ScoreTimer.Tick += new System.EventHandler(this.ScoreTimer_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(207, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 55);
            this.label5.TabIndex = 0;
            this.label5.Text = "PAUSE ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(161, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "PRESS ENTER TO CONTINUE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Screen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WhereIsMyBeer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NakovCharacter)).EndInit();
            this.PauseScreen.ResumeLayout(false);
            this.PauseScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox NakovCharacter;
        private System.Windows.Forms.Timer PlayerMovement;
        private System.Windows.Forms.Timer ObstaclesCreation;
        private System.Windows.Forms.Timer ObstaclesMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar beerometer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ColdBeersCreation;
        private System.Windows.Forms.Timer ColdBeersMovement;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer WalkAnimation;
        private System.Windows.Forms.PictureBox Nakov;
        private System.Windows.Forms.Timer ScoreTimer;
        public System.Windows.Forms.Label highScoreLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PauseScreen;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

