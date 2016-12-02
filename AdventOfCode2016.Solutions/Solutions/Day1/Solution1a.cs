namespace AdventOfCode2016.Solutions.Day1
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// A class representation of the solution for day 1 part 1.
    /// </summary>
    internal class Solution1a : Solution1
    {
        /// <inheritdoc />
        protected override string QuestionName
        {
            get { return "Day 1 Part 1"; }
        }

        /// <inheritdoc />
        protected override string Calculate()
        {
            var instructions = Data.Split();

            var position = new Position();

            // for each instruction
            foreach (var instruction in instructions)
            {
                // turn...
                bool isClockwise = instruction.IndexOf("R") > -1 ? true : false;
                position.Turn(isClockwise);

                // ...then move
                int magnitude = int.Parse(Regex.Match(instruction, @"\d+").Value);
                position.Move(magnitude);
            }

            // return the number of blocks away the final position is relative to the origin.
            return position.Distance().ToString();
        }
    }
}
