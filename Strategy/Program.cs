using System;

namespace Strategy
{
    // Strategy interface
    public interface IShippingStrategy
    {
        double CalculateShippingCost(double weight);
    }

    // Concrete strategies
    public class FedExShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight)
        {
            // Calculation logic for FedEx shipping
            return weight * 2.5;
        }
    }

    public class UPSShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight)
        {
            // Calculation logic for UPS shipping
            return weight * 3.0;
        }
    }

    public class DHLShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight)
        {
            // Calculation logic for DHL shipping
            return weight * 3.5;
        }
    }

    // Context
    public class ShippingContext
    {
        private readonly IShippingStrategy shippingStrategy;

        public ShippingContext(IShippingStrategy shippingStrategy)
        {
            this.shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(double weight)
        {
            return shippingStrategy.CalculateShippingCost(weight);
        }
    }

    class Program
    {
        static void Main()
        {
            var shippingContext = new ShippingContext(new FedExShippingStrategy());
            double weight = 10.5;
            double shippingCost = shippingContext.CalculateShippingCost(weight);
            Console.WriteLine($"Shipping cost: {shippingCost}");
            // Output:
            // Shipping cost: 26.25

            shippingContext = new ShippingContext(new UPSShippingStrategy());
            shippingCost = shippingContext.CalculateShippingCost(weight);
            Console.WriteLine($"Shipping cost: {shippingCost}");
            // Output:
            // Shipping cost: 31.5
        }
    }
}