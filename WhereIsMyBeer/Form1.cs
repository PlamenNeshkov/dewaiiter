using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhereIsMyBeer
{
    public partial class Form1 : Form
    {
        bool jump;
        int g = 20;
        int force;
        int indexObstacles = 0;
        Random randomLocation = new Random();
        Random randomSize = new Random();
        Random randomInterval = new Random();
        PictureBox obstacle = new PictureBox();
        List<PictureBox> obstacles = new List<PictureBox>();


        public Form1()
        {
            InitializeComponent();
            Beer_O_Meter.Maximum = 100;
            Beer_O_Meter.Value = 50;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (jump != true)
            {
                if (e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = g;
                }
                if (e.Modifiers == Keys.Shift && e.KeyCode == Keys.Space)
                {
                    jump = true;
                    force = g + 5;
                    Beer_O_Meter.Value -= 1;
                    if (Beer_O_Meter.Value == 0)
                    {
                        Beer_O_Meter.Value = 0;
                        Hide();
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        Dispose();
                    }
                }
            }
        }

        private void PlayerMovement_Tick(object sender, EventArgs e)
        {
            //Falling after jump
            if (jump == true)
            {
                Nakov.Top -= force;
                force -= 2;
            }
            //Stops fall if player hits ground
            //else keeps player falling
            if (Nakov.Top + Nakov.Height + Ground.Height >= Screen.Height)
            {
                Nakov.Top = Screen.Height - Nakov.Height - Ground.Height;
                jump = false;
            }
            else
            {
                Nakov.Top += 1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ObstaclesCreation_Tick(object sender, EventArgs e)
        {
            //Creates a random sized obstacle at ground level outside the visible part of the screen
            //

            obstacle = new PictureBox();
            obstacles.Add(obstacle);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();

            obstacles[indexObstacles].BackColor = Color.Red;

            obstacles[indexObstacles].Height = randomSize.Next(10, 50);

            obstacles[indexObstacles].Width = randomSize.Next(10, 50);
            obstacles[indexObstacles].Top = 249 - obstacles[indexObstacles].Height;
            obstacles[indexObstacles].Left = 450;
            Screen.Controls.Add(obstacles[indexObstacles]);
            ObstaclesCreation.Interval = randomInterval.Next(1000, 5000);
            indexObstacles++;
        }

        private void ObstaclesMovement_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < obstacles.Count; j++)
            {
                if (Beer_O_Meter.Value > 0)
                {
                    obstacles[j].Left -= 5;
                    if (Nakov.Location.X + Nakov.Width - 5 >= obstacles[j].Location.X && Nakov.Location.X <= obstacles[j].Location.X + obstacles[j].Width && Nakov.Location.Y + Nakov.Height >= obstacles[j].Location.Y)
                    {
                        Screen.Controls.Remove(obstacles[j]);
                        obstacles.RemoveAt(j);
                        indexObstacles--;
                        j--;
                        if (Beer_O_Meter.Value > 5)
                        {
                            Beer_O_Meter.Value -= 5;
                        }
                        else
                        {
                            Beer_O_Meter.Value = 0;
                            Hide();
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                            Dispose();
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates the initial obstacle
            obstacle = new PictureBox();
            obstacles.Add(obstacle);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();

            obstacles[indexObstacles].BackColor = Color.Red;
            obstacles[indexObstacles].Height = randomSize.Next(10, 35);
            randomSize = new Random();
            obstacles[indexObstacles].Width = randomSize.Next(10, 35);
            obstacles[indexObstacles].Top = 249 - obstacles[indexObstacles].Height;
            obstacles[indexObstacles].Left = 450;
            Screen.Controls.Add(obstacles[indexObstacles]);
            indexObstacles++;
        }
    }
}
