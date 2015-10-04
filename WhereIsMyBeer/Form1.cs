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
        int g = 25;
        int force;
        int indexObstacles = 0;
        int indexColdBeers = 0;
        public static int score = 0;
        Random randomLocation = new Random();
        Random randomSize = new Random();
        Random randomInterval = new Random();
        PictureBox obstacle = new PictureBox();
        List<PictureBox> obstacles = new List<PictureBox>();
        PictureBox coldBeer = new PictureBox();
        List<PictureBox> coldBeers = new List<PictureBox>();

        private int nakovAnim = 1;

        PictureBox life = new PictureBox();
        Stack<PictureBox> lives = new Stack<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            Beer_O_Meter.Maximum = 110;
            Beer_O_Meter.Value = 10;
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
                    if (Beer_O_Meter.Value > 0)
                    {
                        Beer_O_Meter.Value -= 1;
                    } 
                    if (Beer_O_Meter.Value == 0)
                    {
                        Screen.Controls.Remove(lives.Pop());
                        if (lives.Count == 0)
                        {
                            Hide();
                            Form2 form2 = new Form2();
                            form2.ShowDialog();
                            Dispose();
                        }
                    }
                }
            }
        }

        private void PlayerMovement_Tick(object sender, EventArgs e)
        {
            //Falling after jump
            if (jump == true)
            {
                NakovCharacter.Top -= force;
                force -= 2;
            }
            //Stops fall if player hits ground
            //else keeps player falling
            if (NakovCharacter.Top + NakovCharacter.Height + Ground.Height >= Screen.Height)
            {
                NakovCharacter.Top = Screen.Height - NakovCharacter.Height - Ground.Height;
                jump = false;
            }
            else
            {
                NakovCharacter.Top += 1;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ObstaclesCreation_Tick(object sender, EventArgs e)
        {
            //Creates a random sized obstacle at ground level outside the visible part of the screen

            obstacle = new PictureBox();
            obstacle.BackgroundImage = WhereIsMyBeer.Properties.Resources.barrel;
            obstacle.BackgroundImageLayout = ImageLayout.Stretch;
            obstacles.Add(obstacle);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();

            obstacles[indexObstacles].BackColor = Color.Red;

            obstacles[indexObstacles].Height = randomSize.Next(10, 40);

            obstacles[indexObstacles].Width = randomSize.Next(10, 40);
            obstacles[indexObstacles].Top = 429 - obstacles[indexObstacles].Height;
            obstacles[indexObstacles].Left = 700;
            Screen.Controls.Add(obstacles[indexObstacles]);
            ObstaclesCreation.Interval = randomInterval.Next(1000, 5000);
            indexObstacles++;
        }

        private void ObstaclesMovement_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < obstacles.Count; j++)
            {
                if (lives.Count > 0)
                {
                    obstacles[j].Left -= 5;
                    if (NakovCharacter.Location.X + NakovCharacter.Width - 5 >= obstacles[j].Location.X && NakovCharacter.Location.X <= obstacles[j].Location.X + obstacles[j].Width && NakovCharacter.Location.Y + NakovCharacter.Height >= obstacles[j].Location.Y)
                    {
                        Screen.Controls.Remove(obstacles[j]);
                        obstacles.RemoveAt(j);
                        indexObstacles--;
                        j--;
                        Screen.Controls.Remove(lives.Pop());
                        if (lives.Count == 0)
                        {
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
            //Create lives' pictureboxes
            life = new PictureBox();
            for (int i = 0; i < 3; i++)
            {
                life = new PictureBox();
                life.BackgroundImage = WhereIsMyBeer.Properties.Resources.liver;
                life.BackgroundImageLayout = ImageLayout.Stretch;
                life.Height = 16;
                life.Width = 32;
                life.Top = 20;
                life.Left = 10 + (i * 32);
                lives.Push(life);
                Screen.Controls.Add(lives.Peek());
            }

            //Creates the initial obstacle
            obstacle = new PictureBox();
            obstacle.BackgroundImage = WhereIsMyBeer.Properties.Resources.barrel;
            obstacle.BackgroundImageLayout = ImageLayout.Stretch;

            obstacles.Add(obstacle);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();

            obstacles[indexObstacles].BackColor = Color.Red;
            obstacles[indexObstacles].Height = randomSize.Next(10, 40);
            randomSize = new Random();
            obstacles[indexObstacles].Width = randomSize.Next(10, 40);
            obstacles[indexObstacles].Top = 429 - obstacles[indexObstacles].Height;
            obstacles[indexObstacles].Left = 650;

            Screen.Controls.Add(obstacles[indexObstacles]);
            indexObstacles++;

            //Creates the initial coldBeer
            coldBeer = new PictureBox();
            coldBeers.Add(coldBeer);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();
            coldBeers[indexColdBeers].BackColor = Color.Green;
            coldBeers[indexColdBeers].Height = 20;
            randomSize = new Random();
            coldBeers[indexColdBeers].Width = 10;
            coldBeers[indexColdBeers].Top = 429 - coldBeers[indexColdBeers].Height;
            coldBeers[indexColdBeers].Left = 650;
            Screen.Controls.Add(coldBeers[indexColdBeers]);
            indexColdBeers++;
        }


        private void ColdBeersCreation_Tick(object sender, EventArgs e)
        {

            // Creates a random sized cold beer at ground level outside the visible part of the screen

            coldBeer = new PictureBox();
            coldBeers.Add(coldBeer);

            randomInterval = new Random();
            randomLocation = new Random();
            randomSize = new Random();

            coldBeers[indexColdBeers].BackColor = Color.Green;
            coldBeers[indexColdBeers].Height = 20;
            coldBeers[indexColdBeers].Width = 10;
            coldBeers[indexColdBeers].Top = 429 - coldBeers[indexColdBeers].Height;
            coldBeers[indexColdBeers].Left = 700;
            Screen.Controls.Add(coldBeers[indexColdBeers]);
            ColdBeersCreation.Interval = randomInterval.Next(1000, 5000);
            indexColdBeers++;

        }

        private void ColdBeersMovement_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < coldBeers.Count; j++)
            {
                if (lives.Count > 0)
                {
                    coldBeers[j].Left -= 5;
                    if (NakovCharacter.Location.X + NakovCharacter.Width - 5 >= coldBeers[j].Location.X && NakovCharacter.Location.X <= coldBeers[j].Location.X + coldBeers[j].Width && NakovCharacter.Location.Y + NakovCharacter.Height >= coldBeers[j].Location.Y)
                    {
                        Screen.Controls.Remove(coldBeers[j]);
                        coldBeers.RemoveAt(j);
                        indexColdBeers--;
                        score += 1;
                        if (Beer_O_Meter.Value < 95)
                        {
                            Beer_O_Meter.Value += 5;
                        }
                        else
                        {
                            Beer_O_Meter.Value = 100;
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void WalkAnimation_Tick(object sender, EventArgs e)
        {
            switch (nakovAnim)
            {
                case 1:
                    NakovCharacter.Image = WhereIsMyBeer.Properties.Resources.Nakov1;
                    break;
                case 2:
                    NakovCharacter.Image = WhereIsMyBeer.Properties.Resources.Nakov2;
                    break;
                case 3:
                    NakovCharacter.Image = WhereIsMyBeer.Properties.Resources.Nakov3;
                    break;
                case 4:
                    NakovCharacter.Image = WhereIsMyBeer.Properties.Resources.Nakov4;
                    break;
                default:
                    break;
            }
            if (nakovAnim == 4)
            {
                nakovAnim = 1;
            }
            else
            {
                nakovAnim++;
            }
        }

        private void ScoreTimer_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            label3.Text = score.ToString();
            label3.Visible = true;
        }
    }
}
