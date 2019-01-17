namespace DataExporterSimulator
{
    class ExcelExporter : DataExporter
    {
        protected override void ExportData()
        {
            System.Console.WriteLine("Exporting the data to an Excel file");
        }
    }
}
