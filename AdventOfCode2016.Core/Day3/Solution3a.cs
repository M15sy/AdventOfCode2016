namespace AdventOfCode2016.Core.Day3
{
    using System;

    /// <summary>
    /// A class representation of the solution for day 3 part 1.
    /// </summary>
    internal class Solution3a : Solution3
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 3: Squares With Three Sides - Part 1"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var triangles = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            foreach (var triangle in triangles)
            {
                var sides = triangle.Split(null as char[], StringSplitOptions.RemoveEmptyEntries);

                if (isTriangle(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2])))
                {
                    counter++;
                }
            }

            return counter.ToString();
        }
    }
}
