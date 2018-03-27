using Moq;
using System;
using EquipmentService;
using Xunit;

namespace EquipmentServiceTests
{
    public class EquipmentServiceTests
    {
        [Fact]
        public void AssignStandardBundleToEmployee_EmployeeId_ReturnsCorrectEmployee()
        {
            var employeeId = new Guid();

            var testItem = new EquipmentItem()
            {
                Name = "Test"
            };
            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);
            var bundleFactory = new Mock<IEquipmentBundleFactory>();
            bundleFactory.Setup(x => x.CreateStandardBundle())
                .Returns(testBundle);

            var employeeService = new Mock<IEmployeeService>();
            var testEmployee = new Employee()
            {
                EmployeeId = employeeId,
                Bundle = testBundle
            };
            employeeService.Setup(x => x.Connect(It.IsAny<Guid>(), It.IsAny<EquipmentBundle>()))
                .Returns(testEmployee);

            var auditService = new Mock<IAuditService>();
            var service = new EquipmentService.EquipmentService(bundleFactory.Object, employeeService.Object, auditService.Object);
            var result = service.AssignStandardBundleToEmployee(employeeId);

            Assert.Equal(employeeId, result.EmployeeId);
            Assert.Single(result.Bundle.Items);
            auditService.Verify(x => x.WriteEmploeeInformation(It.Is<Employee>(y => y == testEmployee)));
        }
    }
}
