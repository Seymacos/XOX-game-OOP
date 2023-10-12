using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace _152120201079_seyma_costur_lab6
{
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
         
        }

        private void textBox_StudentNumber_Click(object sender, EventArgs e)
        {
            //baslangıcta textbox da yazili olan text i siler
            textBox_StudentNumber.Clear();
            // studentID girilen texttir
            string studentID = textBox_StudentNumber.Text;
            //studentId uzunlugu 8 olmali
            if (studentID.Length != 8 || !int.TryParse(studentID, out int parsedID))
            {
                label_Result.Text = "Invalid ID number";
                return;
            }
        }
        //Kullanıcının x i yerleştirmesi
        private void playerClick(object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Cyan;
            buttons.Remove(button);
            Check();
            AImoves.Start();

        }

        //Yapay zekanın oynaması, O'nun yerleştirilmesi
        private void AImove(object sender, System.EventArgs e)
        {

            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;

                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon;
                buttons.RemoveAt(index);
                
                AImoves.Stop();
                Check();
            }

        }

        //Reset butonuna basıldığında, yeni oyunun açılması
        private void restartGame(object sender, System.EventArgs e)
        {

            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
        //Listeye atanan butonlar
        private void loadbuttons()
        {

            buttons = new List<Button> { box1, box2, box3, box4, box5, box6, box7, box8, box9 };
        }
        //Kazanma durumunun kontrol edilmesi, oluşması gereken durumlara göre
        private void Check()
        {
            //Tiknanılan butonlara göre kimin kazandigini kontrol ediyoruz

            if (box1.Text == "X" && box2.Text == "X" && box3.Text == "X"
               || box4.Text == "X" && box5.Text == "X" && box6.Text == "X"
               || box7.Text == "X" && box9.Text == "X" && box8.Text == "X"
               || box1.Text == "X" && box4.Text == "X" && box7.Text == "X"
               || box2.Text == "X" && box5.Text == "X" && box8.Text == "X"
               || box3.Text == "X" && box6.Text == "X" && box9.Text == "X"
               || box1.Text == "X" && box5.Text == "X" && box9.Text == "X"
               || box3.Text == "X" && box5.Text == "X" && box7.Text == "X")
            {
                // eger kosullar saglanmıssa x kazanir
                AImoves.Stop();
                string studentID = textBox_StudentNumber.Text;
                label_Result.Text = "Player win";
                // label_Skor.Text = test.testFuncXoX(studentID, "x", box1.Text, box2.Text, box3.Text, box4.Text, box5.Text, box6.Text, box7.Text, box8.Text, box9.Text).ToString();
                // MessageBox.Show("Player Wins");


            }
            //Yapay zeka oyunu kazanirsa
            else if (box1.Text == "O" && box2.Text == "O" && box3.Text == "O"
               || box4.Text == "O" && box5.Text == "O" && box6.Text == "O"
               || box7.Text == "O" && box9.Text == "O" && box8.Text == "O"
               || box1.Text == "O" && box4.Text == "O" && box7.Text == "O"
               || box2.Text == "O" && box5.Text == "O" && box8.Text == "O"
               || box3.Text == "O" && box6.Text == "O" && box9.Text == "O"
               || box1.Text == "O" && box5.Text == "O" && box9.Text == "O"
               || box3.Text == "O" && box5.Text == "O" && box7.Text == "O")
            {

                AImoves.Stop();
                string studentID = textBox_StudentNumber.Text;
                label_Result.Text = "AI win";
               // MessageBox.Show("Computer Wins");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadbuttons();
        }
        //Reset butonuna basıldığında, yeni oyunun açılması
        private void button_Reset_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();

        }
        //Back butonuna basıldığında bi önceki forma geri dönmek için
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
