using AdventOfCode;

namespace AdventOfCodeTests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Day01 day01 = new Day01();
            Assert.Equal("142", day01.Solve_1());
        }
    }
}