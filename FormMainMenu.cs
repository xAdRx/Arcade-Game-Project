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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form game = new FormGame();
            game.ShowDialog();

            Visible = true;
            ShowInTaskbar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Visible = false;
            ShowInTaskbar = false;

            Form customize = new FormCustomizeMenu();
            customize.ShowDialog();

            Visible = true;
            ShowInTaskbar = true;
        }

    }
}
