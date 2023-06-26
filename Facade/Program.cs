using System;

namespace Facade
{
    // Complex subsystem classes
    public class SubsystemA
    {
        public void OperationA()
        {
            Console.WriteLine("Subsystem A: Operation A");
        }
    }

    public class SubsystemB
    {
        public void OperationB()
        {
            Console.WriteLine("Subsystem B: Operation B");
        }
    }

    public class SubsystemC
    {
        public void OperationC()
        {
            Console.WriteLine("Subsystem C: Operation C");
        }
    }

    // Facade class
    public class Facade
    {
        private readonly SubsystemA subsystemA;
        private readonly SubsystemB subsystemB;
        private readonly SubsystemC subsystemC;

        public Facade()
        {
            subsystemA = new SubsystemA();
            subsystemB = new SubsystemB();
            subsystemC = new SubsystemC();
        }

        public void PerformOperation()
        {
            subsystemA.OperationA();
            subsystemB.OperationB();
            subsystemC.OperationC();
        }
    }

    class Program
    {
        static void Main()
        {
            Facade facade = new Facade();
            facade.PerformOperation();
            // Output:
            // Subsystem A: Operation A
            // Subsystem B: Operation B
            // Subsystem C: Operation C
        }
    }
}