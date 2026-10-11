namespace Route.OOP05.PartialClasses
{
    // all classes in the file should have the partial keyword
    // all parts must be in the project
    // General Logic for report
    internal partial class Report
    {
        public string Title { get; set; }

        public Report(string title)
        {
            Title = title;
        }

        public void Generate()
        {
            Console.WriteLine("Generating the report");
            PrintReportDetails();
        }

        // helper function
        partial void PrintReportDetails();
    }
}
