using System;

namespace ReportBuilder
{
    public interface IReportBuilder
    {
        Report CreateReport(DateTime from, DateTime to);
        Report CreateMonthReport(int month, int year);
        Report CreateYearReport(int year);
    }
}
