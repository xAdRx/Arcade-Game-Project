using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CometShooter
{
    public partial class Form1 : Form
    {
        int speed = 8;
        int gravity = 9;
        int points = 0;
        public Form1()
        {
            InitializeComponent();
            Obstacle01.Left = 1100;
            Obstacle02.Left = 1700;
        }

        private void JumpTime(object sender, EventArgs e)
        {
            Protagonist.Top += gravity;
            Obstacle01.Left -= speed;
            Obstacle02.Left -= speed;
            Points.Text = "Score: " + points;
            if (Obstacle01.Left == 100 || Obstacle02.Left == 100)
            {
                points++;
            }
            if (Obstacle01.Left < -300)
            {
                Obstacle01.Left = 1300;
            }
            if (Obstacle02.Left < -300 && Obstacle01.Left < 900 && Obstacle01.Left > 150)
            {
                Obstacle02.Left = 1500;
            }
            else if (Obstacle02.Left < -300 && Obstacle01.Left >= 900 && Obstacle01.Left <= 150)
            {
                Obstacle02.Left = 1900;
            }
            if (Protagonist.Bounds.IntersectsWith(Obstacle01.Bounds) || Protagonist.Bounds.IntersectsWith(Obstacle02.Bounds))
                    { UrDed(); }
        }
    private void Press(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = -9;
            }
        }

        private void Release(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 9;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Points_Click(object sender, EventArgs e)
        {

        }
        private void UrDed()
        {
            Timer.Stop();
            Points.Text += " - YOU DIED";
        }
    }
}
