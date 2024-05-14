using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;//fibit api
using System.Data.SqlClient;
using System.Windows.Forms;


namespace H2Oreminder
{
    public partial class Form4 : Form
    {
        private string connectionString = @"Data Source=active_koeficienti.db;Initial Catalog=YourDatabaseName;Integrated Security=True;";

        public Form4()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                // Pārliecināsimies, vai ievadītais skaitlis atbilst diapazonam
                if (value >= weightNumericUpDown.Minimum && value <= weightNumericUpDown.Maximum)
                {
                    weightNumericUpDown.Value = value;
                }
                // Ja ievadītais skaitlis ir mazāks par minimālo vērtību, iestatīsim minimālo vērtību
                else if (value < weightNumericUpDown.Minimum)
                {
                    weightNumericUpDown.Value = weightNumericUpDown.Minimum;
                }
                // Ja ievadītais skaitlis ir lielāks par maksimālo vērtību, iestatīsim maksimālo vērtību
                else
                {
                    weightNumericUpDown.Value = weightNumericUpDown.Maximum;
                }
            }
        }



        

        private void Form4_Load(object sender, EventArgs e)
        {
            // Šeit var ielādēt datus vai veikt citus sākuma uzdevumus, ja nepieciešams
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Get data from the user
            int weight = (int)weightNumericUpDown.Value; // weight in pounds
            double activityModifier = GetActivityModifier(); // activity modifier
            double waterIntake = CalculateWaterIntake(weight, activityModifier); // calculate water intake

            // Display the result in the label (convert gallons to liters)
            double waterIntakeLiters = ConvertGallonsToLiters(waterIntake);
            waterIntakeLabel.Text = $"Your daily water intake: {waterIntakeLiters:F2} liters";
        }


       private double ConvertGallonsToLiters(double gallons)
       {
            // izlabojam rezultātu
            return gallons * 0.1;
       }
        

        private double ConvertGallonsToLiters(double gallons)
        {
            // Pārejam no pārslēdzējiem uz litriem
            return gallons * 3.78541;
        }


        private double GetActivityModifier() // izmantot šos koeficientus no datubāzes(lai būtu vairāk tabulu)
        {
            Dictionary<string, double> activityModifiers = GetAllActivityModifiersFromDatabase();

            // Iegūstam izvēlēto aktivitātes līmeni
            string selectedActivityLevel = GetSelectedActivityLevel();

            // Atgriežam atbilstošo koeficientu, ja tas ir atrasts
            if (activityModifiers.ContainsKey(selectedActivityLevel))
            {
                return activityModifiers[selectedActivityLevel];
            }
            else
            {
                // Ja aktivitātes līmenis nav atrasts, atgriežam noklusējuma koeficientu
                return 0.6;
            }
        }

        private Dictionary<string, double> GetAllActivityModifiersFromDatabase()
        {
            Dictionary<string, double> activityModifiers = new Dictionary<string, double>();

            // Izveidojam savienojuma objektu ar datubāzi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Atveram savienojumu
                connection.Open();

                // Izveidojam SQL vaicājumu, lai iegūtu visus koeficientus
                string query = "SELECT ActivityLevel, Coefficient FROM ActivityCoefficients";

                // Izveidojam komandu objektu, lai izpildītu vaicājumu
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Izveidojam lasītāju, lai izlasītu rezultātus no datubāzes
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Pārskatam katru rindiņu rezultātu kopā
                        while (reader.Read())
                        {
                            // Izgūstam aktivitātes līmeni un koeficientu no rindiņas
                            string activityLevel = reader.GetString(0);
                            double coefficient = reader.GetDouble(1);

                            // Pievienojam iegūtos datus vārdnīcai
                            activityModifiers.Add(activityLevel, coefficient);
                        }
                    }
                }
            }

            // Atgriežam vārdnīcu ar iegūtajiem aktivitātes līmeņa koeficientiem
            return activityModifiers;
        }

        private string GetSelectedActivityLevel()
        {
            // Atgriežam izvēlēto aktivitātes līmeni, izmantojot radio pogas
            if (sedentaryRadioButton.Checked)
            {
                return "sedentary";
            }
            else if (moderatelyActiveRadioButton.Checked)
            {
                return "moderatelyActive";
            }
            else if (activeRadioButton.Checked)
            {
                return "active";
            }
            else if (veryActiveRadioButton.Checked)
            {
                return "veryActive";
            }
            else
            {
                // Ja nav atlasīts neviens, atgriežam noklusējuma aktivitātes līmeni
                return "moderatelyActive";
            }
        }
        

        /*private double GetActivityModifier()
        {
            string connectionString = "Data Source=active_koeficienti.db;Version=3;"; // Update connection string with your SQLite database file path
            string query = "SELECT [sedentary], [moderatelyActive], [active], [veryActive] FROM ActivityLevel"; // Query to select the values from columns 1 to 7

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                SQLiteDataReader reader = command.ExecuteReader();

                double activityModifier = 0.6; // Default value

                if (reader.Read())
                {
                    if (sedentaryRadioButton.Checked)
                    {
                        activityModifier = Convert.ToDouble(reader["sedentary"]); // sedentary
                    }
                    else if (moderatelyActiveRadioButton.Checked)
                    {
                        activityModifier = Convert.ToDouble(reader["moderatelyActive"]); // moderatelyActive
                    }
                    else if (activeRadioButton.Checked)
                    {
                        activityModifier = Convert.ToDouble(reader["active"]); // active
                    }
                    else if (veryActiveRadioButton.Checked)
                    {
                        activityModifier = Convert.ToDouble(reader["veryActive"]); // veryActive
                    }
                    // You can add more conditions if you have more radio buttons

                    // Optionally, you can have a default modifier here as well
                }
                reader.Close();

                return activityModifier;
            }
        }

        */


        private double CalculateWaterIntake(int weight, double activityModifier)
        {
            // kalkulācija
            double waterIntake = (weight * 2 / 3) * activityModifier;
            return waterIntake;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

    }
}