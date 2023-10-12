using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _152120201079_seyma_costur_lab6
{
    public partial class addUpdate : Form
    {
        public string username, password, id, mail, namesurname, usertype;

        public bool isUpdate;
        public bool isAdministrator=false;
        public int selectedRowIndex;
        SqlConnection cnn;
        string connectionString;
        public static void DeleteNodeAtPosition(string filePath, int position)
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
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void deleteSql()
        {

            string deleteStatement = "DELETE FROM dbo.users WHERE ID = @ID";
            using (SqlCommand command = new SqlCommand(deleteStatement, cnn))
            {
                // Set the parameter values, if any
                command.Parameters.AddWithValue("@ID", textBox_ID.Text);

                // Execute the delete command
                int rowsAffected = command.ExecuteNonQuery();

                // Check the number of rows affected to determine if the delete was successful
                if (rowsAffected > 0)
                {
                    // The row was deleted successfully
                    Console.WriteLine("Row deleted successfully.");
                }
                else
                {
                    // The row was not found or not deleted
                    Console.WriteLine("No rows deleted or the row was not found.");
                }
            }
        }
      
        //sqle yazmak icin
        public void writeSql()
        {
            string connectionString;
            connectionString = textBox1.Text;
            cnn = new SqlConnection(connectionString);
            cnn.Open();

            string insertStatement = "INSERT INTO dbo.users (ID, UserType, UserName, NameSurname, Password, mail) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6)";
            using (SqlCommand command = new SqlCommand(insertStatement, cnn))
            {


                // Set the parameter values
                command.Parameters.AddWithValue("@Value1", int.Parse(textBox_ID.Text));
                command.Parameters.AddWithValue("@Value2", textBox_userType.Text);
                command.Parameters.AddWithValue("@Value3", textBox_username.Text);
                command.Parameters.AddWithValue("@Value4", textBox_nameSurname.Text);
                command.Parameters.AddWithValue("@Value5", textBox_password.Text);
                command.Parameters.AddWithValue("@Value6", textBox_mail.Text);

                int rowsAffected = command.ExecuteNonQuery();

                // Check the number of rows affected to determine if the insert was successful
                if (rowsAffected > 0)
                {
                    // The new row was inserted successfully
                    Console.WriteLine("New row inserted successfully.");
                }
                else
                {
                    // The new row was not inserted
                    Console.WriteLine("Failed to insert a new row.");
                }
            }

        }
        public static void WriteXml(string username, string password, string mail, string id, string namesurname, string usertype)
        {
            string filePath = "usersFile.xml";
            // Create a new XML document
            XmlDocument xmlDoc = new XmlDocument();

            // Check if the XML file already exists
            if (File.Exists(filePath))
            {
                // Load the existing XML file
                xmlDoc.Load(filePath);
            }
            else
            {
                // Create a root element and append it to the document
                XmlElement rootElement = xmlDoc.CreateElement("users");
                xmlDoc.AppendChild(rootElement);
            }

            // Create a new user element and append it to the root element
            XmlElement userElement = xmlDoc.CreateElement("user");
            xmlDoc.DocumentElement.AppendChild(userElement);

            // Create child elements for username, password, and id
            XmlElement usernameElement = xmlDoc.CreateElement("username");
            usernameElement.InnerText = username;
            userElement.AppendChild(usernameElement);

            XmlElement passwordElement = xmlDoc.CreateElement("password");
            passwordElement.InnerText = password;
            userElement.AppendChild(passwordElement);

            XmlElement idElement = xmlDoc.CreateElement("id");
            idElement.InnerText = id;
            userElement.AppendChild(idElement);

            XmlElement mailElement = xmlDoc.CreateElement("mail");
            mailElement.InnerText = mail;
            userElement.AppendChild(mailElement);

            XmlElement namesurnameElement = xmlDoc.CreateElement("namesurname");
            namesurnameElement.InnerText = namesurname;
            userElement.AppendChild(namesurnameElement);

            XmlElement usertypeElement = xmlDoc.CreateElement("usertype");
            usertypeElement.InnerText = usertype;
            userElement.AppendChild(usertypeElement);
            // Save the XML document
            xmlDoc.Save(filePath);

        }
        private void addUpdate_Load(object sender, EventArgs e)
        {
            if (isAdministrator == true)
            {
                textBox_userType.Text = "";
                textBox_userType.ReadOnly = false;
            }
            else
            {
                textBox_userType.Text = "user";
                textBox_userType.ReadOnly = true;
            }
            if (isUpdate == true)
            {
                textBox_ID.ReadOnly = true;
            }
            else
            {
                textBox_ID.ReadOnly = false;
            }
        }
        public addUpdate()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (isUpdate == false)
            {
                WriteXml(textBox_username.Text, textBox_password.Text, textBox_mail.Text, textBox_ID.Text, textBox_nameSurname.Text, textBox_userType.Text);
                writeSql();
            }
            else if (isUpdate == true)
            {

                DeleteNodeAtPosition("usersFile.xml", selectedRowIndex);
                deleteSql();
                WriteXml(textBox_username.Text, textBox_password.Text, textBox_mail.Text, textBox_ID.Text, textBox_nameSurname.Text, textBox_userType.Text);
                writeSql();
                //delete data



            }
        }
        private void addOrUpdate_Load(object sender, EventArgs e)
        {
            textBox_nameSurname.Text = username;
            textBox_password.Text = password;
            textBox_ID.Text = id;
            textBox_mail.Text = mail;
            textBox_nameSurname.Text = namesurname;
            textBox_username.Text = usertype;
        }
    }
}
