using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
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
            PopulateTextBoxes(); // Call the method to populate the TextBox when the form loads
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
        private void PopulateTextBoxes()
        {
            string connectionString = "Data Source=udens_programma.db;Version=3;"; // Update connection string with your SQLite database file path

            string query = "SELECT [1], [2], [3], [4], [5], [6], [7] FROM Ieguvumi"; // Query to select the values from columns 1 to 7

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader["1"].ToString(); // Populate TextBox1 with the value from column 1
                    textBox2.Text = reader["2"].ToString(); // Populate TextBox2 with the value from column 2
                    textBox3.Text = reader["3"].ToString(); // Populate TextBox3 with the value from column 3
                    textBox4.Text = reader["4"].ToString(); // Populate TextBox4 with the value from column 4
                    textBox5.Text = reader["5"].ToString(); // Populate TextBox5 with the value from column 5
                    textBox6.Text = reader["6"].ToString(); // Populate TextBox6 with the value from column 6
                    textBox7.Text = reader["7"].ToString(); // Populate TextBox7 with the value from column 7
                }
                reader.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.healthline.com/nutrition/7-health-benefits-of-water");
        }
    }
}

