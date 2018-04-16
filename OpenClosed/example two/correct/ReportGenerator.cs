using System;

// So if you want to introduce a new report type, then just inherit from IReportGeneration.
// So IReportGeneration is open for extension but closed for modification.


namespace OpenClosed.example_two.correct
{
    interface IReportGenerator
    {
        void GenerateReport(Customer customer);
    }

    public class PdfReportGenerator : IReportGenerator
    {
        public void GenerateReport(Customer customer)
        {
            Console.WriteLine("Generating report in PDF");   
        }
    }

    public class HtmlReportGenerator : IReportGenerator
    {
        public void GenerateReport(Customer customer)
        {
            Console.WriteLine("Generating report in HTML");
        }
    }

    public class ExcelReportGenerator : IReportGenerator
    {
        public void GenerateReport(Customer customer)
        {
            Console.WriteLine("Generating report in Excel");
        }
    }
}
