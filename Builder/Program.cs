using System;

// Product class
public class Pizza
{
    public string? Dough { get; set; }
    public string? Sauce { get; set; }
    public string? Topping { get; set; }

    public void Display()
    {
        Console.WriteLine($"Pizza with {Dough} dough, {Sauce} sauce, and {Topping} topping.");
    }
}

// Abstract builder
public abstract class PizzaBuilder
{
    protected Pizza? pizza;

    public void CreatePizza()
    {
        pizza = new Pizza();
    }

    public abstract void BuildDough();
    public abstract void BuildSauce();
    public abstract void BuildTopping();

    public Pizza GetPizza()
    {
        return pizza;
    }
}

// Concrete builder 1
public class MargheritaPizzaBuilder : PizzaBuilder
{
    public override void BuildDough()
    {
        pizza.Dough = "Thin crust";
    }

    public override void BuildSauce()
    {
        pizza.Sauce = "Tomato";
    }

    public override void BuildTopping()
    {
        pizza.Topping = "Cheese and basil";
    }
}

// Concrete builder 2
public class VeggiePizzaBuilder : PizzaBuilder
{
    public override void BuildDough()
    {
        pizza.Dough = "Whole wheat crust";
    }

    public override void BuildSauce()
    {
        pizza.Sauce = "Pesto";
    }

    public override void BuildTopping()
    {
        pizza.Topping = "Assorted vegetables";
    }
}

// Director
public class Waiter
{
    private PizzaBuilder? pizzaBuilder;

    public void SetPizzaBuilder(PizzaBuilder builder)
    {
        pizzaBuilder = builder;
    }

    public void ConstructPizza()
    {
        pizzaBuilder.CreatePizza();
        pizzaBuilder.BuildDough();
        pizzaBuilder.BuildSauce();
        pizzaBuilder.BuildTopping();
    }

    public Pizza GetPizza()
    {
        return pizzaBuilder.GetPizza();
    }
}

class Program
{
    static void Main()
    {
        Waiter waiter = new Waiter();

        PizzaBuilder margheritaBuilder = new MargheritaPizzaBuilder();
        waiter.SetPizzaBuilder(margheritaBuilder);
        waiter.ConstructPizza();
        Pizza margheritaPizza = waiter.GetPizza();
        margheritaPizza.Display();  // Output: Pizza with Thin crust dough, Tomato sauce, and Cheese and basil topping.

        PizzaBuilder veggieBuilder = new VeggiePizzaBuilder();
        waiter.SetPizzaBuilder(veggieBuilder);
        waiter.ConstructPizza();
        Pizza veggiePizza = waiter.GetPizza();
        veggiePizza.Display();  // Output: Pizza with Whole wheat crust dough, Pesto sauce, and Assorted vegetables topping.
    }
}
