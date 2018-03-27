using System;

namespace EquipmentService
{
    public class Employee
    {
        public Guid EmployeeId { get; set; }
        public EquipmentBundle Bundle { get; set; }
    }
}
