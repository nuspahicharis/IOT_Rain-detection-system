using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

        }



        public void ClearData()
        {
            nudTemparature.Value = 0;
            nudHumidity.Value = 0;
            nudPressure.Value = 1000;
            nudLight.Value = 5000;
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSetValues_Click(object sender, EventArgs e)
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

            dgvWeatherValues.DataSource = values;
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

    
    }
}
