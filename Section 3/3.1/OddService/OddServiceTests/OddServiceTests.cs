using Xunit;
using OddService;

namespace OddServiceTests
{
    public class OddServiceTests
    {
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsOddMethod_OddNumbers_ReturnsTrue(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsOddMehtod_EvenNumbers_ReturnsFalse(int number)
        {
            var service = new OddServiceImplementation();
            var result = service.IsOdd(number);

            Assert.False(result);
        }
    }
}
