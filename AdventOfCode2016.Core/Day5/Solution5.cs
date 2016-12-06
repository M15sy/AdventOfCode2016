namespace AdventOfCode2016.Core.Day5
{
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// A base class for day 5 solutions.
    /// </summary>
    internal abstract class Solution5 : SolutionBase
    {
        private static MD5 _md5 = MD5.Create();

        /// <inheritdoc />
        protected override string DataFileName
        {
            get { return "Day5"; }
        }

        protected string Hash(string input)
        {
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            byte[] hash = _md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}