## Description
The Proxy pattern is a structural design pattern that provides a surrogate or placeholder for another object to control its access. It allows you to create a proxy class that acts as an interface to the real object, providing additional functionality or controlling access to the underlying object.

The Proxy pattern is useful in various scenarios, such as:
1. Remote Proxy: When you want to hide the complexity of accessing a remote service or object. The proxy acts as a local representative for the   remote object, handling the communication details and providing a local interface for clients.
2. Virtual Proxy: When you want to create objects on-demand to optimize resource usage. The proxy object acts as a placeholder for expensive resources, creating them only when necessary.
3. Protection Proxy: When you want to control access to sensitive objects by providing an additional layer of security checks. The proxy enforces access control rules before allowing clients to access the real object.

In this example, we have the IImage interface, which represents the subject interface that both the real image (RealImage) and the proxy image (ImageProxy) implement.

The RealImage class is the real subject that performs the actual loading and displaying of the image. It implements the IImage interface and provides the implementation for the Display() method.

The ImageProxy class acts as a proxy for the real image. It also implements the IImage interface and internally holds a reference to the RealImage object. When the Display() method is called on the proxy, it creates the RealImage object on-demand (if it hasn't been created yet) and delegates the Display() call to the real image.

In this example, we create an instance of the ImageProxy class and assign it to the IImage interface. When we call the Display() method on the proxy, it internally creates the RealImage object (if not already created) and delegates the Display() call to it.

The Proxy pattern allows you to control access to an object or add additional functionality by providing a surrogate or placeholder. It is useful in situations where you want to optimize resource usage, provide remote access to objects, or enforce access control. The proxy acts as an intermediary, allowing clients to interact with the real object indirectly.