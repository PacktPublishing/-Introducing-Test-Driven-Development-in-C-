using Xunit;

namespace AutomatedTestingExample
{
    public class NaturalNumberCalculatorTests
    {
        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Subtract(4, 3);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SubtractMethod_SecondLargerThanFirst_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Subtract(4, 5);

            Assert.Equal(0, result);
        }
    }
}
