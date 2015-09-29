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
            this.Screen = new System.Windows.Forms.Panel();
            this.Ground = new System.Windows.Forms.Panel();
            this.Nakov = new System.Windows.Forms.PictureBox();
            this.PlayerMovement = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesCreation = new System.Windows.Forms.Timer(this.components);
            this.ObstaclesMovement = new System.Windows.Forms.Timer(this.components);
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).BeginInit();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.Ground);
            this.Screen.Controls.Add(this.Nakov);
            this.Screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Screen.Location = new System.Drawing.Point(0, 0);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(449, 262);
            this.Screen.TabIndex = 0;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Ground.Location = new System.Drawing.Point(0, 249);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(448, 12);
            this.Ground.TabIndex = 1;
            this.Ground.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Nakov
            // 
            this.Nakov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Nakov.Location = new System.Drawing.Point(12, 224);
            this.Nakov.Name = "Nakov";
            this.Nakov.Size = new System.Drawing.Size(25, 25);
            this.Nakov.TabIndex = 0;
            this.Nakov.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 262);
            this.Controls.Add(this.Screen);
            this.Name = "Form1";
            this.Text = "WhereIsMyBeer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nakov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.PictureBox Nakov;
        private System.Windows.Forms.Timer PlayerMovement;
        private System.Windows.Forms.Panel Ground;
        private System.Windows.Forms.Timer ObstaclesCreation;
        private System.Windows.Forms.Timer ObstaclesMovement;
    }
}

