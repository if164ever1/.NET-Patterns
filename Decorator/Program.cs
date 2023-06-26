using System;

namespace Decorator
{
    // Component interface
    public interface ICar
    {
        void Assemble();
    }

    // Concrete component
    public class BasicCar : ICar
    {
        public void Assemble()
        {
            Console.WriteLine("Basic Car Assembled.");
        }
    }

    // Base decorator
    public abstract class CarDecorator : ICar
    {
        protected ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public virtual void Assemble()
        {
            car.Assemble();
        }
    }

    // Concrete decorator 1
    public class SportsCar : CarDecorator
    {
        public SportsCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Added features of Sports Car.");
        }
    }

    // Concrete decorator 2
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Added features of Luxury Car.");
        }
    }

    class Program
    {
        static void Main()
        {
            ICar basicCar = new BasicCar();
            ICar sportsCar = new SportsCar(basicCar);
            ICar luxurySportsCar = new LuxuryCar(sportsCar);

            luxurySportsCar.Assemble();
            // Output:
            // Basic Car Assembled.
            // Added features of Sports Car.
            // Added features of Luxury Car.
        }
    }
}