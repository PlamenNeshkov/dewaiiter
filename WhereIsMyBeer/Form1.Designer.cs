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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NakovCharacter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Beer_O_Meter = new System.Windows.Forms.ProgressBar();
            this.Ground = new System.Windows.Forms.Panel();
            this.PlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesCreation = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesMovement = new System.Windows.Forms.Timer(this.components);
            this.ColdBeersCreation = new System.Windows.Forms.Timer(this.components);
            this.ColdBeersMovement = new System.Windows.Forms.Timer(this.components);
            this.WalkAnimation = new System.Windows.Forms.Timer(this.components);
            this.Nakov = new System.Windows.Forms.PictureBox();
            this.ScoreTimer = new System.Windows.Forms.Timer(this.components);
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NakovCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.label3);
            this.Screen.Controls.Add(this.label2);
            this.Screen.Controls.Add(this.NakovCharacter);
            this.Screen.Controls.Add(this.label1);
            this.Screen.Controls.Add(this.Beer_O_Meter);
            this.Screen.Controls.Add(this.Ground);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(624, 441);
            this.Screen.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(601, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(548, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // NakovCharacter
            // 
            this.NakovCharacter.BackColor = System.Drawing.Color.Transparent;
            this.NakovCharacter.Image = ((System.Drawing.Image)(resources.GetObject("NakovCharacter.Image")));
            this.NakovCharacter.ImageLocation = "";
            this.NakovCharacter.Location = new System.Drawing.Point(13, 321);
            this.NakovCharacter.Name = "NakovCharacter";
            this.NakovCharacter.Size = new System.Drawing.Size(68, 108);
            this.NakovCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NakovCharacter.TabIndex = 0;
            this.NakovCharacter.TabStop = false;
            this.NakovCharacter.Click += new System.EventHandler(this.NakovCharacter_Click);
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
            // Beer_O_Meter
            // 
            this.Beer_O_Meter.Location = new System.Drawing.Point(214, 28);
            this.Beer_O_Meter.Name = "Beer_O_Meter";
            this.Beer_O_Meter.Size = new System.Drawing.Size(163, 23);
            this.Beer_O_Meter.TabIndex = 2;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ground.Location = new System.Drawing.Point(0, 429);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(624, 12);
            this.Ground.TabIndex = 1;
            this.Ground.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Screen);
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
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox NakovCharacter;
        private System.Windows.Forms.Timer PlayerMovement;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer ObstaclesCreation;
        private System.Windows.Forms.Timer ObstaclesMovement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Beer_O_Meter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer ColdBeersCreation;
        private System.Windows.Forms.Timer ColdBeersMovement;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer WalkAnimation;
        private System.Windows.Forms.PictureBox Nakov;
        private System.Windows.Forms.Timer ScoreTimer;
    }
}

