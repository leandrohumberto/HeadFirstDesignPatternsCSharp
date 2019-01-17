namespace DataExporterSimulator
{
    /// <summary>
    /// https://www.codeproject.com/Articles/482196/Understanding-and-Implementing-Template-Method-Des
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormattedData();

            System.Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormattedData();
        }
    }
}
