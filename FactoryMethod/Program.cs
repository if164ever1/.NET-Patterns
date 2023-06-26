using System;

public interface ITransport
{
    void Deliver();
}

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck.");
    }
}

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by ship.");
    }
}

public abstract class Logistics
{
    public void PlanDelivery()
    {
        // ... Some planning code ...

        ITransport transport = CreateTransport();
        transport.Deliver();

        // ... Additional delivery planning code ...
    }

    protected abstract ITransport CreateTransport();
}

public class RoadLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Truck();
    }
}

public class SeaLogistics : Logistics
{
    protected override ITransport CreateTransport()
    {
        return new Ship();
    }
}

class Program
{
    static void Main()
    {
        Logistics roadLogistics = new RoadLogistics();
        roadLogistics.PlanDelivery();

        Logistics seaLogistics = new SeaLogistics();
        seaLogistics.PlanDelivery();
    }
}