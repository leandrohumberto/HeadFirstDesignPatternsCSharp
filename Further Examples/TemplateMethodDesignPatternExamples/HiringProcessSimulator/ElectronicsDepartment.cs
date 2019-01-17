using System;
namespace HiringProcessSimulator
{
    class ElectronicsDepartment : HiringProcess
    {
        protected override void FirstRoundTest()
        {
            Console.WriteLine($"Conduct Electronics department Tests.{Environment.NewLine}");
        }

        protected override void TechnicalInterview()
        {
            Console.WriteLine($"Conduct Electronics department technical interview.{Environment.NewLine}");
        }
    }
}
