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

namespace H2Oreminder
{
    public partial class Form4 : Form
    {


       /* private const string ApiKey = "YOUR_API_KEY";
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<WeatherData> GetWeatherDataAsync(string city)
        {
            string apiUrl = $"{BaseUrl}?q={city}&appid={ApiKey}&units=metric";

            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);
                return weatherData;
            }
            else
            {
                throw new Exception("Failed to retrieve weather data.");
            }
        }
       */
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = weightNumericUpDown.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                if (value >= weightNumericUpDown.Minimum && value <= weightNumericUpDown.Maximum)
                {
                    weightNumericUpDown.Value = value;
                }
                else if (value < weightNumericUpDown.Minimum)
                {
                    weightNumericUpDown.Value = weightNumericUpDown.Minimum;
                }
                else
                {
                    weightNumericUpDown.Value = weightNumericUpDown.Maximum;
                }
            }
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
        

        private double GetActivityModifier() // izmantot šos koeficientus no datubāzes(lai būtu vairāk tabulu)
        {
            // izvēlamies aktīvuma koeficientus
            if (sedentaryRadioButton.Checked)
            {
                return 0.5; // sedentary
            }
            else if (moderatelyActiveRadioButton.Checked)
            {
                return 0.6; // moderatelyActive
            }
            else if (activeRadioButton.Checked)
            {
                return 0.7; // active
            }
            else if (veryActiveRadioButton.Checked)
            {
                return 0.8; // veryActive
            }
            else
            {
                return 0.6; // pēc noklusējuma
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


