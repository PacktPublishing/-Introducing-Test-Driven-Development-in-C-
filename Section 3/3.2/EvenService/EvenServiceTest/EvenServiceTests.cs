using System;
using Xunit;
using EvenService;

namespace EvenServiceTest
{
    public class EvenServiceTests
    {
        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public void IsEvenMethod_EvenNumber_ReturnsTrue(int number)
        {
            var service = new EvenServiceImplementation();
            var result = service.IsEven(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]        
        public void IsEvenMethod_OddNumber_ReturnsFalse(int number)
        {
            var service = new EvenServiceImplementation();
            var result = service.IsEven(number);

            Assert.False(result);
        }
    }
}
