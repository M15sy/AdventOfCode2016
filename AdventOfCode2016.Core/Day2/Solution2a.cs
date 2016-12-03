namespace AdventOfCode2016.Core.Day2
{
    using System.Collections.Generic;

    /// <summary>
    /// A class representation of the solution for day 2 part 1.
    /// </summary>
    internal class Solution2a : Solution2
    {
        // 1 2 3
        // 4 5 6
        // 7 8 9
        private static IEnumerable<Button> _buttons = new List<Button>() {
                                                                              new Button(2,0,"9"),
                                                                              new Button(1,0,"8"),
                                                                              new Button(0,0,"7"),
                                                                              new Button(2,1,"6"),
                                                                              new Button(1,1,"5"),
                                                                              new Button(0,1,"4"),
                                                                              new Button(2,2,"3"),
                                                                              new Button(1,2,"2"),
                                                                              new Button(0,2,"1"),
                                                                          };

        private static Button _startButton = new Button(1, 1, "5");

        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 2 Part 1"; }
        }

        /// <inheritdoc />
        protected override IEnumerable<Button> Buttons
        {
            get { return _buttons; }
        }

        /// <inheritdoc />
        protected override Button StartButton
        {
            get { return _startButton; }
        }
    }
}