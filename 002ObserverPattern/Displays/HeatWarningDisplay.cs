using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class HeatWarningDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public HeatWarningDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            Display();
        }

        public void Display()
        {
            if (temperature > 30)
            {
                Console.WriteLine("Snike heet");
            }
            else
            {
                Console.WriteLine("niet heel heet");
            }
        }
    }
}
