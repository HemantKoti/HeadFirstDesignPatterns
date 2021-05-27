namespace ObserverPattern.Observer
{
    public interface IObserver
    {
        public string Update(double temp, double humidity, double pressure);
    }
}