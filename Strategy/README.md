## Description
The Strategy pattern is a behavioral design pattern that allows you to define a family of interchangeable algorithms and encapsulate each one as a separate class. It enables clients to dynamically switch between different algorithms at runtime without modifying the client's code.

The Strategy pattern is useful when you have multiple algorithms or behaviors that can be applied to a particular context or problem. Instead of hard-coding the algorithm within the client code, you encapsulate each algorithm in a separate class and provide a common interface for them. This allows clients to select the desired algorithm at runtime and switch between them easily.

In this example, we have the IShippingStrategy interface, which defines the common interface for all shipping strategies. Each concrete shipping strategy class (FedExShippingStrategy, UPSShippingStrategy, DHLShippingStrategy) implements this interface and provides its own implementation of the CalculateShippingCost() method.

The ShippingContext class represents the context in which the shipping strategy is used. It has a reference to the current shipping strategy and provides a method, CalculateShippingCost(), that delegates the calculation to the selected strategy.

In this example, we create a ShippingContext object with the initial strategy set as FedExShippingStrategy. We calculate the shipping cost for a given weight using the selected strategy. Later, we switch the strategy to UPSShippingStrategy and calculate the shipping cost again.

The Strategy pattern allows you to encapsulate algorithms or behaviors as separate classes and interchange them at runtime. It promotes code reusability, flexibility, and maintainability by decoupling the client code from the specific implementations of algorithms. It is useful in situations where you have multiple algorithms that can be applied to a problem and want to dynamically switch between them.