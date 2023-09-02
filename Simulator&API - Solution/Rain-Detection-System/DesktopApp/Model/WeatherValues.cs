using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Model
{
    public class WeatherValues
    {
        public int ID { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public int Light { get; set; }

        public WeatherValues(int id, int temp, int hum, int pa, int lux)
        {
            ID = id;
            Temperature = temp;
            Humidity = hum;
            Pressure = pa;
            Light = lux;
        }
    }
}
