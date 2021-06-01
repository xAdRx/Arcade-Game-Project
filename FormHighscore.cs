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

namespace CometShooter
{
    public partial class FormHighscore : Form
    {
        public FormHighscore()
        {
            InitializeComponent();
            textBox1.Text = loadHighscore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string loadHighscore()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\Users\\anvil\\source\\repos\\Arcade-Game-Project\\highscore.txt");
            var currentHighscore = File.ReadAllText(path);
            StringBuilder sb = new StringBuilder();
            using (StringReader sr = new StringReader(currentHighscore))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sb.AppendFormat(line);
                    sb.Append('\n');
                }
            }

            return sb.ToString();
        }
    }
}
