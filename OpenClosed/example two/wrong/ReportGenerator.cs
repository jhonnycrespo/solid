// too much ‘If’ clauses are there and if we want to introduce another new report type
// like ‘Excel’, then you need to write another ‘if’. This class should be open for
// extension but closed for modification. But how to do that!!

namespace OpenClosed.example_two.wrong
{
    class ReportGenerator
    {
        public string ReportType { get; set; }

        public void GenerateReport(Customer customer)
        {
            if (ReportType == "PDF")
            {
                System.Console.WriteLine("generating report in pdf");
            }

            if (ReportType == "HTML")
            {
                System.Console.WriteLine("generating report in html");
            }
        }
    }
}
