## Description
The Builder pattern is a creational design pattern that allows you to separate the construction of a complex object from its representation, enabling the same construction process to create different representations. It provides a step-by-step approach to building an object and allows you to create objects with varying configurations.

The Builder pattern is useful when you need to create complex objects that have multiple parts or configurations, and you want to encapsulate the construction logic. It promotes a clear separation between the construction steps and the final object, making the code more readable and maintainable.

In this example, we have a Pizza class representing the product we want to construct. The PizzaBuilder is an abstract builder class that defines the step-by-step construction process through abstract methods like BuildDough(), BuildSauce(), and BuildTopping(). The concrete builders, MargheritaPizzaBuilder and VeggiePizzaBuilder, implement these methods to build specific types of pizzas.

The Waiter class acts as the director, responsible for invoking the builder methods in the correct order and returning the final constructed pizza.

In this example, we create a Waiter instance and set different builders to construct pizzas with different configurations. The ConstructPizza() method invokes the builder's methods to construct the pizza step-by-step. Finally, we retrieve the constructed pizza and display its details.