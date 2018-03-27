using System.Linq;
using EquipmentService;
using Xunit;

namespace EquipmentServiceTests
{
    public class EquipmentBundleTests
    {
        [Fact]
        public void Add_NewItemPassed_ItemAddedInInternalList()
        {
            var item = new EquipmentItem()
            {
                Name = "Item"
            };

            var bundle = new EquipmentBundle();
            bundle.Add(item);

            Assert.Single(bundle.Items);
            Assert.Equal(item, bundle.Items.Single());
        }
    }
}
