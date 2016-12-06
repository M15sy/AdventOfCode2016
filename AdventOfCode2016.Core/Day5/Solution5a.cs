namespace AdventOfCode2016.Core.Day5
{
    using System.Text;

    /// <summary>
    /// A class representation of the solution for day 5part 1.
    /// </summary>
    internal class Solution5a : Solution5
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 5: How About a Nice Game of Chess? - Part 1"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var password = new StringBuilder();
            var i = 0;

            while (password.Length < 8)
            {
                var comb = Hash(Data + i.ToString());
                if (comb.IndexOf("00000") == 0)
                {
                    password.Append(comb[5]);
                }
                i++;
            }

            return password.ToString();
        }
    }  
}