using System;
using System.Windows.Forms;

namespace _152120201079_seyma_costur_lab6
{
    public partial class settingScreen : Form
    {
        public string userLabel;

        public settingScreen()
        {
            InitializeComponent();
        }

        private void settingScreen_Load(object sender, EventArgs e)
        {
            if (userLabel == "admin")
            {
                button_adminPanel.Visible = true;
            }
            else
            {
                button_adminPanel.Visible = false;
            }
        }

        private void button_newGame_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.Show();
        }

        private void button_adminPanel_Click(object sender, EventArgs e)
        {
            adminPanel adminPanel2 = new adminPanel();
            adminPanel2.Show();
        }

        private void button_difficulty_Click(object sender, EventArgs e)
        {
            diffucultyLevel diffucultyLevel2 = new diffucultyLevel();
            diffucultyLevel2.Show();
        }
    }
}
