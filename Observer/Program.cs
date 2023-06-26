using System;
using System.Collections.Generic;

namespace Observer
{
    // Subject interface
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Observer interface
    public interface IObserver
    {
        void Update(double temperature);
    }

    // Concrete subject
    public class WeatherStation : ISubject
    {
        private double temperature;
        private List<IObserver> observers = new List<IObserver>();

        public double Temperature
        {
            get { return temperature; }
            set
            {
                temperature = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(Temperature);
            }
        }
    }

    // Concrete observers
    public class PhoneDisplay : IObserver
    {
        public void Update(double temperature)
        {
            Console.WriteLine($"Phone Display: Temperature changed to {temperature} degrees");
        }
    }

    public class TVDisplay : IObserver
    {
        public void Update(double temperature)
        {
            Console.WriteLine($"TV Display: Temperature changed to {temperature} degrees");
        }
    }

    class Program
    {
        static void Main()
        {
            var weatherStation = new WeatherStation();
            var phoneDisplay = new PhoneDisplay();
            var tvDisplay = new TVDisplay();

            weatherStation.Attach(phoneDisplay);
            weatherStation.Attach(tvDisplay);

            weatherStation.Temperature = 25.5;
            // Output:
            // Phone Display: Temperature changed to 25.5 degrees
            // TV Display: Temperature changed to 25.5 degrees

            weatherStation.Detach(tvDisplay);

            weatherStation.Temperature = 28.2;
            // Output:
            // Phone Display: Temperature changed to 28.2 degrees
        }
    }
}