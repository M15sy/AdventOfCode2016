namespace AdventOfCode2016.Core.Day2
{
    /// <summary>
    /// A structure representing a button.
    /// </summary>
    public struct Button
    {
        public int X;

        public int Y;

        public string Value;

        public Button(int x, int y, string value)
        {
            X = x;
            Y = y;
            Value = value;
        }
    }
}
