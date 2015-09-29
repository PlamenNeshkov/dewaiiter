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
        int g = 21;
        int force;

        public Form1()
        {
            InitializeComponent();
        }

        private void nakov_Click(object sender, EventArgs e)
        {

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
                    force = g + 4;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (jump == true)
            {
                nakov.Top -= force;
                force -= 1;
            }
            if (nakov.Top + nakov.Height + graund.Height >= screen.Height)
            {
                nakov.Top = screen.Height - nakov.Height - graund.Height;
                jump = false;
            }
            else
            {
                nakov.Top += 5;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
