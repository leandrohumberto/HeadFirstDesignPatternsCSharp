using System.Collections.Generic;

/// <summary>
/// The "ITarget" interface
/// </summary>
namespace BillingSystem.Target
{
    interface ITarget
    {
        IEnumerable<string> GetEmployeeList();
    }
}
