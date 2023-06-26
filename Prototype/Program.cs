using System;

namespace Prototype
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string? Color { get; set; }

        public abstract Shape Clone();

        public virtual void Draw()
        {
            Console.WriteLine($"Drawing a {Color} shape at ({X}, {Y}).");
        }
    }

    // Concrete prototype 1
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} rectangle at ({X}, {Y}) with width {Width} and height {Height}.");
        }
    }

    // Concrete prototype 2
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} circle at ({X}, {Y}) with radius {Radius}.");
        }
    }

    class Program
    {
        static void Main()
        {
            Shape originalShape = new Rectangle
            {
                X = 10,
                Y = 20,
                Color = "Red",
                Width = 100,
                Height = 50
            };

            Shape clonedShape = originalShape.Clone();
            clonedShape.Color = "Blue";

            originalShape.Draw();  // Output: Drawing a Red rectangle at (10, 20) with width 100 and height 50.
            clonedShape.Draw();    // Output: Drawing a Blue rectangle at (10, 20) with width 100 and height 50.
        }
    }
}







