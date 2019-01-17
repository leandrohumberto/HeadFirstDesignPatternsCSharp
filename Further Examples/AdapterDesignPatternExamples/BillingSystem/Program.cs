using BillingSystem.Adapter;
using BillingSystem.Client;
using System;

namespace BillingSystem
{
    /// <summary>
    /// Source: http://www.dotnettricks.com/learn/designpatterns/adapter-design-pattern-dotnet.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var target = new EmployeeAdapter();
            var client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();

            Console.ReadKey();
        }
    }
}
