using Xunit;

namespace AutomatedTestingExample
{
    public class NaturalNumberCalculatorTests
    {
        [Fact]
        public void AddMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Add(1, 2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void SubtractMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Subtract(4, 3);

            Assert.Equal(1, result);
        }

        [Fact]
        public void MultipleMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Multiply(2, 5);

            Assert.Equal(10, result);
        }

        [Fact]
        public void DivideMethod_Numbers_Success()
        {
            var calculator = new NaturalNumbersCalculator();
            var result = calculator.Divide(4, 2);

            Assert.Equal(2, result);
        }
    }
}
