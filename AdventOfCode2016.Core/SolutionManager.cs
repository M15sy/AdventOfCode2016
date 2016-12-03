namespace AdventOfCode2016.Core
{
    using System.Collections.Generic;

    public class SolutionManager
    {
        private IList<ISolution> _solutions = new List<ISolution>()
        {
            new Day1.Solution1a(),
            new Day1.Solution1b(),
            new Day2.Solution2a(),
            new Day2.Solution2b()
        };

        public IList<ISolution> AllSolutions
        {
            get { return _solutions; }
        }
    }
}