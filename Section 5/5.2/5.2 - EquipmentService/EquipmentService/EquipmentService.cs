using System;

namespace EquipmentService
{
    public class EquipmentService
    {
        private readonly IEquipmentBundleFactory _bundleFactory;
        private readonly IEmployeeService _employeeService;
        private readonly IAuditService _auditService;

        public EquipmentService(IEquipmentBundleFactory bundleFactory, IEmployeeService employeeService,
            IAuditService auditService)
        {
            _bundleFactory = bundleFactory;
            _employeeService = employeeService;
            _auditService = auditService;
        }

        public Employee AssignStandardBundleToEmployee(Guid employeeId)
        {
            var returnValue = _employeeService.Connect(employeeId, _bundleFactory.CreateStandardBundle());
            _auditService.WriteEmploeeInformation(returnValue);

            return returnValue;
        }
    }
}
