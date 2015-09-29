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
            this.screen = new System.Windows.Forms.Panel();
            this.student = new System.Windows.Forms.Panel();
            this.graund = new System.Windows.Forms.Panel();
            this.nakov = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.bigObject = new System.Windows.Forms.Panel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nakov)).BeginInit();
            this.SuspendLayout();
            // 
            // screen
            // 
            this.screen.Controls.Add(this.bigObject);
            this.screen.Controls.Add(this.student);
            this.screen.Controls.Add(this.graund);
            this.screen.Controls.Add(this.nakov);
            this.screen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screen.Location = new System.Drawing.Point(0, 0);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(448, 262);
            this.screen.TabIndex = 0;
            // 
            // student
            // 
            this.student.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.student.Location = new System.Drawing.Point(209, 224);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(25, 25);
            this.student.TabIndex = 2;
            this.student.Paint += new System.Windows.Forms.PaintEventHandler(this.student_Paint);
            // 
            // graund
            // 
            this.graund.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.graund.Location = new System.Drawing.Point(0, 249);
            this.graund.Name = "graund";
            this.graund.Size = new System.Drawing.Size(448, 12);
            this.graund.TabIndex = 1;
            this.graund.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nakov
            // 
            this.nakov.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nakov.Location = new System.Drawing.Point(12, 224);
            this.nakov.Name = "nakov";
            this.nakov.Size = new System.Drawing.Size(25, 25);
            this.nakov.TabIndex = 0;
            this.nakov.TabStop = false;
            this.nakov.Click += new System.EventHandler(this.nakov_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // bigObject
            // 
            this.bigObject.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bigObject.Location = new System.Drawing.Point(411, 200);
            this.bigObject.Name = "bigObject";
            this.bigObject.Size = new System.Drawing.Size(25, 50);
            this.bigObject.TabIndex = 3;
            this.bigObject.Paint += new System.Windows.Forms.PaintEventHandler(this.bigObject_Paint);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 262);
            this.Controls.Add(this.screen);
            this.Name = "Form1";
            this.Text = "WhereIsMyBeer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.screen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nakov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox nakov;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel graund;
        private System.Windows.Forms.Panel student;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel bigObject;
        private System.Windows.Forms.Timer timer3;
    }
}

