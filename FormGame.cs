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
    public partial class FormGame : Form
    {
        int speed = 8;
        double gravity = 0;
        int points = 0;
        public FormGame()
        {
            InitializeComponent();
            Obstacle01.Left = 1100;
            Obstacle02.Left = 1900;
            Meteor1.Left = 2132;
            Meteor2.Left = 3210;
            Meteor3.Left = 4312;
            Meteor4.Left = 2314;
            ProjHit.Left = 4000;
            ShipExplode.Left = 4000;
            Projectile.Visible = false;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Protagonist.Image = CometShooter.FormMainMenu.skin;
                       Projectile.Parent = pictureBox1;
            //          Protagonist.Parent = Background;
            //          Obstacle01.Parent = Background;
            //          Obstacle02.Parent = Background;
            //          Meteor1.Parent = Background;
            //          Meteor2.Parent = Background;
            //          Meteor3.Parent = Background;
            //          Meteor4.Parent = Background;
            //          Points.Parent = Background;
        }

        private void JumpTime(object sender, EventArgs e)
        {
            gravity = gravity / 1.05;
            Protagonist.Top += (int)gravity;
            Obstacle01.Left -= speed;
            Obstacle02.Left -= speed;
            Meteor1.Left -= speed;
            Meteor2.Left -= speed;
            Meteor3.Left -= speed;
            Meteor4.Left -= speed;
            Points.Text = "Score: " + points;
            if (Obstacle01.Left == 100 || Obstacle02.Left == 100)
            {
                points++;
                speed++;
            }
            if (Obstacle01.Left < -300)
            {
                Obstacle01.Left = 2300;
                points++;
                speed++;
            }
            if (Obstacle02.Left < -300 && Obstacle01.Left < 900 && Obstacle01.Left > 150)
            {
                Obstacle02.Left = 1700;
                points++;
            }
            else if (Obstacle02.Left < -300 && Obstacle01.Left >= 900 && Obstacle01.Left <= 150)
            {
                Obstacle02.Left = 2700;
            }
            if (Meteor1.Left < -300 || Meteor1.Bounds.IntersectsWith(Obstacle02.Bounds))
            {
                Meteor1.Left = 1813;
            }
            if (Meteor2.Left < -300)
            {
                Meteor2.Left = 2113;
            }
            if (Meteor3.Left < -300 || Meteor3.Bounds.IntersectsWith(Obstacle01.Bounds))
            {
                Meteor3.Left = 2313;
            }
            if (Meteor4.Left < -300 || Meteor4.Bounds.IntersectsWith(Obstacle01.Bounds))
            {
                Meteor4.Left = 2513;
            }
            if (Projectile.Visible == true)
            {
                Projectile.Left += 30;
                if (Projectile.Bounds.IntersectsWith(Obstacle01.Bounds) || Projectile.Bounds.IntersectsWith(Obstacle02.Bounds) ||
                    Projectile.Bounds.IntersectsWith(Meteor1.Bounds) || Projectile.Bounds.IntersectsWith(Meteor2.Bounds) ||
                    Projectile.Bounds.IntersectsWith(Meteor3.Bounds) || Projectile.Bounds.IntersectsWith(Meteor4.Bounds))
                { Projectile.Visible = false; ProjectileHit(); }
                if (Projectile.Bounds.IntersectsWith(Meteor1.Bounds))
                { Projectile.Visible = false; Meteor1.Left = 2313; ProjectileHit(); }
                if (Projectile.Bounds.IntersectsWith(Meteor2.Bounds))
                { Projectile.Visible = false; Meteor2.Left = 2513; ProjectileHit(); }
                if (Projectile.Bounds.IntersectsWith(Meteor3.Bounds))
                { Projectile.Visible = false; Meteor3.Left = 1913; ProjectileHit(); }
                if (Projectile.Bounds.IntersectsWith(Meteor4.Bounds))
                { Projectile.Visible = false; Meteor4.Left = 2113; ProjectileHit(); }
                if (Projectile.Left > 1900) { Projectile.Visible = false; }
                if (Projectile.Right > 1900) { Projectile.Visible = false; }
            }
            if (Protagonist.Bounds.IntersectsWith(Obstacle01.Bounds) || Protagonist.Bounds.IntersectsWith(Obstacle02.Bounds) || Protagonist.Top > 850 || Protagonist.Top < -70)
            { UrDed(); }
            if (Protagonist.Bounds.IntersectsWith(Meteor1.Bounds)) { UrDed(); Meteor1.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor2.Bounds)) { UrDed(); Meteor2.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor3.Bounds)) { UrDed(); Meteor3.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor4.Bounds)) { UrDed(); Meteor4.Left = 2000; }
        }
        private void Press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                gravity -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                gravity += 10;
            }
            if (e.KeyCode == Keys.Space && Projectile.Visible == false)
            {
                Fire();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Timer.Stop();
                this.Close();
            }
        }

        private void Release(object sender, KeyEventArgs e)
        {
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
            //            Protagonist.Image = Properties.Resources.PlayerDed;
            ShipExplode.Left = Protagonist.Left -70;
            ShipExplode.Top = Protagonist.Top - 90;
            ShipExplode.Image = Properties.Resources.Explosion;
        }
        private void Fire()
        {
            Projectile.Visible = true;
            Projectile.Top = Protagonist.Top + 60;
            Projectile.Left = 220;
        }
        private void ProjectileHit()
        {
            ProjHit.Left = Projectile.Left + 40;
            ProjHit.Top = Projectile.Top -50;
            ProjHit.Image = Properties.Resources.ProjectileHitAnimatedHQ;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
