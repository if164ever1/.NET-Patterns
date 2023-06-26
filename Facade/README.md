## Description
The Facade pattern is a structural design pattern that provides a simplified interface to a complex system, making it easier to use and understand. It acts as a single entry point to a subsystem or a set of interfaces, providing a higher-level interface that encapsulates the underlying complexity.

The Facade pattern is useful when you have a complex system or a set of classes with intricate dependencies, and you want to provide a simplified interface for clients to interact with. It hides the complexity of the subsystem and provides a unified and easy-to-use interface, reducing coupling and improving code maintainability.

In this example, we have three complex subsystem classes: SubsystemA, SubsystemB, and SubsystemC. Each subsystem class has its own set of operations.

The Facade class acts as the facade or the simplified interface to the subsystem. It encapsulates the complexity of the subsystem by creating instances of the subsystem classes and exposing a single method, PerformOperation(), which internally calls the corresponding methods of the subsystem classes.

In this example, we create an instance of the Facade class and call the PerformOperation() method on it. Behind the scenes, the facade internally calls the corresponding operations of the subsystem classes. This simplifies the interaction with the subsystem and provides a unified interface.

The Facade pattern allows you to hide the complexity of a system or a set of classes behind a simplified interface. It promotes encapsulation, reduces dependencies, and improves code maintainability by providing a higher-level interface to a complex subsystem. It is especially useful when working with large and complex systems where a simplified interface is required.