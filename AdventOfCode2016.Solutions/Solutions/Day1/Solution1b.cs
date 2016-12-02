namespace AdventOfCode2016.Solutions.Day1
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    /// <summary>
    /// A class representation of the solution for day 1 part 2.
    /// </summary>
    internal class Solution1b : Solution1
    {
        /// <inheritdoc />
        protected override string QuestionName
        {
            get { return "Day 1 Part 2"; }
        }

        /// <inheritdoc />
        protected override string Calculate()
        {
            var instructions = Data.Split();

            var position = new Position();

            // create a collection of coordinates visited
            var locations = new HashSet<Coordinate>();
            locations.Add(position.Coordinate);

            var answer = string.Empty;

            // for each instruction
            foreach (var instruction in instructions)
            {
                // turn...
                bool isClockwise = instruction.IndexOf("R") > -1 ? true : false;
                position.Turn(isClockwise);

                // ...then move one block at a time
                int magnitude = int.Parse(Regex.Match(instruction, @"\d+").Value);

                for (var i = 0; i < magnitude; i++)
                {
                    position.Move();

                    // if the location has been visited before return the distance
                    if (locations.Contains(position.Coordinate))
                    {
                        answer = position.Distance().ToString();
                        return answer;
                    }

                    // add the current coordinate to the collection
                    locations.Add(position.Coordinate);
                }
            }

            return answer;
        }
    }
}