namespace AdventOfCode2016.Core
{
    using System;
    using System.IO;
    using static System.FormattableString;

    /// <summary>
    /// A base class representing a solution for an Advent of Code question.
    /// </summary>
    internal abstract class SolutionBase : ISolution
    {
        private string _data;

        /// <summary>
        /// Gets the data.
        /// </summary>
        protected string Data
        {
            get
            {
                if (string.IsNullOrEmpty(_data))
                {
                    string filepath = Invariant($@"{AppDomain.CurrentDomain.BaseDirectory}/App_Data/{DataFileName}.txt");

                    if (File.Exists(filepath))
                    {
                        _data = File.ReadAllText(filepath);
                    }
                }

                return _data;
            }
        }

        /// <summary>
        /// Gets the data file name.
        /// </summary>
        protected abstract string DataFileName { get; }

        /// <summary>
        /// Gets the name of the question.
        /// </summary>
        public abstract string QuestionName { get; }

        /// <summary>
        /// A method that calculates the answer.
        /// </summary>
        /// <returns>The calculated answer as a <see cref="string"/>.</returns>
        public abstract string Calculate();
    }
}