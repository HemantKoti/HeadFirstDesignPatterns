using NUnit.Framework;
using ObserverPattern.Display;
using ObserverPattern.Subject;

namespace WeatherMonitoringTest
{
    public class WeatherMonitoringTests
    {
        private WeatherData weatherData;
        private CurrentConditionsDisplay currentConditionsDisplay;
        private StatisticsDisplay statisticsDisplay;
        private ForecastDisplay forecastDisplay;

        private double temperature;
        private double humidity;
        private double pressure;

        [SetUp]
        public void Setup()
        {
            weatherData = new WeatherData();
            currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            statisticsDisplay = new StatisticsDisplay(weatherData);
            forecastDisplay = new ForecastDisplay(weatherData);
        }

        [Test]
        public void WeatherDataObjectCreationTest()
        {
            Assert.AreNotEqual(weatherData, null);
        }

        [Test]
        public void CurrentConditionsDisplayObjectCreationTest()
        {
            Assert.AreNotEqual(currentConditionsDisplay, null);
        }

        [Test]
        public void StatisticsDisplayObjectCreationTest()
        {
            Assert.AreNotEqual(statisticsDisplay, null);
        }

        [Test]
        public void ForecastDisplayObjectCreationTest()
        {
            Assert.AreNotEqual(forecastDisplay, null);
        }

        private string GetCurrentConditionsDisplay()
        {
            return $"Current conditions: {this.temperature}" +
               $"F degrees and {this.humidity}% humidity";
        }

        [Test]
        public void CurrentConditionsDisplaySetTemperatureTest()
        {
            this.temperature = 80.0;
            weatherData.Temperature = this.temperature;

            Assert.AreEqual(currentConditionsDisplay.Display(),
                GetCurrentConditionsDisplay());
        }

        [Test]
        public void CurrentConditionsDisplaySetHumidityTest()
        {
            this.humidity = 65.0;
            weatherData.Humidity = this.humidity;

            Assert.AreEqual(currentConditionsDisplay.Display(),
                GetCurrentConditionsDisplay());
        }

        [Test]
        public void CurrentConditionsDisplaySetPressureTest()
        {
            this.pressure = 30.4;
            weatherData.Pressure = this.pressure;

            Assert.AreEqual(currentConditionsDisplay.Display(),
                GetCurrentConditionsDisplay());
        }
    }
}