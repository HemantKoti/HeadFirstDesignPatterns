using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;

namespace ObserverPattern.Display
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private WeatherData weatherData;
        private double currentPressure;
        private double lastPressure;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public string Display()
        {
            string result = "Forecast: ";
            if (this.currentPressure > this.lastPressure)
                return result + "Improving weather on the way!";
            else if (this.currentPressure == this.lastPressure)
                return result + "More of the same.";
            else if (this.currentPressure < this.lastPressure)
                return result + "Watch out for cooler, rainy weather.";

            return result;
        }

        public string Update(double temp, double humidity, double pressure)
        {
            this.lastPressure = this.currentPressure;
            this.currentPressure = pressure;

            return Display();
        }
    }
}
