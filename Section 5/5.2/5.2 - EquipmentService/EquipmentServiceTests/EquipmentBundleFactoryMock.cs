using EquipmentService;

namespace EquipmentServiceTests
{
    public class EquipmentBundleFactoryMock : IEquipmentBundleFactory
    {
        public EquipmentBundle CreateStandardBundle()
        {
            var testItem = new EquipmentItem()
            {
                Name = "Test"
            };

            var testBundle = new EquipmentBundle();
            testBundle.Add(testItem);

            return testBundle;
        }
    }
}
