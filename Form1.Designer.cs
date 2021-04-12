
namespace CometShooter
{
    partial class Form1
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
            this.Protagonist.Image = global::CometShooter.Properties.Resources.Player1;
            this.Protagonist.Location = new System.Drawing.Point(61, 181);
            this.Protagonist.Name = "Protagonist";
            this.Protagonist.Size = new System.Drawing.Size(244, 149);
            this.Protagonist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Protagonist.TabIndex = 0;
            this.Protagonist.TabStop = false;
            this.Protagonist.Click += new System.EventHandler(this.Protagonist_Click);
            // 
            // Obstacle01
            // 
            this.Obstacle01.Image = global::CometShooter.Properties.Resources.Obstacle;
            this.Obstacle01.Location = new System.Drawing.Point(611, 458);
            this.Obstacle01.Name = "Obstacle01";
            this.Obstacle01.Size = new System.Drawing.Size(170, 342);
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
            this.Points.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Points.Location = new System.Drawing.Point(61, 44);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(166, 44);
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
            this.Obstacle02.Image = global::CometShooter.Properties.Resources.Obstacle;
            this.Obstacle02.Location = new System.Drawing.Point(611, -47);
            this.Obstacle02.Name = "Obstacle02";
            this.Obstacle02.Size = new System.Drawing.Size(170, 322);
            this.Obstacle02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Obstacle02.TabIndex = 6;
            this.Obstacle02.TabStop = false;
            this.Obstacle02.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1167, 749);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Obstacle02);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Obstacle01);
            this.Controls.Add(this.Protagonist);
            this.Name = "Form1";
            this.Text = "Project Comet Shooter";
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

