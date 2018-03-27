using SRP;
using Xunit;

namespace SRPTests
{
    public class EntityTests
    {
        [Fact]
        public void GetNewValueBasedOnType_EntityType0_ReturnsUnchangedValue()
        {
            var entity = new Entity()
            {
                Type = EntityType.Type0,
                Value = 11
            };

            var newValue = entity.GetNewValueBasedOnType();

            Assert.Equal(11, newValue);
        }

        [Fact]
        public void GetNewValueBasedOnType_EntityType1_ReturnsDoubledValue()
        {
            var entity = new Entity()
            {
                Type = EntityType.Type1,
                Value = 11
            };

            var newValue = entity.GetNewValueBasedOnType();

            Assert.Equal(22, newValue);
        }

        [Fact]
        public void GetNewValueBasedOnType_EntityType2_ReturnsTrippledValue()
        {
            var entity = new Entity()
            {
                Type = EntityType.Type2,
                Value = 11
            };

            var newValue = entity.GetNewValueBasedOnType();

            Assert.Equal(33, newValue);
        }
    }
}
