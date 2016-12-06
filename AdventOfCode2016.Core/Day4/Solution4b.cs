namespace AdventOfCode2016.Core.Day4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using static System.FormattableString;

    /// <summary>
    /// A class representation of the solution for day 4 part 2.
    /// </summary>
    internal class Solution4b : Solution4
    {
        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 4: Security Through Obscurity - Part 2"; }
        }

        /// <inheritdoc />
        public override string Calculate()
        {
            var rooms = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var answer = string.Empty;

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

                var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                if (isRealRoom)
                {
                    var increment = int.Parse(sectorId) % 26;
                    var decryptedName = new StringBuilder();

                    for (var i = 0; i < nameChars.Length; i++)
                    {
                        var letter = nameChars[i];
                        var startIndex = Array.IndexOf(alphabet, letter);
                        var endIndex = startIndex;

                        for (var j = 0; j < increment; j++)
                        {
                            if (endIndex + 1 < alphabet.Length)
                            {
                                endIndex++;
                            }
                            else
                            {
                                endIndex = 0;
                            }
                        }

                        decryptedName.Append(alphabet[endIndex]);
                    }

                    var dname = decryptedName.ToString();

                    if (dname.IndexOf("north") > -1)
                    {
                        answer = Invariant($"{decryptedName.ToString()}: {sectorId}");                        
                        break;
                    }
                }
            }

            return answer;
        }
    }
}