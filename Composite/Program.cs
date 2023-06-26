using System;

namespace Composite
{
    // Component interface
    public abstract class FileSystemComponent
    {
        public string Name { get; }

        protected FileSystemComponent(string name)
        {
            Name = name;
        }

        public abstract void Display(int depth);
    }

    // Leaf
    public class File : FileSystemComponent
    {
        public File(string name) : base(name)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + " " + Name);
        }
    }

    // Composite
    public class Directory : FileSystemComponent
    {
        private readonly List<FileSystemComponent> components = new();

        public Directory(string name) : base(name)
        {
        }

        public void Add(FileSystemComponent component)
        {
            components.Add(component);
        }

        public void Remove(FileSystemComponent component)
        {
            components.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + "+ " + Name);

            foreach (var component in components)
            {
                component.Display(depth + 2);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var root = new Directory("Root");
            var subDir1 = new Directory("Sub Directory 1");
            var subDir2 = new Directory("Sub Directory 2");
            var file1 = new File("File 1");
            var file2 = new File("File 2");
            var file3 = new File("File 3");

            root.Add(subDir1);
            root.Add(subDir2);
            root.Add(file1);
            subDir1.Add(file2);
            subDir2.Add(file3);

            root.Display(0);
            // Output:
            // + Root
            // --+ Sub Directory 1
            // ---- File 2
            // --+ Sub Directory 2
            // ---- File 3
            // -- File 1
        }
    }
}