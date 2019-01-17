using System.IO;

namespace DataFileProcessing
{
    public abstract class CsvDataFileProcessor
    {
        private string LoadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        protected abstract string ProcessData(string content);

        public void ExportFile(string inputFilePath, string outPutFilePath)
        {
            if (!File.Exists(inputFilePath))
            {
                throw new FileNotFoundException();
            }

            var content = LoadFile(inputFilePath);
            var formattedData = ProcessData(content);
            File.WriteAllText(outPutFilePath, formattedData);
        }
    }
}
