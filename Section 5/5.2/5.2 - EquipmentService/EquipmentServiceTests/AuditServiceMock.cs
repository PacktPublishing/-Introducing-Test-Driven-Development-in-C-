using EquipmentService;

namespace EquipmentServiceTests
{
    public class AuditServiceMock : IAuditService
    {
        public bool WriteFunctionCalled { get; set; } = false;

        public void WriteEmploeeInformation(Employee employee)
        {
            WriteFunctionCalled = true;
        }
    }
}
