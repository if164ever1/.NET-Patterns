## Description
The Template Method pattern is a behavioral design pattern that defines the skeleton of an algorithm in a base class and allows subclasses to override certain steps of the algorithm without changing its overall structure. It enables you to define a template for an algorithm while allowing specific steps to be implemented by derived classes.

The Template Method pattern is useful in situations where you have an algorithm that follows a common sequence of steps, but the implementation of certain steps may vary across subclasses. It provides a way to define the overall algorithm structure in a base class, while delegating the implementation of specific steps to subclasses.

In this example, we have the ReportGenerator class, which is an abstract class defining the template method GenerateReport(). The GenerateReport() method provides the overall algorithm structure by calling the following steps in order: CollectData(), FormatData(), and DisplayReport().

The CollectData() and FormatData() methods are declared as abstract, which means that their implementation is deferred to the concrete subclasses. This allows each subclass to provide its own implementation for these steps.

The PDFReportGenerator and ExcelReportGenerator classes are concrete subclasses that inherit from ReportGenerator. They override the CollectData() and FormatData() methods to provide their specific implementation.

In this example, we create instances of PDFReportGenerator and ExcelReportGenerator and call the GenerateReport() method on each. The template method GenerateReport() follows the predefined sequence of steps, and the specific implementations of CollectData() and FormatData() are executed based on the concrete subclass.

The Template Method pattern provides a way to define the overall structure of an algorithm while allowing specific steps to be implemented by subclasses. It promotes code reuse, extensibility, and consistency across different implementations of the algorithm. It is useful in scenarios where you have a common algorithm but need flexibility in implementing specific steps.