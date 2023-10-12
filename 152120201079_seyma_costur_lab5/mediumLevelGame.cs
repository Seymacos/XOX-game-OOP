using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _152120201079_seyma_costur_lab6
{
    public partial class mediumLevelGame : Form
    {
        //Oyunda kullanılacak karakterler
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        //Kullanılacak butonların list olarak tutulması
        List<Button> buttons;
        Random rand = new Random();
        public mediumLevelGame()
        {
            InitializeComponent();
        }

        //Kullanıcının x i yerleştirmesi
        private void buttonClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Cyan;
            buttons.Remove(button);
            Check();
            AITIMER.Start();
        }
        //Yapay zekanın oynaması, O'nun yerleştirilmesi
        private void playAI(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;

                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon;
                buttons.RemoveAt(index);
             
                AITIMER.Stop();
                Check();
            }

        }

        //Reset butonuna basıldığında, yeni oyunun açılması
        private void resetGame(object sender, EventArgs e)
        {
            this.Close();
            mediumLevelGame mediumLevelGame1  = new mediumLevelGame();
            mediumLevelGame1.Show();
       }

        //Listeye atanan butonlar
        private void loadbuttons()
        {

            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16 };
        }

        //Kazanma durumunun kontrol edilmesi, oluşması gereken durumlara göre
        private void Check()
        {
            if (
            button1.Text == "X" && button2.Text == "X" && button3.Text == "X" && button4.Text == "X" ||
            button5.Text == "X" && button6.Text == "X" && button7.Text == "X" && button8.Text == "X" ||
            button9.Text == "X" && button10.Text == "X" && button11.Text == "X" && button12.Text == "X" ||
            button13.Text == "X" && button14.Text == "X" && button15.Text == "X" && button16.Text == "X" ||
            button1.Text == "X" && button5.Text == "X" && button9.Text == "X" && button13.Text == "X" ||
            button2.Text == "X" && button6.Text == "X" && button10.Text == "X" && button14.Text == "X" ||
            button3.Text == "X" && button7.Text == "X" && button11.Text == "X" && button15.Text == "X" ||
            button4.Text == "X" && button8.Text == "X" && button12.Text == "X" && button16.Text == "X" ||
            button1.Text == "X" && button6.Text == "X" && button11.Text == "X" && button16.Text == "X" ||
            button4.Text == "X" && button7.Text == "X" && button10.Text == "X" && button13.Text == "X"
                )
            {
                // eger kosullar saglanmıssa x kazanir
                AITIMER.Stop();
                //  MessageBox.Show("Player Wins");
                label_Result.Text = "Player win";

            }
        
            else if (
            button1.Text == "O" && button2.Text == "O" && button3.Text == "O" && button4.Text == "O" ||
            button5.Text == "O" &&button6.Text == "O" && button7.Text == "O" && button8.Text == "O" ||
            button9.Text == "O" && button10.Text == "O" && button11.Text == "O" && button12.Text == "O" ||
            button13.Text == "O" && button14.Text == "O" && button15.Text == "O"&& button16.Text == "O" ||
            button1.Text == "O" && button5.Text == "O" && button9.Text == "O" && button13.Text == "O" ||
            button2.Text == "O" && button6.Text == "O" && button10.Text == "O" && button14.Text == "O" ||
            button3.Text == "O" && button7.Text == "O" && button11.Text == "O" && button15.Text == "O" ||
            button4.Text == "O" && button8.Text == "O" && button12.Text == "O" && button16.Text == "O" ||
            button1.Text == "O" && button6.Text == "O" && button11.Text == "O" && button16.Text == "O" ||
            button4.Text == "O" && button7.Text == "O" && button10.Text == "O" && button13.Text == "O"
                )
            {
                AITIMER.Stop();
                //  MessageBox.Show("Player AI");
                label_Result.Text = "AI win";

            }
        }

        //Back butonuna basıldığında bi önceki forma geri dönmek için
        private void buttonBack_mediumLevelGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mediumLevelGame_Load(object sender, EventArgs e)
        {
            loadbuttons();
        }
    }
}
