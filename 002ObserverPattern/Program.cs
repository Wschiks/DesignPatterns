using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            // Create instances of displays 
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatWarningDisplay heatWarningDisplay = new HeatWarningDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);

            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.SetMeasurements(30, 90, 29.2f);
        }
    }
}