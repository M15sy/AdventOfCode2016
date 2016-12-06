namespace AdventOfCode2016.Core.Day6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A class representation of the solution for day 6 part 1.
    /// </summary>
    internal class Solution6a : Solution6
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 6: Signals and Noise - Part 1"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var rows = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<int, StringBuilder>();

            var firstRow = rows[0];
            for (var i = 0; i < firstRow.Length; i++)
            {
                dictionary.Add(i, new StringBuilder());
            }

            foreach (var row in rows)
            {
                for (var i = 0; i < row.Length; i++)
                {
                    dictionary[i] = dictionary[i].Append(row[i]);
                }
            }

            var answer = new StringBuilder();

            for (var i = 0; i < dictionary.Count; i++)
            {
                var str = dictionary[i].ToString();
                answer.Append(str.GroupBy(s => s).OrderBy(s => -s.Count()).First().Key);
            }

            return answer.ToString();
        }
    }
}
