## Description
The Prototype pattern is a creational design pattern that allows you to create copies of existing objects without coupling your code to their specific classes. It provides a mechanism for creating new objects by cloning existing ones and is useful when the creation of an object is costly or when you want to avoid the complexity of initializing an object.

The Prototype pattern is particularly useful in situations where you have a complex object hierarchy and want to create copies of objects dynamically at runtime. It allows you to create new objects by copying existing objects, providing a convenient way to produce variations of objects without the need for explicit subclassing.

In this example, we have a base class called Shape, which serves as the prototype. It contains common properties like X, Y, and Color, and declares an abstract Clone() method that the concrete prototypes will implement. The Draw() method is provided as a common behavior for all shapes.

The Rectangle and Circle classes are concrete implementations of the Shape prototype. They implement the Clone() method by using the MemberwiseClone() method to create a shallow copy of the object. They also provide their specific Draw() implementations.

In this example, we create an instance of the Rectangle class as the original shape. We then clone it to create a new instance using the Clone() method. We modify the color of the cloned shape to showcase that the clone is indeed a separate object. Finally, we call the Draw() method on both the original shape and the cloned shape to verify that they have independent states.

The Prototype pattern allows you to create copies of objects without coupling your code to their specific classes. It provides a way to dynamically create new objects