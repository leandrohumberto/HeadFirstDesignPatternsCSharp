using BillingSystem.Adaptee;
using BillingSystem.Target;
using System.Collections.Generic;

namespace BillingSystem.Adapter
{
    class EmployeeAdapter : HRSystem, ITarget
    {
        public IEnumerable<string> GetEmployeeList()
        {
            foreach (string[] employee in GetEmployees())
            {
                yield return $"{employee[0]}, {employee[1]}, {employee[1]}\n";
            }
        }
    }
}
