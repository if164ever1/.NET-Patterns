using System;

namespace Proxy
{
    // Subject interface
    public interface IImage
    {
        void Display();
    }

    // Real subject
    public class RealImage : IImage
    {
        private readonly string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadImage();
        }

        private void LoadImage()
        {
            Console.WriteLine($"Loading image: {filename}");
        }

        public void Display()
        {
            Console.WriteLine($"Displaying image: {filename}");
        }
    }

    // Proxy
    public class ImageProxy : IImage
    {
        private readonly string filename;
        private RealImage realImage;

        public ImageProxy(string filename) => this.filename = filename;

        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(filename);
            }

            realImage.Display();
        }
    }

    class Program
    {
        static void Main()
        {
            IImage image = new ImageProxy("image.jpg");
            image.Display();
            // Output:
            // Loading image: image.jpg
            // Displaying image: image.jpg
        }
    }
}