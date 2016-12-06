namespace AdventOfCode2016.Core.Day4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class representation of the solution for day 4 part 1.
    /// </summary>
    internal class Solution4a : Solution4
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 4: Security Through Obscurity - Part 1"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var rooms = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var total = 0;

            foreach (var room in rooms)
            {
                var chars = new Dictionary<char, int>();
                var openBracket = room.IndexOf('[');
                var lastDash = room.LastIndexOf('-');

                var name = room.Substring(0, lastDash);
                var nameChars = name.Replace("-", string.Empty).ToCharArray();

                var sectorId = room.Substring(lastDash + 1, openBracket - lastDash - 1);
                var checksum = room.Substring(openBracket + 1, room.Length - openBracket - 2);

                foreach (var c in nameChars)
                {
                    if (chars.ContainsKey(c))
                    {
                        chars[c] = chars[c] + 1;
                    }
                    else
                    {
                        chars.Add(c, 1);
                    }
                }

                var orderedChars = chars.OrderBy(c => c.Key).OrderBy(c => -c.Value).ToArray();
                var isRealRoom = true;

                for (var i = 0; i < checksum.Length; i++)
                {
                    if (checksum[i] != orderedChars[i].Key)
                    {
                        isRealRoom = false;
                        break;
                    }
                }

                total = isRealRoom ? total + int.Parse(sectorId) : total;
            }

            return total.ToString();
        }
    }
 }