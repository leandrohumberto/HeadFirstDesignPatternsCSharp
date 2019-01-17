namespace DataExporterSimulator
{
    public abstract class DataExporter
    {
        private void ReadData()
        {
            System.Console.WriteLine("Reading the data from SqlServer");
        }

        private void FormatData()
        {
            System.Console.WriteLine("Formating the data as per requirements");
        }

        protected abstract void ExportData();

        public void ExportFormattedData()
        {
            ReadData();
            FormatData();
            ExportData();
        }
    }
}
