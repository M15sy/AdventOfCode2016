namespace AdventOfCode2016.Core.Day2
{
    /// <summary>
    /// A structure representing a button.
    /// </summary>
    internal struct Button
    {
        internal int X;

        internal int Y;

        internal string Value;

        internal Button(int x, int y, string value)
        {
            X = x;
            Y = y;
            Value = value;
        }
    }
}
