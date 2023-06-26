## Description

The Decorator pattern is a structural design pattern that allows you to dynamically add new behavior to an object by wrapping it in an object of a decorator class. It provides a flexible alternative to subclassing for extending functionality at runtime.

The Decorator pattern is useful in situations where you want to add additional functionality to an object without modifying its underlying class or altering its existing behavior. It allows you to add new features or modify the behavior of an object by enclosing it in a series of decorator objects, each of which adds or modifies specific behavior.

In this example, we have the ICar interface, which represents the component interface that all cars implement. The BasicCar class is a concrete implementation of the ICar interface.

The CarDecorator class is the base decorator class that implements the ICar interface and holds a reference to the decorated car object. It provides a default implementation of the Assemble() method, which delegates the call to the decorated object.

The SportsCar and LuxuryCar classes are concrete decorators that extend the behavior of the decorated car by adding additional features. They inherit from the CarDecorator class and override the Assemble() method to add their specific features before or after delegating the call to the decorated object.

In this example, we create an instance of the BasicCar class as the base component. We then wrap it with a SportsCar decorator and subsequently wrap it with a LuxuryCar decorator. When we call the Assemble() method on the luxurySportsCar, it invokes the Assemble() methods of the decorators in the correct order, resulting in the addition of features from both the sports car and luxury car decorators.

The Decorator pattern allows you to add or modify the behavior of an object dynamically by wrapping it with decorators. It promotes flexibility, reusability, and extensibility by providing a way to enhance objects at runtime without altering their underlying classes.