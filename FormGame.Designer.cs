
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
            this.Protagonist = new System.Windows.Forms.PictureBox();
            this.Obstacle01 = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Obstacle02 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Protagonist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle02)).BeginInit();
            this.SuspendLayout();
            // 
            // Protagonist
            // 
            this.Protagonist.BackColor = System.Drawing.Color.Transparent;
            this.Protagonist.Image = global::CometShooter.Properties.Resources.Player1;
            this.Protagonist.Location = new System.Drawing.Point(70, 241);
            this.Protagonist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Protagonist.Name = "Protagonist";
            this.Protagonist.Size = new System.Drawing.Size(279, 199);
            this.Protagonist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Protagonist.TabIndex = 0;
            this.Protagonist.TabStop = false;
            this.Protagonist.Click += new System.EventHandler(this.Protagonist_Click);
            // 
            // Obstacle01
            // 
            this.Obstacle01.BackColor = System.Drawing.Color.Transparent;
            this.Obstacle01.Image = global::CometShooter.Properties.Resources.Obstacle;
            this.Obstacle01.Location = new System.Drawing.Point(698, 611);
            this.Obstacle01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Obstacle01.Name = "Obstacle01";
            this.Obstacle01.Size = new System.Drawing.Size(194, 456);
            this.Obstacle01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle01.TabIndex = 2;
            this.Obstacle01.TabStop = false;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(-232, -39);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(50, 20);
            this.Score.TabIndex = 3;
            this.Score.Text = "label1";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.BackColor = System.Drawing.Color.Transparent;
            this.Points.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Points.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Points.Location = new System.Drawing.Point(70, 59);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(185, 54);
            this.Points.TabIndex = 4;
            this.Points.Text = "Score:0";
            this.Points.Click += new System.EventHandler(this.Points_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 20;
            this.Timer.Tick += new System.EventHandler(this.JumpTime);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(871, -36);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 24);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Press);
            this.checkBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Release);
            // 
            // Obstacle02
            // 
            this.Obstacle02.BackColor = System.Drawing.Color.Transparent;
            this.Obstacle02.Image = global::CometShooter.Properties.Resources.Obstacle;
            this.Obstacle02.Location = new System.Drawing.Point(698, -63);
            this.Obstacle02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Obstacle02.Name = "Obstacle02";
            this.Obstacle02.Size = new System.Drawing.Size(194, 429);
            this.Obstacle02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle02.TabIndex = 6;
            this.Obstacle02.TabStop = false;
            this.Obstacle02.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CometShooter.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Obstacle02);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Obstacle01);
            this.Controls.Add(this.Protagonist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormGame";
            this.Text = "Between Worlds";
            this.Load += new System.EventHandler(this.FormGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Protagonist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstacle02)).EndInit();
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
    }
}

