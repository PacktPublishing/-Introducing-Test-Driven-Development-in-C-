using NUnit.Framework;

namespace NUnitExample
{
    [TestFixture]
    public class NUnitExample
    {
        [Test]
        public void NUnitMethotd_Example1_Success()
        {
            // Invokes code from the sytem under test.
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void NUnitMethotd_Example2_Success()
        {
            // Invokes code from the sytem under test.
        }
    }
}
