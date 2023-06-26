## Description
The Observer pattern is a behavioral design pattern that establishes a one-to-many dependency between objects, where changes in one object (subject) are automatically propagated to other objects (observers) that have subscribed to it. It allows for loose coupling between objects, promoting a highly flexible and maintainable system.

The Observer pattern is useful in scenarios where you need to maintain consistency between multiple objects or components when the state of one object changes. It is particularly valuable when you have a subject object whose state changes frequently, and you want other objects to be notified and updated accordingly.

In this example, we have the ISubject interface, which represents the subject interface that both the concrete subject (WeatherStation) and the observers implement. The subject maintains a list of observers and provides methods to attach, detach, and notify them.

The WeatherStation class is the concrete subject that represents a weather station. It has a Temperature property, which is the subject's state that can change over time. When the temperature changes, the subject notifies all the attached observers by calling their Update() method.

The IObserver interface represents the observer interface that all observers must implement. It declares the Update() method, which is called by the subject to update the observer with the new temperature.

The PhoneDisplay and TVDisplay classes are concrete observers that implement the IObserver interface. They define how they should react when the temperature changes. In this example, they simply print a message indicating the new temperature on the respective displays.

In this example, we create a WeatherStation object and two display objects: PhoneDisplay and TVDisplay. We attach both displays to the weather station as observers. When the temperature of the weather station changes, it notifies all the attached observers, and they react accordingly by printing the updated temperature.

The Observer pattern enables objects to maintain consistency and react to changes in a decoupled manner. It promotes loose coupling between subjects and observers, allowing for dynamic and flexible systems. It is useful in scenarios where you need to propagate changes from one object to multiple dependent objects.