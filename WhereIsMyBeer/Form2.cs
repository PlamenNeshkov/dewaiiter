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
            FinalScore.Text = Form1.score.ToString();
            Form1.score = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {    
            Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            Dispose();
        }

        private void FinalScore_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
