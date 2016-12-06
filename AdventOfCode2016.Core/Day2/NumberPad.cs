namespace AdventOfCode2016.Core.Day2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A class representation of a number pad.
    /// </summary>
    internal class NumberPad
    {
        /// <summary>
        /// Gets or sets the buttons on the number pad.
        /// </summary>
        internal IEnumerable<Button> Buttons { get; private set; }

        /// <summary>
        /// Gets or sets the current selected button on the number pad.
        /// </summary>
        internal Button CurrentButton { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberPad"/> class.
        /// </summary>
        /// <param name="buttons">The collection of button on the numberpad.</param>
        /// <param name="startButton">The start button.</param>
        internal NumberPad(IEnumerable<Button> buttons, Button startButton)
        {
            if (!buttons.Contains(startButton))
            {
                throw new ArgumentOutOfRangeException("startButton", "buttons must contain startButton");
            }

            Buttons = buttons;
            CurrentButton = startButton;
        }

        /// <summary>
        /// A method to move from the current button.
        /// </summary>
        /// <param name="direction">The direction to move.</param>
        internal void Move(char direction)
        {
            var x = CurrentButton.X;
            var y = CurrentButton.Y;

            switch (direction)
            {
                case 'U':
                    y++;
                    break;
                case 'D':
                    y--;
                    break;
                case 'L':
                    x--;
                    break;
                case 'R':
                    x++;
                    break;
            }

            CurrentButton = Buttons.Any(b => (b.X == x && b.Y == y)) ? Buttons.Where(b => (b.X == x && b.Y == y)).FirstOrDefault() : CurrentButton;
        }
    }
}
