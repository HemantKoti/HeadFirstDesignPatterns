using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.Display
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private readonly WeatherData weatherData;
        private double temperature;
        private double humidity;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        } 

        public string Display()
        {
            return $"Current conditions: {this.temperature}" +
                $"F degrees and {this.humidity}% humidity";
        }

        public string Update(double temperature, double humidity, double pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            return Display();
        }
    }
}
