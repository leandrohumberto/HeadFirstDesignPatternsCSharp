using System;

namespace HiringProcessSimulator
{
    /// <summary>
    /// http://www.c-sharpcorner.com/UploadFile/b1df45/template-design-pattern-in-C-Sharp/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            HiringProcess hiringProcess = new CSEDepartment();
            Console.WriteLine($"****** Hiring CSE students ******{Environment.NewLine}");
            hiringProcess.HireRefreshers();

            hiringProcess = new ElectronicsDepartment();
            Console.WriteLine($"{Environment.NewLine}****** Hiring CSE students ******{Environment.NewLine}");
            hiringProcess.HireRefreshers();
        }
    }
}
