namespace AdventOfCode2016.Core.Day5
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// A class representation of the solution for day 5 part 2.
    /// </summary>
    internal class Solution5b : Solution5
    {
        public override string QuestionName
        {
            get { return "Day 5: How About a Nice Game of Chess? - Part 2"; }
        }

        public override string Calculate()
        {
            var password = new string[8];
            var lettersFound = 0;
            var i = 0;

            while (lettersFound < 8)
            {
                var comb = Hash(Data + i.ToString());
                if (comb.IndexOf("00000") == 0 && Regex.IsMatch(comb[5].ToString(), "^[0-7]*$"))
                {
                    int pos = int.Parse(comb[5].ToString());
                    if (password[pos] == null)
                    {
                        lettersFound++;
                        password[pos] = comb[6].ToString();
                    }
                }
                i++;
            }

            return password.ToString();
        }
    }
}