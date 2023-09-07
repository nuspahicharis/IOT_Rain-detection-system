using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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

        public async Task SaveDataAsync(int temp, int hum, int pa, int lux)
        {
            await Task.Delay(3000);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = "INSERT INTO WeatherValues VALUES (@Temp, @Hum, @Pa, @Lux);";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Temp", temp);
                    command.Parameters.AddWithValue("@Hum", hum);
                    command.Parameters.AddWithValue("@Pa", pa);
                    command.Parameters.AddWithValue("@Lux", lux);
                    await command.ExecuteNonQueryAsync();
                }
                connection.Close();
            }
        }


        public async Task<List<WeatherValues>> LoadDataAsync()
        {
            List<WeatherValues> values = new List<WeatherValues>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string sql = "SELECT * FROM WeatherValues";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

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

            return values;
        }


        public void ClearData()
        {
            nudTemparature.Value = 18;
            nudHumidity.Value = 30;
            nudPressure.Value = 1000;
            nudLight.Value = 5000;
            nudNumberOfData.Value = 7;
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


        private async void btnAutoGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            btnSetValues.Enabled = false;
            btnClearValues.Enabled = false;

            for (int i = 0; i < (int)nudNumberOfData.Value; i++)
            {

                int temp = (int)nudTemparature.Value;
                int hum = (int)nudHumidity.Value;
                int pa = (int)nudPressure.Value;
                int lux = (int)nudLight.Value;

                int randTemp = 0;

                if (temp<0||temp>40)
                    randTemp = random.Next(-10, 51);
                else
                    randTemp = random.Next(temp-10, temp+11);

                int randHum = random.Next(0, 101);
                int randPa = random.Next(950, 1051);
                int randLux = random.Next(1, 100001);

                

                await SaveDataAsync(randTemp,randHum,randPa,randLux);
                dgvWeatherValues.DataSource = await LoadDataAsync();
            }


            MessageBox.Show(nudNumberOfData.Value + " records created");

            btnSetValues.Enabled = true;
            btnClearValues.Enabled = true;

        }



    }
}
