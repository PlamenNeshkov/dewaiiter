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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (Form1.score < Form1.highScore)
            {
                FinalScore.Text = Form1.score.ToString();
                label3.Text = Form1.highScore.ToString();
                label1.Left = 320 - (label1.Width / 2) - (FinalScore.Width / 2) - 10;
                label2.Left = 320 - (label2.Width / 2) - (label3.Width / 2) - 10;
                label3.Left = label2.Left + label2.Width + 10;
                FinalScore.Left = label1.Left + label1.Width + 10;
                Form1.score = 0;
            }
            else
            {
                FinalScore.Text = "";
                label1.Text = "Congratulations!";
                label1.Left = 320 - (label1.Width / 2) - (FinalScore.Width / 2);
                label2.Text = "Your new High Score is";
                label2.Left = 320 - (label2.Width / 2) - (label3.Width / 2) - 10;
                label3.Text = Form1.score.ToString();
                label3.Left = label2.Left + label2.Width + 10;
                Form1.score = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Dispose();
        }
    }
}
