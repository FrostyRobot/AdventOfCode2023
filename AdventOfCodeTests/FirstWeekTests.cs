using AdventOfCode.src.DayDrivers;

namespace AdventOfCodeTests
{
    public class FirstWeekTests
    {
        [Fact]
        public void Day1_Solve01_Example()
        {
            Day01 day01 = new Day01("01a");
            Assert.Equal("142", day01.Solve_1());
        }

        [Fact]
        public void Day1_Solve01()
        {
            Day01 day01 = new Day01("01");
            Assert.Equal("55386", day01.Solve_1());
        }


    }
}