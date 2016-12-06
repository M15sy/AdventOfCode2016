namespace AdventOfCode2016.Core.Day1
{
    /// <summary>
    /// A structure representing a coordinate in two dimensional space.
    /// </summary>
    internal struct Coordinate
    {
        internal int X;

        internal int Y;

        internal Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}