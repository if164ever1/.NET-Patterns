using System;

// Abstract product A
public interface IButton
{
    void Render();
}

// Abstract product B
public interface ICheckbox
{
    void Render();
}

// Concrete product A1
public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows button.");
    }
}

// Concrete product A2
public class MacOSButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS button.");
    }
}

// Concrete product B1
public class WindowsCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a Windows checkbox.");
    }
}

// Concrete product B2
public class MacOSCheckbox : ICheckbox
{
    public void Render()
    {
        Console.WriteLine("Rendering a macOS checkbox.");
    }
}

// Abstract factory
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete factory 1
public class WindowsGUIFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}

// Concrete factory 2
public class MacOSGUIFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacOSButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacOSCheckbox();
    }
}

class Program
{
    static void Main()
    {
        IGUIFactory factory;
        IButton button;
        ICheckbox checkbox;

        // Create Windows GUI
        factory = new WindowsGUIFactory();
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();

        button.Render();    // Renders a Windows button
        checkbox.Render();  // Renders a Windows checkbox

        // Create macOS GUI
        factory = new MacOSGUIFactory();
        button = factory.CreateButton();
        checkbox = factory.CreateCheckbox();

        button.Render();    // Renders a macOS button
        checkbox.Render();  // Renders a macOS checkbox
    }
}
