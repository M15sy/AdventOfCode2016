﻿namespace AdventOfCode2016.Core.Day2
{
    using System.Collections.Generic;

    /// <summary>
    /// A class representation of the solution for day 2 part 2.
    /// </summary>
    internal class Solution2b : Solution2
    {
        //     1
        //   2 3 4
        // 5 6 7 8 9
        //   A B C
        //     D
        private static IEnumerable<Button> _buttons = new List<Button>() {
                                                                            new Button(2,0,"D"),
                                                                            new Button(1,1,"A"),
                                                                            new Button(2,1,"B"),
                                                                            new Button(3,1,"C"),
                                                                            new Button(0,2,"5"),
                                                                            new Button(1,2,"6"),
                                                                            new Button(2,2,"7"),
                                                                            new Button(3,2,"8"),
                                                                            new Button(4,2,"9"),
                                                                            new Button(1,3,"2"),
                                                                            new Button(2,3,"3"),
                                                                            new Button(3,3,"4"),
                                                                            new Button(2,4,"1")
                                                                        };

        private static Button _startButton = new Button(0, 2, "5");

        /// <inheritdoc />
        public override string QuestionName
        {
            get { return "Day 2: Bathroom Security - Part 2"; }
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
