using System;

namespace HiringProcessSimulator
{
    class CSEDepartment : HiringProcess
    {
        protected override void FirstRoundTest()
        {
            Console.WriteLine($"Conduct CSE department Tests.{Environment.NewLine}");
        }

        protected override void TechnicalInterview()
        {
            Console.WriteLine($"Conduct CSE department technical interview.{Environment.NewLine}");
        }
    }
}
