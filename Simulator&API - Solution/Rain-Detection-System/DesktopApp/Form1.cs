using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class Form1 : Form
    {
        public string connectionString = @"Data Source=localhost;Initial Catalog=IOT;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
            dgvWeatherValues.AutoGenerateColumns = false;
        }

        private void SaveData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "INSERT INTO WeatherValues VALUES (@Temp, @Hum, @Pa, @Lux);";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    //command.Parameters.AddWithValue("@ID", len + 1);
                    command.Parameters.AddWithValue("@Temp", nudTemparature.Value);
                    command.Parameters.AddWithValue("@Hum", nudHumidity.Value);
                    command.Parameters.AddWithValue("@Pa", nudPressure.Value);
                    command.Parameters.AddWithValue("@Lux", nudLight.Value);
                    command.ExecuteNonQuery();
                }
                connection.Close();
                LoadData();
            }


        }

        public void ClearData()
        {
            nudTemparature.Value = 18;
            nudHumidity.Value = 30;
            nudPressure.Value = 1000;
            nudLight.Value = 5000;

        }

        private void LoadData()
        {
            List<WeatherValues> values = new List<WeatherValues>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM WeatherValues";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    values.Add(new WeatherValues(
                        (int)reader["ID"],
                        (int)reader["Temperature"],
                        (int)reader["Humidity"],
                        (int)reader["Pressure"],
                        (int)reader["Light"]));

                }
                reader.Close();
                connection.Close();
            }

            values.Reverse();

            dgvWeatherValues.DataSource = values;
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSetValues_Click(object sender, EventArgs e)
        {
            SaveData();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        private void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < (int)nudNumberOfData.Value; i++)
            {
                Thread.Sleep(3000);

                int temp = (int)nudTemparature.Value;
                int hum = (int)nudHumidity.Value;
                int pa = (int)nudPressure.Value;
                int lux = (int)nudLight.Value;

                int randTemp = 0;
                if (temp<0)
                    randTemp = random.Next(-10, temp + 10);
                else
                    randTemp = random.Next(temp-10, temp+11);

                int randHum = random.Next(0, 101);
                int randPa = random.Next(950, 1051);
                int randLux = random.Next(1, 100001);

   
                nudTemparature.Value = randTemp;

                nudHumidity.Value = randHum;

                nudPressure.Value = randPa;

                nudLight.Value = randLux;


                SaveData();
                LoadData();
            }

            MessageBox.Show(nudNumberOfData.Value + " records created");
        }

    }
}
