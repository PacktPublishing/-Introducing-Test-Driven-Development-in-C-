using System;
using System.Runtime.InteropServices;

namespace EquipmentService
{
    public class EmployeeService
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
