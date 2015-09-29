namespace Nakoholic
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
            this.Screen = new System.Windows.Forms.Panel();
            this.Floor = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.MovementTimer = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesSpawningTimer = new System.Windows.Forms.Timer(this.components);
            this.ObstacleMovement = new System.Windows.Forms.Timer(this.components);
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.Floor);
            this.Screen.Controls.Add(this.Player);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(398, 309);
            this.Screen.TabIndex = 0;
            // 
            // Floor
            // 
            this.Floor.BackColor = System.Drawing.Color.CadetBlue;
            this.Floor.Location = new System.Drawing.Point(0, 280);
            this.Floor.Name = "Floor";
            this.Floor.Size = new System.Drawing.Size(398, 29);
            this.Floor.TabIndex = 1;
            this.Floor.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Chartreuse;
            this.Player.Location = new System.Drawing.Point(27, 247);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(30, 33);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // MovementTimer
            // 
            this.MovementTimer.Enabled = true;
            this.MovementTimer.Interval = 16;
            this.MovementTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ObstaclesSpawningTimer
            // 
            this.ObstaclesSpawningTimer.Enabled = true;
            this.ObstaclesSpawningTimer.Interval = 5000;
            this.ObstaclesSpawningTimer.Tick += new System.EventHandler(this.ObstaclesSpawningTimer_Tick_1);
            // 
            // ObstacleMovement
            // 
            this.ObstacleMovement.Enabled = true;
            this.ObstacleMovement.Interval = 500;
            this.ObstacleMovement.Tick += new System.EventHandler(this.ObstacleMovement_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 309);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Floor;
        private System.Windows.Forms.Timer MovementTimer;
        private System.Windows.Forms.Timer ObstaclesSpawningTimer;
        private System.Windows.Forms.Timer ObstacleMovement;
    }
}

