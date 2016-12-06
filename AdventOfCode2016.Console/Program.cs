namespace AdventOfCode2016.Console
{
    using System;
    using System.Diagnostics;
    using AdventOfCode2016.Core;
    using static System.FormattableString;

    public static class Program
    {
        private static SolutionManager _solutions;

        public static void Main(string[] args)
        {
            _solutions = new SolutionManager();
            var stopwatch = new Stopwatch();

            foreach (var solution in _solutions.AllSolutions)
            {
                Console.WriteLine(Invariant($"Begin {solution.QuestionName} "));
                stopwatch.Start();
                Console.WriteLine(Invariant($"Answer: {solution.Calculate()}"));
                stopwatch.Stop();
                Console.WriteLine(Invariant($"Time taken: {stopwatch.ElapsedMilliseconds} ms"));
                stopwatch.Reset();
                Console.WriteLine(Invariant($"End {solution.QuestionName}"));
                Console.WriteLine();
            }
        }
    }
}