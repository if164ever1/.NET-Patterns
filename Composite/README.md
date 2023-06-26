## Description
The Composite pattern is a structural design pattern that allows you to compose objects into tree-like structures and work with both individual objects and groups of objects uniformly. It treats individual objects and compositions of objects in a uniform manner, enabling clients to interact with them uniformly.

The Composite pattern is useful when you have a hierarchy of objects and want to treat individual objects and groups of objects in a consistent manner. It allows you to create complex tree structures and perform operations on them recursively, without the need for distinguishing between individual objects and composite objects.

In this example, we have the FileSystemComponent class, which serves as the base component for both individual files (File) and composite directories (Directory). The FileSystemComponent provides a common interface for displaying the components.

The File class represents individual files in the file system and implements the Display() method to display the file's name.

The Directory class represents composite directories that can contain both files and other directories. It maintains a list of FileSystemComponent objects and provides methods to add and remove components. The Display() method is overridden to display the name of the directory and recursively call the Display() method on its components.

In this example, we create a hierarchy of directories and files. We add files and subdirectories to the root directory and add files to the subdirectories. When we call the Display() method on the root directory, it recursively displays the entire file system structure.

The Composite pattern allows you to treat individual objects and compositions of objects uniformly. It enables you to create tree-like structures and perform operations on them in a consistent and recursive manner. It is especially useful when you need to work with hierarchical structures and want to abstract away the differences between individual objects and groups of objects.