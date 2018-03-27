using System;
using EquipmentService;

namespace EquipmentServiceTests
{
    public class EmployeeServiceMock : IEmployeeService
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
