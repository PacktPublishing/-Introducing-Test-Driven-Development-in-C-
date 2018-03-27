using System;

namespace EquipmentService
{
    public interface IEmployeeService
    {
        Employee Connect(Guid employGuid, EquipmentBundle bundle);
    }
}
