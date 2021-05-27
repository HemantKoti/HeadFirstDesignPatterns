using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern.Display
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private WeatherData weatherData;
        private double temperatureSum;
        private double maxTemperature;
        private double minTemperature;
        private int numReadings;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public string Update(double temperature, double humidity, double pressure)
        {
            this.temperatureSum += temperature;
            this.numReadings++;

            if (temperature > this.maxTemperature)
                this.maxTemperature = temperature;

            if (temperature < this.minTemperature)
                this.minTemperature = temperature;

            return Display();
        }

        public string Display()
        {
            return $"Avg/Max/Min temperature = {this.temperatureSum / this.numReadings} / {this.maxTemperature} / {this.minTemperature}";
        }
    }
}
