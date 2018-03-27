using System;
using System.Runtime.InteropServices;

namespace EquipmentService
{
    public class EmployeeService : IEmployeeService
    {
        public Employee Connect(Guid employGuid, EquipmentBundle bundle)
        {
            return new Employee()
            {
                EmployeeId = employGuid,
                Bundle = bundle
            };
        }
    }
}
