using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WhereIsMyBeer
{
    public partial class Form1 : Form
    {
        private int g = 25;
        private int force;
        private int indexObstacles = 0;
        private int indexColdBeers = 0;
        private int nakovAnim = 1;
        public static int score = 0;
        public static int highScore = 0;

        private bool hasSuperPower = false;
        private bool jump;

        private Random randomLocation = new Random();
        private Random randomInterval = new Random();

        private List<PictureBox> obstacles = new List<PictureBox>();
        private List<PictureBox> coldBeers = new List<PictureBox>();

        private PictureBox obstacle = new PictureBox();
        private PictureBox coldBeer = new PictureBox();
        private PictureBox life = new PictureBox();

        private Stack<PictureBox> lives = new Stack<PictureBox>();

        private string highScorePath = "highScore.txt";

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();


        public Form1()
        {
            InitializeComponent();
            Beer_O_Meter.Maximum = 65;
            Beer_O_Meter.Value = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read highsore
            if (File.Exists(highScorePath))
            {
                highScoreLbl.Text = File.ReadAllText(highScorePath);
            }

            //Create lives' pictureboxes
            life = new PictureBox();
            for (int i = 0; i < 3; i++)
            {
                life = new PictureBox();
                life.BackgroundImage = WhereIsMyBeer.Properties.Resources.heart;
                life.BackgroundImageLayout = ImageLayout.Stretch;
                life.Height = 20;
                life.Width = 30;
                life.Top = 20;
                life.Left = 10 + (i*35);
                lives.Push(life);
                Screen.Controls.Add(lives.Peek());
            }

            //Creates the initial obstacle
            
            ObstacleCreationFunction();

            //Creates the initial coldBeer

            ColdBeerCreationFunction();

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

        private void ObstaclesCreation_Tick(object sender, EventArgs e)
        {
            ObstacleCreationFunction();
            ObstaclesCreation.Interval = randomInterval.Next(1000, 5000);
        }

        private void ObstaclesMovement_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < obstacles.Count; j++)
            {
                if (lives.Count > 0)
                {
                    obstacles[j].Left -= 8;
                    if (NakovCharacter.Location.X + NakovCharacter.Width - 5 >= obstacles[j].Location.X &&
                        NakovCharacter.Location.X <= obstacles[j].Location.X + obstacles[j].Width &&
                        NakovCharacter.Location.Y + NakovCharacter.Height >= obstacles[j].Location.Y)
                    {
                        Screen.Controls.Remove(obstacles[j]);
                        obstacles.RemoveAt(j);
                        indexObstacles--;
                        j--;
                        if (hasSuperPower == false)
                        {
                            Screen.Controls.Remove(lives.Pop());
                        }
                        if (lives.Count == 0)
                        {
                            GameOver();
                        }
                    }
                    else if (obstacles[j].Left < -obstacles[j].Width)
                    {
                        Screen.Controls.Remove(obstacles[j]);
                        obstacles.RemoveAt(j);
                        indexObstacles--;
                        j--;
                    }
                }
            }
        }

        private void ColdBeersCreation_Tick(object sender, EventArgs e)
        {
            // Creates a random sized cold beer at ground level outside the visible part of the screen
            ColdBeerCreationFunction();
            ColdBeersCreation.Interval = randomInterval.Next(1000, 5000);
        }

        private async void ColdBeersMovement_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < coldBeers.Count; j++)
            {
                if (lives.Count > 0)
                {
                    coldBeers[j].Left -= 8;
                    if (NakovCharacter.Location.X + NakovCharacter.Width - 5 >= coldBeers[j].Location.X &&
                        NakovCharacter.Location.X <= coldBeers[j].Location.X + coldBeers[j].Width &&
                        NakovCharacter.Location.Y + NakovCharacter.Height >= coldBeers[j].Location.Y)
                    {
                        Screen.Controls.Remove(coldBeers[j]);
                        coldBeers.RemoveAt(j);
                        indexColdBeers--;
                        score += 1;
                        if (Beer_O_Meter.Value < 60)
                        {
                            Beer_O_Meter.Value += 5;
                        }
                        else
                        {
                            score += 20;
                            hasSuperPower = true;
                            player.SoundLocation = "beer.wav";
                            player.Play();
                            Beer_O_Meter.Value = 5;
                            await Task.Delay(20000);
                            hasSuperPower = false;
                        }
                    }
                    else if (coldBeers[j].Left < -coldBeers[j].Width)
                    {
                        Screen.Controls.Remove(coldBeers[j]);
                        coldBeers.RemoveAt(j);
                        indexColdBeers--;
                        j--;
                    }
                }
            }
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
            // Print score
            label3.Visible = false;
            label3.Text = score.ToString();
            label3.Visible = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Create jump and double jump
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
                            GameOver();
                        }
                    }
                }
            }
            // Create Pause
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.P)
            {
                PauseScreenFunction(true);
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PauseScreenFunction(false);
                }
            }
        }

        private void GameOver()
        {
            if (!File.Exists(highScorePath))
            {
                File.WriteAllText(highScorePath, "0");
            }

            highScore = int.Parse(File.ReadAllText(highScorePath));

            if (score > highScore)
            {
                File.WriteAllText(highScorePath, Convert.ToString(score));
            }

            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Dispose();
        }

        private void PauseScreenFunction(bool isOnPause)
        {
            PauseScreen.BringToFront();
            PauseScreen.Visible = isOnPause;
            PauseLbl.Visible = isOnPause;
            InstructionsLbl.Visible = isOnPause;
            PauseScreen.Enabled = isOnPause;
            PauseLbl.Enabled = isOnPause;
            InstructionsLbl.Enabled = isOnPause;
            if (isOnPause)
            {
                ObstaclesCreation.Stop();
                ObstaclesMovement.Stop();
                ColdBeersCreation.Stop();
                ColdBeersMovement.Stop();
                PlayerMovement.Stop();
                WalkAnimation.Stop();
                ScoreTimer.Stop();
                player.Stop();
            }
            else
            {
                ObstaclesCreation.Start();
                ObstaclesMovement.Start();
                ColdBeersCreation.Start();
                ColdBeersMovement.Start();
                PlayerMovement.Start();
                WalkAnimation.Start();
                ScoreTimer.Start();
            }
        }

        private void ObstacleCreationFunction()
        {
            //Creates a random sized obstacle at ground level outside the visible part of the screen

            obstacle = new PictureBox();
            Random obstaclesPicture = new Random();
            int obstaclesPictureNumber = obstaclesPicture.Next(1, 3);
            switch (obstaclesPictureNumber)
            {
                case 1:
                    obstacle.BackgroundImage = WhereIsMyBeer.Properties.Resources.Student;
                    obstacle.Height = 70;
                    obstacle.Width = 60;
                    break;
                case 2:
                    obstacle.BackgroundImage = WhereIsMyBeer.Properties.Resources.Desk;
                    obstacle.Height = 40;
                    obstacle.Width = 60;
                    break;
                default:
                    break;
            }
            obstacle.BackgroundImageLayout = ImageLayout.Stretch;

            randomInterval = new Random();

            obstacle.Top = 429 - obstacle.Height;
            obstacle.Left = 700;

            obstacles.Add(obstacle);
            Screen.Controls.Add(obstacles[indexObstacles]);

            indexObstacles++;
        }

        private void ColdBeerCreationFunction()
        {
            coldBeer = new PictureBox();

            randomInterval = new Random();

            coldBeer.BackgroundImage = WhereIsMyBeer.Properties.Resources.Beer;
            coldBeer.BackgroundImageLayout = ImageLayout.Stretch;
            coldBeer.Height = 23;
            coldBeer.Width = 11;
            coldBeer.Top = 429 - coldBeer.Height;
            coldBeer.Left = 650;
            for (int i = 0; i < obstacles.Count; i++)
            {
                while (coldBeer.Left <= obstacles[i].Left + 70 && coldBeer.Left >= obstacles[i].Left - 70)
                {
                    coldBeer.Left = obstacles[i].Left + new Random().Next(71, 160);
                }
            }

            coldBeers.Add(coldBeer);
            Screen.Controls.Add(coldBeer);

            indexColdBeers++;
        }
    }
}