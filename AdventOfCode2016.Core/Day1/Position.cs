namespace AdventOfCode2016.Core.Day1
{
    using System;

    /// <summary>
    /// A class representation of a position.
    /// </summary>
    internal class Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        internal Position()
        {
            this.CurrentDirection = Directions.North;
            this.Coordinate = new Coordinate(0, 0);
        }

        /// <summary>
        /// Gets or sets the current direction.
        /// </summary>
        internal Directions CurrentDirection { get; set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        internal Coordinate Coordinate { get; set; }

        /// <summary>
        /// A method to turn 90 degrees.
        /// </summary>
        /// <param name="clockwise">A value indicating whether to rotate clockwise or anticlockwise.</param>
        internal void Turn(bool clockwise = true)
        {
            if (CurrentDirection == Directions.North && clockwise == false)
            {
                CurrentDirection = Directions.West;
            }
            else if (CurrentDirection == Directions.West && clockwise == true)
            {
                CurrentDirection = Directions.North;
            }
            else
            {
                CurrentDirection = CurrentDirection + (clockwise ? 1 : -1);
            }
        }

        /// <summary>
        /// A method to move forward in the current direction.
        /// </summary>
        /// <param name="blocks">The number of blocks to move.</param>
        internal virtual void Move(int blocks = 1)
        {
            int x = this.Coordinate.X;
            int y = this.Coordinate.Y;

            switch (CurrentDirection)
            {
                case Directions.North:
                    y = y + blocks;
                    break;
                case Directions.East:
                    x = x + blocks;
                    break;
                case Directions.South:
                    y = y - blocks;
                    break;
                case Directions.West:
                    x = x - blocks;
                    break;
            }

            this.Coordinate = new Coordinate(x, y);
        }

        /// <summary>
        /// A method that returns how many blocks away the current position is from the orgin.
        /// </summary>
        /// <returns>A method that returns how many blocks away the current position is from the orgin as an <see cref="int"/>.</returns>
        internal int Distance()
        {
            return Math.Abs(Coordinate.X) + Math.Abs(Coordinate.Y);
        }
    }
}