using System;

namespace Adapter
{
    // Target interface expected by the client
    public interface ITarget
    {
        void Request();
    }

    // Adaptee class
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Specific request from the Adaptee.");
        }
    }

    // Adapter class
    public class Adapter : ITarget
    {
        private readonly Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    class Program
    {
        static void Main()
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);
            target.Request();  // Output: Specific request from the Adaptee.
        }
    }
}

