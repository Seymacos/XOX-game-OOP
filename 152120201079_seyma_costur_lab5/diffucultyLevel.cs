using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201079_seyma_costur_lab6
{
    public partial class diffucultyLevel : Form
    {

        public diffucultyLevel()
        {
            InitializeComponent();
        }

        private void buttonEasy_diffucultyLevel_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.Show();
        }

        private void buttonMedium_diffucultyLevel_Click(object sender, EventArgs e)
        {
            mediumLevelGame game = new mediumLevelGame();
            game.Show();

        }

        private void buttonHard_diffucultyLevel_Click(object sender, EventArgs e)
        {
            hardLevelGame game = new hardLevelGame();
            game.Show();
        }
    }
}
