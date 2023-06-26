using System;

namespace TemplateMethod
{
    // Abstract class defining the template method
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            FormatData();
            DisplayReport();
        }

        protected abstract void CollectData();
        protected abstract void FormatData();

        private void DisplayReport()
        {
            Console.WriteLine("Displaying report...");
        }
    }

    // Concrete subclass implementing specific steps
    public class PDFReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for PDF report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for PDF report...");
        }
    }

    // Concrete subclass implementing specific steps
    public class ExcelReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for Excel report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for Excel report...");
        }
    }

    class Program
    {
        static void Main()
        {
            ReportGenerator pdfReportGenerator = new PDFReportGenerator();
            pdfReportGenerator.GenerateReport();
            // Output:
            // Collecting data for PDF report...
            // Formatting data for PDF report...
            // Displaying report...

            ReportGenerator excelReportGenerator = new ExcelReportGenerator();
            excelReportGenerator.GenerateReport();
            // Output:
            // Collecting data for Excel report...
            // Formatting data for Excel report...
            // Displaying report...
        }
    }
}