using BillingSystem.Target;
using System;

namespace BillingSystem.Client
{
    /// <summary>
    /// The "Client" class
    /// </summary>
    class ThirdPartyBillingSystem
    {
        private ITarget _employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            _employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            Console.WriteLine("######### Employee List ##########");

            foreach (var item in _employeeSource.GetEmployeeList())
            {
                Console.WriteLine(item);
            }
        }
    }
}
