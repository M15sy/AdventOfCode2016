namespace AdventOfCode2016.Core
{
    using System.Collections.Generic;

    public class SolutionManager
    {
        private IList<ISolution> _solutions = new List<ISolution>()
        {
            // new Day1.Solution1a(),
            // new Day1.Solution1b(),
            // new Day2.Solution2a(),
            // new Day2.Solution2b(),
            // new Day3.Solution3a(),
            // new Day3.Solution3b(),
            // new Day4.Solution4a(),
            // new Day4.Solution4b(),
            // new Day5.Solution5a(),
            // new Day5.Solution5b(),
            // new Day6.Solution6a(),
            new Day6.Solution6b()
        };

        public IList<ISolution> AllSolutions
        {
            get { return _solutions; }
        }
    }
}