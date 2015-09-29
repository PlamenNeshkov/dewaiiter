using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nakoholic
{
    public partial class Form1 : Form
    {
        bool hasJumped;
        int force, gravitationalForce = 25;
        PictureBox obstacle = new PictureBox();
        Random obstacleLocationHeight = new Random();
     

        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Falling when already jumped
            if (hasJumped == true)
            {
                Player.Top -= force;
                force -= 1;
            }

            // Stops fall when player hits floor
            // else player keeps falling
            if (Player.Top + Player.Height >= Floor.Top && Player.Top < Floor.Top)
            {
                Player.Top = Screen.Height - Player.Height - Floor.Height;
                hasJumped = false;
                force = 0;
            }
            else
            {
                Player.Top += 8;
            }
            // makes sure player doesn't pass trough floor

        }

        private void Form1_KeyDown(object sender, KeyEventArgs buttonPressed)
        {
            if (hasJumped != true)
            {
                if (buttonPressed.KeyCode == Keys.Up)
                {
                    hasJumped = true;
                    force = gravitationalForce;
                }
            }
        }

        private void ObstaclesSpawningTimer_Tick_1(object sender, EventArgs e)
        {
            obstacleLocationHeight = new Random();
            obstacle = new PictureBox();
            obstacle.Height = 30;
            obstacle.Width = 30;
            obstacle.BackColor = Color.Red;
            obstacle.Left = 200;
            obstacle.Top = obstacleLocationHeight.Next(200, 247);
            Screen.Controls.Add(obstacle);
        }

        private void ObstacleMovement_Tick(object sender, EventArgs e)
        {
            obstacle.Left -= 5;
        }



    }
}