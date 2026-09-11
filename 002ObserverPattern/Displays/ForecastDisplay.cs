using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            if (temperature > 25 && humidity < 70)
            {
                Console.WriteLine("Mooi weer");
            }
            else
            {
                Console.WriteLine("regen");
            }
        }
    }
}
