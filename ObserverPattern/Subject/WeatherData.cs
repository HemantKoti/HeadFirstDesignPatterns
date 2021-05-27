using ObserverPattern.Observer;
using System.Collections.Generic;

namespace ObserverPattern.Subject
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> observers;
        private double temperature;
        private double humidity;
        private double pressure;

        public double Temperature
        {
            get => temperature;
            set
            {
                this.temperature = value;
                this.MeasurementsChanged();
            }
        }

        public double Humidity
        {
            get => humidity;
            set
            {
                this.humidity = value;
                this.MeasurementsChanged();
            }
        }

        public double Pressure
        {
            get => pressure;
            set
            {
                this.pressure = value;
                this.MeasurementsChanged();
            }
        }

        public WeatherData()
        {
            this.observers = new();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(this.Temperature, this.Humidity, this.Pressure);
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void MeasurementsChanged()
        {
            this.NotifyObservers();
        }
    }
}