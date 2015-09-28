using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random randomObstacleTop = new Random();
            PictureBox obstacle = new PictureBox();
            obstacle.BackColor = Color.Red;
            obstacle.Location = new System.Drawing.Point(270, randomObstacleTop.Next(50, 280));
            obstacle.Size = new System.Drawing.Size(25, 25);
            obstacle.Show();
        }
    }
}
