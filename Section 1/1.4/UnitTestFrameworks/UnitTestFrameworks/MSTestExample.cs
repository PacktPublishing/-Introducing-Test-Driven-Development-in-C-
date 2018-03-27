using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFrameworks
{
    [TestClass]
    public class MSTestExample
    {
        /// <summary>
        /// Initializes this whole test class.
        /// Invoked before every test.
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            // Code that initializes test class.
        }

        [TestMethod]
        public void MSTestMethotd_Example_Success()
        {
            // Invokes code from the sytem under test.
        }

        /// <summary>
        /// Clean up after tests.
        /// Invoked after every test.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            // Code that cleans up the test class.
        }
    }
}
