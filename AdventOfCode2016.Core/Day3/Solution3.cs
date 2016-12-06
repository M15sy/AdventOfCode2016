namespace AdventOfCode2016.Core.Day3
{
    /// <summary>
    /// A base class for day 3 solutions.
    /// </summary>
    internal abstract class Solution3 : SolutionBase
    {
        /// <inheritdoc />
        protected override string DataFileName
        {
            get { return "Day3"; }
        }

        /// <summary>
        /// Returns a value indicating whether the inputted sides gives a valid triangle.
        /// </summary>
        /// <param name="a">Length of the first side.</param>
        /// <param name="b">Length of the second side.</param>
        /// <param name="c">Length of the third side.</param>
        /// <returns>A value indicating whether the inputted sides gives a valid triangle.</returns>
        protected bool isTriangle(int a, int b, int c)
        {
            if (a + b <= c || b + c <= a || c + a <= b)
            {
                return false;
            }

            return true;
        }
    }
}
