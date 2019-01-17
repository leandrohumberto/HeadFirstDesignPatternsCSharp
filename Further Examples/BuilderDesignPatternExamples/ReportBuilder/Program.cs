using ReportBuilder.Builders;
using System;

namespace ReportBuilder
{
    /// <summary>
    /// <see cref="https://scottlilly.com/c-design-patterns-the-builder-pattern/"/>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IReportBuilder builder = new TaxReportBuilder();

            Report currentMonthTaxReport = builder.CreateMonthReport(4, 2017);
            Console.WriteLine(currentMonthTaxReport.ToString());

            Report currentYearTaxReport = builder.CreateYearReport(2017);
            Console.WriteLine(currentYearTaxReport.ToString());

            builder = new ComissionReportBuilder();

            Report currentMonthCommissionReport = builder.CreateMonthReport(4, 2017);
            Console.WriteLine(currentYearTaxReport.ToString());

            Report currentYearCommissionReport = builder.CreateYearReport(2017);
            Console.WriteLine(currentYearTaxReport.ToString());
        }
    }
}
