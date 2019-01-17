using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataFileProcessing
{
    public class TotalDataFileProcessor : CsvDataFileProcessor
    {
        protected override string ProcessData(string content)
        {
            // Append the titles of the columns
            var sb = new StringBuilder();
            var rows = content.Split('\n');
            var columnNames = rows.First().Split(',');

            foreach (var name in columnNames)
            {
                sb.Append(name.Replace("\r", string.Empty).Replace("\n", string.Empty));
                sb.Append(',');
            }
            
            sb.AppendLine();

            // Creates a dictionary in order to store the sums of the columns
            var totals = new Dictionary<int, double>();

            // Iterate through the rows and their columns, storing the totals into the dictionary
            foreach (var row in rows.Skip(1))
            {
                var columnIndex = 0;
                var columnData = row.Split(',');

                foreach (var datum in columnData)
                {
                    if (!totals.Keys.Contains(columnIndex))
                    {
                        totals.Add(columnIndex, double.Parse(datum));
                    }
                    else
                    {
                        totals[columnIndex] = double.Parse(datum);
                    }

                    columnIndex++;
                }
            }

            // Append the totals in the dictionary to the final string
            foreach (var total in totals.Values)
            {
                sb.Append(total);
                sb.Append(',');
            }

            return sb.ToString();
        }
    }
}
