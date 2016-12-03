namespace AdventOfCode2016.Core.Day1
{
    using System;

    /// <summary>
    /// A class representation of a position.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Position"/> class.
        /// </summary>
        public Position()
        {
            this.CurrentDirection = Directions.North;
            this.Coordinate = new Coordinate(0, 0);
        }

        /// <summary>
        /// Gets or sets the current direction.
        /// </summary>
        public Directions CurrentDirection { get; protected set; }

        /// <summary>
        /// Gets or sets the coordinate.
        /// </summary>
        public Coordinate Coordinate { get; protected set; }

        /// <summary>
        /// A method to turn 90 degrees.
        /// </summary>
        /// <param name="clockwise">A value indicating whether to rotate clockwise or anticlockwise.</param>
        public void Turn(bool clockwise = true)
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
        public virtual void Move(int blocks = 1)
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
        public int Distance()
        {
            return Math.Abs(Coordinate.X) + Math.Abs(Coordinate.Y);
        }
    }
}