using EquipmentService;
using Xunit;

namespace EquipmentServiceTests
{
    public class EquipmentBundleFactoryTests
    {
        [Fact]
        public void CreateStandardBundle_NoConditions_ReturnsCorrectBundle()
        {
            var factory = new EquipmentBundleFactory();
            var standardBundle = factory.CreateStandardBundle();

            Assert.Equal(3, standardBundle.Items.Count);
            Assert.Equal("Monitor", standardBundle.Items[0].Name);
            Assert.Equal("Keyboard", standardBundle.Items[1].Name);
            Assert.Equal("Headset", standardBundle.Items[2].Name);
        }
    }
}
