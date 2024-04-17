using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//https://www.healthline.com/nutrition/7-health-benefits-of-water#6.-Helps-prevent-hangovers
namespace H2Oreminder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            PopulateTextBox(); // Call the method to populate the TextBox when the form loads
        }
        static SQLiteConnection CreateConnection() // Programmas konnekcija ar SQL datubāzi
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source=udens_programma.db; Version=3; New=True; Compress=True;");
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                // Savienojuma kļūdu apstrāde
            }
            return sqlite_conn;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void PopulateTextBox()
        {
            string connectionString = ("Data Source=udens_programma.db; Version=3; New=True; Compress=True;"); // Update connection string with your server and database details
            string query = "SELECT 1 FROM Ieguvumi WHERE YourCondition = YourValue"; // Update the query as per your requirements

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string textFromDatabase = reader["1"].ToString(); // Assuming the column is of string type
                    textBox1.Text = textFromDatabase; // Populate the TextBox with the text retrieved from the database
                }
                reader.Close();
            }
        }
    }
}

