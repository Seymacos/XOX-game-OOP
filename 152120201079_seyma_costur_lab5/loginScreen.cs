using System;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _152120201079_seyma_costur_lab6
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
            GetUserInfoFromXML();
        }

        settingScreen settingScreen2 = new settingScreen();

        public void setter(string type)
        {
            settingScreen2.userLabel = type;
        }
        //XML den okumak icin
        public bool ReadXml()
        {
            //xml dosyasinin tanimlanmasi
            string filePath = "usersFile.xml";       
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            // Select the nodes for user information
            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");

            // Iterate over the selected nodes and read the user information
            foreach (XmlNode userNode in userNodes)
            {
                string username = userNode.SelectSingleNode("username").InnerText;
                string password = userNode.SelectSingleNode("password").InnerText;
                string usertype = userNode.SelectSingleNode("usertype").InnerText;

                if (username == textBox_loginScreen_username.Text)
                {
                    if (password == textBox_loginScreen_password.Text)
                    {
                        if (usertype == "admin")
                        {
                            settingScreen2.userLabel = "admin";
                            Thread.Sleep(500);
                        }
                        else
                        {
                            settingScreen2.userLabel = "user";
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
       
        //Beni hatirla secilmisse
        public void checkRememberMe()
        {
            if (checkBox_rememberMe.Checked)
            {
                deleteUser();
                writeUser();
            }
            else if (!checkBox_rememberMe.Checked)
            {
                deleteUser();
            }
        }
        //LOG IN butonuna tiklandiginda
        private void button_loginScreen_Click(object sender, EventArgs e)
        {
            //admin giris yapiyorsa
            if (textBox_loginScreen_username.Text == "admin" && textBox_loginScreen_password.Text == "admin")
            {
                this.Hide();
                settingScreen2.userLabel = "admin";
                settingScreen2.Show();
                checkRememberMe();
            }
            //user giris yapiyorsa
            else if (textBox_loginScreen_username.Text == "user" && textBox_loginScreen_password.Text == "user")
            {
                checkRememberMe();
                this.Hide();
                settingScreen2.userLabel = "user";
                settingScreen2.Show(); 
            }
            //Kullanici xml den okunuyorsa
            else if (ReadXml())
            {
                checkRememberMe();
                this.Hide();
                settingScreen2.Show();              
            }
            //Kullanici suana kadar giris yapmadiysa
            else
            {
                MessageBox.Show("incorrect username or incorret password");
            }
        }

        //Sifreyi göstere tiklandiginda
        private void radioButton_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            //radiobox işaretli ise
            if (radioButton_showPassword.Checked)
            {
                //karakteri göster.
                textBox_loginScreen_password.PasswordChar = '\0';
            }
            //değilse karakterlerin yerine * koy.
            else
            {
                textBox_loginScreen_password.PasswordChar = '*';
            }
        }
        //Register butonuna tiklandiginda
        private void button_register_Click(object sender, EventArgs e)
        {
            //addUpdate formu aciliyor
            addUpdate addorupdate = new addUpdate();
            addorupdate.isAdministrator = false;
            addorupdate.Show();
        }
        //kayit altina alinan kullanicinin silinmesi
        public void deleteUser()
        {
            // xml dosyasinin tanimlanmasi
            string filePath = "usersFile.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            //Kullanıcı adının oldugu node secilir
            XmlNode userNode = xmlDoc.SelectSingleNode("/users/formerUser");

            // Kullanıcı düğümünün var olup olmadığı kontrol edilir
            if (userNode != null)
            {
                //users dügümünü alın ve user dügümünü kaldırılir
                XmlNode parentNode = userNode.ParentNode;
                parentNode.RemoveChild(userNode);
               //degisiklikler kayıt edilir
                xmlDoc.Save(filePath);
            }
        }
        //Kayit altina alinan kullanicinin yazilmasi
        public void writeUser()
        {
            // xml in tanimlanmasi
            string filePath = "usersFile.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            // <users> 
            XmlElement usersElement = xmlDoc.SelectSingleNode("/users") as XmlElement;

            // <user> in yaratilmasi
            XmlElement userElement = xmlDoc.CreateElement("formerUser");

            //Kullanıcı bigilerinin yaratilmasi ve eklenmesi
            XmlElement usernameElement = xmlDoc.CreateElement("username");
            usernameElement.InnerText = textBox_loginScreen_username.Text;
            userElement.AppendChild(usernameElement);

            XmlElement passwordElement = xmlDoc.CreateElement("password");
            passwordElement.InnerText = textBox_loginScreen_password.Text;
            userElement.AppendChild(passwordElement);
            usersElement.AppendChild(userElement);

            // Degisikliklerin kaydedilmesi
            xmlDoc.Save(filePath);
        }
        public void GetUserInfoFromXML()
        {
            // dosya tanimlaniyor
            string filePath = "usersFile.xml";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);

            // node un secilmesi
            XmlNode userNode = xmlDoc.SelectSingleNode("/users/formerUser");

            // Kullanıcı düğümünün var olup olmadığı kontrol edilir
            if (userNode != null)
            {
                // Kullanıcı düğümü içindeki parola kullanici adi alinir
                XmlNode passwordNode = userNode.SelectSingleNode("password");
                XmlNode usernameNode = userNode.SelectSingleNode("username");

                textBox_loginScreen_password.Text = passwordNode.InnerText;
                textBox_loginScreen_username.Text = usernameNode.InnerText;
            }
        }
    }
}
