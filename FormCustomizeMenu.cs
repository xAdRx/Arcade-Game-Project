using System;
using System.Windows.Forms;

namespace CometShooter
{
    public partial class FormCustomizeMenu : Form
    {
        public FormCustomizeMenu()
        {
            InitializeComponent();
            if (CometShooter.FormMainMenu.skin == global::CometShooter.Properties.Resources.PlayerNew)
            {
                Selected.Left = button2.Left - 7;
            }
            else if (CometShooter.FormMainMenu.skin == global::CometShooter.Properties.Resources.Skin1)
            {
                Selected.Left = button3.Left - 7;
            }
            else if (CometShooter.FormMainMenu.skin == global::CometShooter.Properties.Resources.Skin2)
            {
                Selected.Left = button4.Left - 7;
            }
            else
            { Selected.Left = 9999; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCustomizeMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CometShooter.FormMainMenu.skin = global::CometShooter.Properties.Resources.PlayerNew;
            Selected.Left = button2.Left - 7;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CometShooter.FormMainMenu.skin = global::CometShooter.Properties.Resources.Skin1;
            Selected.Left = button3.Left - 7;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CometShooter.FormMainMenu.skin = global::CometShooter.Properties.Resources.Skin2;
            Selected.Left = button4.Left - 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CometShooter.FormMainMenu.skin = global::CometShooter.Properties.Resources.Player1;
            Selected.Left = button5.Left - 7;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Selected_Click(object sender, EventArgs e)
        {

        }
    }
}