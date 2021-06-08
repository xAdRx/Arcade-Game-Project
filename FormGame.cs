using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace CometShooter
{
    public partial class FormGame : Form
    {
        SoundPlayer SNDengine = new SoundPlayer(@"..\..\..\Resources\engine.wav");
        SoundPlayer SNDLaser = new SoundPlayer(@"..\..\..\Resources\Laser_2.wav");
        SoundPlayer SNDexplode = new SoundPlayer(@"..\..\..\Resources\Explosion_1.wav");
        SoundPlayer SNDmeteor = new SoundPlayer(@"..\..\..\Resources\meteor_destruction.wav");
        SoundPlayer menumusic = new SoundPlayer(@"..\..\..\Resources\muzyka.wav");
        int speed = 8;
        double gravity = 0;
        int points = 0;
        bool bossfight;
        bool cutscene;
        bool bossUp = true;
        bool bossDown = false;
        int ZillaHealth = 3;
        int AttackPhase = 0;
        public FormGame()
        {
            menumusic.Stop();
       //   SNDengine.PlayLooping();
            bossfight = false;
            cutscene = false;
            InitializeComponent();
            Bosshealth.Visible = false;
            winner.Visible = false;
            Nickname.Visible = false;
            button1.Visible = false;
            Obstacle01.Left = 1100;
            Obstacle02.Left = 1900;
            Meteor1.Left = 2132;
            Meteor2.Left = 3210;
            Meteor3.Left = 4312;
            Meteor4.Left = 2314;
            ProjHit.Left = 4000;
            MechaBossZilla.Left = 6000;
            Beam.Top = 4000;
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

            if (points>1) { bossfight = true; }   // DO USTALENIA KIEDY JEST BOSSFIGHT ----------------------------------------------------------

            if (cutscene == true && MechaBossZilla.Left > 1100)
            { MechaBossZilla.Left-=speed; }
            if (Obstacle01.Left == 100 || Obstacle02.Left == 100)
            {
                points++;
                speed++;
            }
            if (Obstacle01.Left < -300 && bossfight == false)
            {
                Obstacle01.Left = 2300;
                points++;
                speed++;
            }
            if (Obstacle02.Left < -300 && Obstacle01.Left < 900 && Obstacle01.Left > 150 && bossfight == false)
            {
                Obstacle02.Left = 1700;
                points++;
            }
            else if (Obstacle02.Left < -300 && Obstacle01.Left >= 900 && Obstacle01.Left <= 150 && bossfight == false)
            {
                Obstacle02.Left = 2700;
            }
            if (Meteor1.Left < -300 && bossfight == false || Meteor1.Bounds.IntersectsWith(Obstacle02.Bounds))
            {
                Meteor1.Left = 1813;
            }
            if (Meteor2.Left < -300 && bossfight == false)
            {
                Meteor2.Left = 2113;
            }
            if (Meteor3.Left < -300 && bossfight == false || Meteor3.Bounds.IntersectsWith(Obstacle01.Bounds))
            {
                Meteor3.Left = 2313;
            }
            if (Meteor4.Left < -300 && bossfight == false || Meteor4.Bounds.IntersectsWith(Obstacle01.Bounds))
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
                { Projectile.Visible = false; ProjectileHit(); SNDmeteor.Play();
                    if (bossfight == false) { Meteor1.Left = 2313; }
                     else { Meteor1.Left = -2000; }
                }
                if (Projectile.Bounds.IntersectsWith(Meteor2.Bounds))
                { Projectile.Visible = false; ProjectileHit(); SNDmeteor.Play();
                    if (bossfight == false) { Meteor2.Left = 2513; }
                    else { Meteor2.Left = -2000; }
                }
                if (Projectile.Bounds.IntersectsWith(Meteor3.Bounds))
                { Projectile.Visible = false; ProjectileHit(); SNDmeteor.Play();
                    if (bossfight == false) { Meteor3.Left = 1913; }
                    else { Meteor3.Left = -2000; }
                }
                if (Projectile.Bounds.IntersectsWith(Meteor4.Bounds))
                { Projectile.Visible = false; ProjectileHit(); SNDmeteor.Play();
                    if (bossfight == false) { Meteor4.Left = 2113; }
                    else { Meteor4.Left = -2000; }
                }
                if (Projectile.Left > 1900) { Projectile.Visible = false; }
                if (Projectile.Right > 1900) { Projectile.Visible = false; }
                if (MechaBossZilla.Left < 1100 && Projectile.Bounds.IntersectsWith(MechaBossZilla.Bounds))
                    { Projectile.Visible = false; ProjectileHit(); ZillaHealth--; SNDmeteor.Play(); }
            }
            if (Protagonist.Bounds.IntersectsWith(Obstacle01.Bounds) || Protagonist.Bounds.IntersectsWith(Obstacle02.Bounds) || Protagonist.Top > 850 || Protagonist.Top < -70 || Protagonist.Bounds.IntersectsWith(Beam.Bounds))
            { UrDed(); }
            if (Protagonist.Bounds.IntersectsWith(Meteor1.Bounds)) { UrDed(); Meteor1.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor2.Bounds)) { UrDed(); Meteor2.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor3.Bounds)) { UrDed(); Meteor3.Left = 2000; }
            if (Protagonist.Bounds.IntersectsWith(Meteor4.Bounds)) { UrDed(); Meteor4.Left = 2000; }
            if (Obstacle01.Left < -1400 && cutscene == false && MechaBossZilla.Left > 1100) { cutscene = true; MechaBossZilla.Left = 1800; speed = 6; }
            if (MechaBossZilla.Left < 1100 && MechaBossZilla.Left > 0)
            {
                Bosshealth.Visible = true;
                Bosshealth.Text = "Health: " + ZillaHealth;
                BossMovement();
                BossAttack();
            }
            if (ZillaHealth == 0) { BossIsDead(); }
            if (ZillaHealth < 0 && Obstacle01.Left < -1400)
            {
                winner.Visible = true;
                Nickname.Visible = true;
                button1.Visible = true;
            }
            if (ZillaHealth < 0 && Obstacle01.Left < -1800)
            {
                Timer.Stop();
                SNDengine.Stop();
            }
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
                SNDengine.Stop();
                Timer.Stop();
                menumusic.PlayLooping();
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
            SNDengine.Stop();
            SNDexplode.Play();
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
            Projectile.Top = Protagonist.Top + 80;
            Projectile.Left = 220;
            SNDLaser.Play();
        }
        private void ProjectileHit()
        {
            ProjHit.Left = Projectile.Left + 40;
            ProjHit.Top = Projectile.Top -50;
            ProjHit.Image = Properties.Resources.ProjectileHitAnimatedHQ;
        }
        private void BossMovement()
        {
            if(bossUp==true) { MechaBossZilla.Top -= speed; }
            if (bossDown == true) { MechaBossZilla.Top += speed; }
            if(MechaBossZilla.Top<-140) { bossUp = false; bossDown = true; }
            if (MechaBossZilla.Top > 600) { bossUp = true; bossDown = false; }
        }
        private void BossAttack()
        {
            if(AttackPhase == 0) { Obstacle02.Left = -1000; AttackPhase = 1; Beam.Top = 4000; }
            if(Obstacle02.Left < -1300 && AttackPhase == 1) { AttackPhase = 2; MechaBossZilla.Image = Properties.Resources.MechaBossZillaToFire; }
            if(Obstacle02.Left < -1700 && AttackPhase == 2) {
                MechaBossZilla.Image = Properties.Resources.MechaBossZillaFire;
                Beam.Top = MechaBossZilla.Top + 145;
            }
            if(Obstacle02.Left < -2100 && AttackPhase == 2)
            {
                MechaBossZilla.Image = Properties.Resources.MechaBossZilla1;
                AttackPhase = 0;
            }

        }
        private void BossIsDead()
        {
            SNDexplode.Play();
            ZillaHealth = -1;
            Obstacle01.Left = -800;
            Bosshealth.Visible = false;
            ShipExplode.Left = MechaBossZilla.Left - 70;
            ShipExplode.Top = MechaBossZilla.Top = 300;
            ShipExplode.Image = Properties.Resources.Explosion;
            MechaBossZilla.Left = -2000;
            Beam.Top = 4000;
            points += 100;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void youwin_TextChanged(object sender, EventArgs e)
        {

        }
        private void Nickname_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void saveScore()
        {
            var Nickname = this.Nickname.Text;
            int Score = points;
            string[] scores = new string[10];
            string[] new_scores = new string[10];
      //      var path = Path.Combine(Directory.GetCurrentDirectory(), "\\Users\\anvil\\source\\repos\\Arcade-Game-Project\\highscore.txt");
            var currentHighscore = File.ReadAllText(@"..\..\..\highscore.txt");

            using (StringReader sr = new StringReader(currentHighscore))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    scores[i] = line;
                    new_scores[i] = scores[i];
                    i++;
                }
            }

            for (int i = 0; i < scores.Length; i++)
            {
                if(CompareScore(scores[i], Score))
                {
                    new_scores[i] = String.Format("{0}. {1} {2}", i+1, Nickname, Score);
                    for (int j = i+1; j < 10; j++)
                    {
                        new_scores[j] = String.Format("{0}. {1}", j+1, scores[j - 1].Substring(3 + (j / 10)));
                    }
                    break;
                }
            }


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.AppendFormat(new_scores[i]);
                sb.Append('\n');
            }

            File.WriteAllText(@"..\..\..\highscore.txt", sb.ToString());

        }

        private static bool CompareScore(string line, int Score) // return true if score is higher than compared one
        {
            int i=0;
            var counter = 0;
            while (i < line.Length)
            {
                if(line[i] == ' ') 
                {
                    counter++;
                    if(counter == 2) { break; }
                }
                i++;
            }

            i++;

            string helper = line[i..];
            var helperInt = Int64.Parse(helper);

            if (Score > helperInt) { return true;}

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveScore();
            menumusic.PlayLooping();
            this.Close();
        }
    }
}
