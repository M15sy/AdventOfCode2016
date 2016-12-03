namespace AdventOfCode2016.Core.Day2
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// A base class for day 2 solutions.
    /// </summary>
    internal abstract class Solution2 : SolutionBase
    {
        /// <inheritdoc />
        protected override string DataFileName
        {
            get { return "Day2"; }
        }

        /// <summary>
        /// Gets the buttons on the number pad.
        /// </summary>
        protected abstract IEnumerable<Button> Buttons { get; }

        /// <summary>
        /// Gets the start button.
        /// </summary>
        protected abstract Button StartButton { get; }

        /// <inheritdoc />
        public override string Calculate()
        {
            var instructions = Data.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            var numberPad = new NumberPad(Buttons, StartButton);
            var sb = new StringBuilder();

            foreach (var instruction in instructions)
            {
                var steps = instruction.ToCharArray();

                foreach (var step in steps)
                {
                    numberPad.Move(step);
                }

                sb.Append(numberPad.CurrentButton.Value);
            }

            return sb.ToString();
        }
    }
}
