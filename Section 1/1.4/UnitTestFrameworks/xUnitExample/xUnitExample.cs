using System;
using Xunit;

namespace xUnitExample
{
    public class xUnitExample : IDisposable
    {
        /// <summary>
        /// Initialization of the test class is done in its constructor.
        /// </summary>
        public xUnitExample()
        {
            // Code that initializes this class
        }

        [Fact]
        public void xUnitMethotd_Example1_Success()
        {
            // Invokes code from the sytem under test.
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void xUnitMethotd_Example2_Success(int value)
        {
            // Invokes code from the sytem under test.
        }

        /// <summary>
        /// Clean up after tests.
        /// </summary>
        public void Dispose()
        {
            // Code that cleans up the test class.
        }
    }
}
