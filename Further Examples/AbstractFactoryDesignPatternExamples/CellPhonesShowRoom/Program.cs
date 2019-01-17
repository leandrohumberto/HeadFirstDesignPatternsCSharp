using System;

namespace CellPhonesShowRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker checker = new PhoneTypeChecker(Manufacturer.Samsung);

            checker.CheckProducts();

            Console.ReadKey();
            Console.WriteLine();

            checker = new PhoneTypeChecker(Manufacturer.HTC);

            checker.CheckProducts();
            Console.ReadKey();
            Console.WriteLine();

            checker = new PhoneTypeChecker(Manufacturer.Nokia);

            checker.CheckProducts();
            Console.ReadKey();
        }
    }
}
