namespace AutomatedTestingExample
{
    /// <summary>
    /// Calculator for natural numbers.
    /// </summary>
    public class NaturalNumbersCalculator
    {
        /// <summary>
        /// Add function.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns the sum of passed numbers.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtract function.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns difference between passed numbers.</returns>
        public int Subtract(int a, int b)
        {
            if (b > a)
                return 0;

            return a - b;
        }

        /// <summary>
        /// Multiply function.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns the result of multiplication.</returns>
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        /// <summary>
        /// Divide function.
        /// </summary>
        /// <param name="a">First number.</param>
        /// <param name="b">Second number.</param>
        /// <returns>Returns the result of division.</returns>
        public double Divide(int a, int b)
        {
            return a / b;
        }
    }
}
