namespace AdventOfCode2016.Core
{
    public interface ISolution
    {
        /// <summary>
        /// Gets the name of the question.
        /// </summary>
        string QuestionName { get; }

        /// <summary>
        /// A method that calculates the answer.
        /// </summary>
        /// <returns>The calculated answer as a <see cref="string"/>.</returns>
        string Calculate();
    }
}
