using System;
using System.IO;

namespace DataFileProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var filePath = Path.Combine(desktopPath, "demographics.csv");

            if (File.Exists(filePath))
            {
                CsvDataFileProcessor fileProcessor = new TotalDataFileProcessor();
                fileProcessor.ExportFile(filePath, Path.Combine(desktopPath, "totaloutput.txt"));

                fileProcessor = new MeanDataFileProcessor();
                fileProcessor.ExportFile(filePath, Path.Combine(desktopPath, "meanoutput.txt"));
            }
        }
    }
}
