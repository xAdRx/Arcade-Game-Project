
using System.Windows.Forms;

namespace CometShooter
{
    partial class FormGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.Protagonist = new System.Windows.Forms.PictureBox();
            this.Obstacle01 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Obstacle02 = new System.Windows.Forms.PictureBox();
            this.Projectile = new System.Windows.Forms.PictureBox();
            this.Meteor1 = new System.Windows.Forms.PictureBox();
            this.Meteor2 = new System.Windows.Forms.PictureBox();
            this.Meteor3 = new System.Windows.Forms.PictureBox();
            this.Meteor4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProjHit = new System.Windows.Forms.PictureBox();
            this.ShipExplode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Protagonist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjHit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipExplode)).BeginInit();
            this.SuspendLayout();
            // 
            // Protagonist
            // 
            this.Protagonist.BackColor = System.Drawing.Color.Black;
            this.Protagonist.Image = ((System.Drawing.Image)(resources.GetObject("Protagonist.Image")));
            this.Protagonist.Location = new System.Drawing.Point(27, 192);
            this.Protagonist.Name = "Protagonist";
            this.Protagonist.Size = new System.Drawing.Size(328, 155);
            this.Protagonist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Protagonist.TabIndex = 0;
            this.Protagonist.TabStop = false;
            // 
            // Obstacle01
            // 
            this.Obstacle01.BackColor = System.Drawing.Color.Black;
            this.Obstacle01.Image = global::CometShooter.Properties.Resources.ObstacleNew2;
            this.Obstacle01.Location = new System.Drawing.Point(611, 494);
            this.Obstacle01.Name = "Obstacle01";
            this.Obstacle01.Size = new System.Drawing.Size(142, 431);
            this.Obstacle01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle01.TabIndex = 2;
            this.Obstacle01.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(-203, -29);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(38, 15);
            this.Score.TabIndex = 3;
            this.Score.Text = "label1";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Black;
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Points.Location = new System.Drawing.Point(61, 44);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(147, 42);
            this.Points.TabIndex = 4;
            this.Points.Text = "Score:0";
            this.Points.Click += new System.EventHandler(this.Points_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 16;
            this.Timer.Tick += new System.EventHandler(this.JumpTime);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(762, -27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Press);
            this.checkBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Release);
            // 
            // Obstacle02
            // 
            this.Obstacle02.BackColor = System.Drawing.Color.Black;
            this.Obstacle02.Image = global::CometShooter.Properties.Resources.ObstacleNew1;
            this.Obstacle02.Location = new System.Drawing.Point(611, -25);
            this.Obstacle02.Name = "Obstacle02";
            this.Obstacle02.Size = new System.Drawing.Size(125, 400);
            this.Obstacle02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle02.TabIndex = 6;
            this.Obstacle02.TabStop = false;
            this.Obstacle02.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Projectile
            // 
            this.Projectile.BackColor = System.Drawing.Color.Black;
            this.Projectile.Image = global::CometShooter.Properties.Resources.ProjectileHQ;
            this.Projectile.Location = new System.Drawing.Point(229, 259);
            this.Projectile.Name = "Projectile";
            this.Projectile.Size = new System.Drawing.Size(200, 30);
            this.Projectile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Projectile.TabIndex = 7;
            this.Projectile.TabStop = false;
            // 
            // Meteor1
            // 
            this.Meteor1.BackColor = System.Drawing.Color.Black;
            this.Meteor1.Image = global::CometShooter.Properties.Resources.TestMeteor;
            this.Meteor1.Location = new System.Drawing.Point(429, 44);
            this.Meteor1.Name = "Meteor1";
            this.Meteor1.Size = new System.Drawing.Size(167, 172);
            this.Meteor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteor1.TabIndex = 8;
            this.Meteor1.TabStop = false;
            // 
            // Meteor2
            // 
            this.Meteor2.BackColor = System.Drawing.Color.Black;
            this.Meteor2.Image = global::CometShooter.Properties.Resources.TestMeteor2;
            this.Meteor2.Location = new System.Drawing.Point(470, 285);
            this.Meteor2.Name = "Meteor2";
            this.Meteor2.Size = new System.Drawing.Size(144, 146);
            this.Meteor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteor2.TabIndex = 9;
            this.Meteor2.TabStop = false;
            // 
            // Meteor3
            // 
            this.Meteor3.BackColor = System.Drawing.Color.Black;
            this.Meteor3.Image = global::CometShooter.Properties.Resources.TestMeteor3;
            this.Meteor3.Location = new System.Drawing.Point(470, 414);
            this.Meteor3.Name = "Meteor3";
            this.Meteor3.Size = new System.Drawing.Size(135, 141);
            this.Meteor3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteor3.TabIndex = 10;
            this.Meteor3.TabStop = false;
            // 
            // Meteor4
            // 
            this.Meteor4.BackColor = System.Drawing.Color.Black;
            this.Meteor4.Image = global::CometShooter.Properties.Resources.TestMeteor;
            this.Meteor4.Location = new System.Drawing.Point(420, 643);
            this.Meteor4.Name = "Meteor4";
            this.Meteor4.Size = new System.Drawing.Size(185, 182);
            this.Meteor4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteor4.TabIndex = 11;
            this.Meteor4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CometShooter.Properties.Resources.BckgAnimated;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1680, 907);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // ProjHit
            // 
            this.ProjHit.Image = global::CometShooter.Properties.Resources.ProjectileHitAnimatedHQ;
            this.ProjHit.Location = new System.Drawing.Point(796, 219);
            this.ProjHit.Name = "ProjHit";
            this.ProjHit.Size = new System.Drawing.Size(135, 128);
            this.ProjHit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProjHit.TabIndex = 13;
            this.ProjHit.TabStop = false;
            // 
            // ShipExplode
            // 
            this.ShipExplode.Image = global::CometShooter.Properties.Resources.Explosion;
            this.ShipExplode.Location = new System.Drawing.Point(832, 395);
            this.ShipExplode.Name = "ShipExplode";
            this.ShipExplode.Size = new System.Drawing.Size(621, 355);
            this.ShipExplode.TabIndex = 14;
            this.ShipExplode.TabStop = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1680, 907);
            this.Controls.Add(this.ShipExplode);
            this.Controls.Add(this.Obstacle02);
            this.Controls.Add(this.Obstacle01);
            this.Controls.Add(this.Projectile);
            this.Controls.Add(this.Meteor4);
            this.Controls.Add(this.Meteor3);
            this.Controls.Add(this.Meteor2);
            this.Controls.Add(this.Meteor1);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Protagonist);
            this.Controls.Add(this.ProjHit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGame";
            this.Text = "Between Worlds";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Protagonist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Projectile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProjHit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShipExplode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.PictureBox Protagonist;
        private System.Windows.Forms.PictureBox Obstacle01;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox Obstacle02;
        private System.Windows.Forms.PictureBox Projectile;
        private System.Windows.Forms.PictureBox Meteor1;
        private System.Windows.Forms.PictureBox Meteor2;
        private System.Windows.Forms.PictureBox Meteor3;
        private System.Windows.Forms.PictureBox Meteor4;
        private PictureBox pictureBox1;
        private PictureBox ProjHit;
        private PictureBox ShipExplode;
    }
}

