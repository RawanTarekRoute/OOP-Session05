namespace Route.OOP05.PartialClasses
{
    internal partial class Report
    {
        public DateTime GeneratedTime { get; set; } = DateTime.Now;

        //partial void PrintReportDetails()
        //{
        //    Console.WriteLine(GeneratedTime.ToString());
        //}
    }
}
