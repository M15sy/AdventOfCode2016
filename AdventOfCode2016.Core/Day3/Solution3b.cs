namespace AdventOfCode2016.Core.Day3
{
    using System;

    /// <summary>
    /// A class representation of the solution for day 3 part 2.
    /// </summary>
    internal class Solution3b : Solution3
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 3: Squares With Three Sides - Part 2"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var rows = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int counter = 0;

            for (var i = 0; i < rows.Length; i = i + 3)
            {
                var row1 = rows[i].Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
                var row2 = rows[i + 1].Split(null as char[], StringSplitOptions.RemoveEmptyEntries);
                var row3 = rows[i + 2].Split(null as char[], StringSplitOptions.RemoveEmptyEntries);

                for (var j = 0; j < 3; j++)
                {
                    if (isTriangle(int.Parse(row1[j]), int.Parse(row2[j]), int.Parse(row3[j])))
                    {
                        counter++;
                    }
                }
            }

            return counter.ToString();
        }
    }
}