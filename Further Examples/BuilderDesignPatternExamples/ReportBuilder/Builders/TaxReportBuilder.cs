using System;

namespace ReportBuilder.Builders
{
    class TaxReportBuilder : IReportBuilder
    {
        public Report CreateMonthReport(int month, int year)
        {
            return CreateReport(new DateTime(year, month, 1),
                                   new DateTime(year, month, 1).AddMonths(1).AddSeconds(-1));
        }

        public Report CreateReport(DateTime from, DateTime to)
        {
            return new Report(from, to, false, true, Report.SortingMethod.ByTaxCategory);
        }

        public Report CreateYearReport(int year)
        {
            return CreateReport(new DateTime(year, 1, 1),
                                   new DateTime(year, 12, 31));
        }
    }
}
