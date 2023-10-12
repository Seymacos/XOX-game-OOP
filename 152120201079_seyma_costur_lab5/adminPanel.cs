using Microsoft.VisualBasic.FileIO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace _152120201079_seyma_costur_lab6
{
    public partial class adminPanel : Form
    {
        int restrictAmount;
        addUpdate addupdate = new addUpdate();
        SqlConnection cnn;
        string connectionString;
        public adminPanel()
        {
            InitializeComponent();
        }

        public void restrictedRead()
        {
            TextFieldParser parser = new TextFieldParser("users.xml");

            parser.TextFieldType = FieldType.Delimited;

            parser.Delimiters = new string[] { "," };
            while (restrictAmount >= 0)
            {
                string[] fields = parser.ReadFields();

                userInfo userinfo3 = new userInfo();
                userinfo3.userName = fields[0];
                userinfo3.password = fields[1];
                userinfo3.id = fields[2];
                userinfo3.mail = fields[3];
                userinfo3.nameSurname = fields[4];
                userinfo3.userType = fields[5];

                restrictAmount--;
            }
        }
        public void ReadXml()
        {
            int index = 0;
            string filePath = "usersFile.xml";

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Index", typeof(int));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("User Type", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Name Surname", typeof(string));
            dataTable.Columns.Add("Mail", typeof(string));


            // Load the XML file
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
                string id = userNode.SelectSingleNode("id").InnerText;
                string mail = userNode.SelectSingleNode("mail").InnerText;
                string namsurname = userNode.SelectSingleNode("namesurname").InnerText;


                dataTable.Rows.Add(index, id, usertype, username, namsurname, mail);

                index++;
                // Set the DataSource property of the DataGridView to the DataTable


            }
            dataGridView1.DataSource = dataTable;
        }
        private void button_List_Click(object sender, EventArgs e)
        {
            int index = 0;
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Index", typeof(int));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("User Type", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Name Surname", typeof(string));
            dataTable.Columns.Add("Mail", typeof(string));


            using (SqlCommand command = new SqlCommand("SELECT TOP 20 * FROM dbo.users", cnn))

            using (SqlDataReader reader = command.ExecuteReader())
            {


                while (reader.Read())
                {
                    index++;
                    int id = Convert.ToInt32(reader["ID"]);
                    string usertype = reader["UserType"].ToString();
                    string username = reader["UserName"].ToString();
                    string namesurname = reader["NameSurname"].ToString();
                    string mail = reader["mail"].ToString();

                    dataTable.Rows.Add(index, id, usertype, username, namesurname, mail);
                }
                dataGridView1.DataSource = dataTable;
            }

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            addUpdate addorupdate = new addUpdate();
            addorupdate.isAdministrator = true;
            addorupdate.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Please select a row to update");
            }
            else
            {
                addUpdate addorupdate = new addUpdate();


                // Load the XML file
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("usersFile.xml");

                // Select the nodes for user information
                XmlNodeList userNodes = xmlDoc.SelectNodes("//user");

                // Check if the specified index is within the valid range

                XmlNode userNode = userNodes[restrictAmount];

                // Read the user information
                addorupdate.username = userNode.SelectSingleNode("username").InnerText;
                addorupdate.password = userNode.SelectSingleNode("password").InnerText;
                addorupdate.id = userNode.SelectSingleNode("id").InnerText;
                addorupdate.mail = userNode.SelectSingleNode("mail").InnerText;
                addorupdate.namesurname = userNode.SelectSingleNode("namesurname").InnerText;
                addorupdate.usertype = userNode.SelectSingleNode("usertype").InnerText;



                // Wait for 1 second (1000 milliseconds)
                Thread.Sleep(500);

                addupdate.isUpdate = true;
                addupdate.selectedRowIndex = restrictAmount;

                addupdate.isAdministrator = true;
                addorupdate.Show();
            }


        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            restrictAmount = e.RowIndex;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            // DeleteNodeAtPosition("usersFile.xml", int.Parse(textBox_adminPanel.Text));

            string ID = textBox_adminPanel.Text;
            if (!string.IsNullOrEmpty(ID)) // ID'nin Boş olup olmadığının kontrolü yapıyoruz yine yukarılarda ID isimli bir string değer tanımlanmış olmalıdır.
            {
                string sql = "delete from Users where ID = '" + ID + "' ";
                SqlCommand cmd = new SqlCommand(sql, cnn);

                if (cnn.State != ConnectionState.Open) // Bağlantı açık değilse açtırıyoruz.
                {
                    cnn.Open();
                }
                cmd.ExecuteNonQuery(); // Silme işlemini yapan komut
                cnn.Close(); // bağlantıyı kapat
            }
            /*  public static void DeleteNodeAtPosition(string filePath, int position)
              {
                  // Load the XML file
                  XmlDocument xmlDoc = new XmlDocument();
                  xmlDoc.Load(filePath);

                  // Select the node at the specified position (row)
                  XmlNodeList nodes = xmlDoc.SelectNodes("//users/user");

                  if (position >= 0 && position < nodes.Count)
                  {
                      // Get the node at the specified position
                      XmlNode nodeToDelete = nodes[position];

                      // Delete the node
                      nodeToDelete.ParentNode.RemoveChild(nodeToDelete);

                      // Save the modified XML back to the file
                      xmlDoc.Save(filePath);
                  }
                  else
                  {
                      Console.WriteLine("Invalid position. No node found at the specified position.");
                  }*/
        }
        public class userInfo
        {
            public string id, userType, userName, nameSurname, mail, password;


        }
        //sql le iletisim kumak icin
        private void button_connect_Click(object sender, EventArgs e)
        {
            int index = 0;
            connectionString = textBox1.Text;
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            if(cnn.State == ConnectionState.Open )
            {
                MessageBox.Show("Connection Open !");
            }
            else
            {
                MessageBox.Show("Connection failed !");
                return;
            }

            DataTable dataTable = new DataTable();
            //tablonun columları
            dataTable.Columns.Add("Index", typeof(int));
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("User Type", typeof(string));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Name Surname", typeof(string));
            dataTable.Columns.Add("Mail", typeof(string));

            using (SqlCommand command = new SqlCommand("SELECT TOP 20 * FROM dbo.users", cnn))

            //sql den okuma
            using (SqlDataReader reader = command.ExecuteReader())
            {
                //datagridviewe yazdırmak icin
                while (reader.Read())
                {
                    index++;
                    int id = Convert.ToInt32(reader["ID"]);
                    string usertype = reader["UserType"].ToString();
                    string username = reader["UserName"].ToString();
                    string namesurname = reader["NameSurname"].ToString();
                    string mail = reader["mail"].ToString();

                    dataTable.Rows.Add(index, id, usertype, username, namesurname, mail);
                }
                dataGridView1.DataSource = dataTable;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

