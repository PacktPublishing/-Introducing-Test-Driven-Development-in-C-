using System;
using EquipmentService;
using Xunit;

namespace EquipmentServiceTests
{
    public class EmployeeServiceTests
    {
        [Fact]
        public void ConnectEmployerAndEquipmentBundle()
        {
            var item = new EquipmentItem()
            {
                Name = "Monitor"
            };

            var bundle = new EquipmentBundle();
            bundle.Add(item);

            var service = new EmployeeService();

            var result = service.Connect(new Guid(), bundle);

            Assert.Equal(bundle, result.Bundle);
        }
    }
}
