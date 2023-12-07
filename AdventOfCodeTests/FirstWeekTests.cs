using AdventOfCode.src.DayDrivers;

namespace AdventOfCodeTests
{
    public class FirstWeekTests
    {
        [Fact]
        public void Day1_Part01_Example()
        {
            Day01 day01 = new Day01("01a");
            Assert.Equal("142", day01.Solve_1());
        }

        [Fact]
        public void Day1_Part01_Actual()
        {
            Day01 day01 = new Day01("01");
            Assert.Equal("55386", day01.Solve_1());
        }

        [Fact]
        public void Day1_Part02_Example()
        {
            Day01 day01 = new Day01("01b");
            Assert.Equal("281", day01.Solve_2());
        }

        [Fact]
        public void Day1_Part02_Actual()
        {
            Day01 day01 = new Day01("01");
            //Assert.Equal("55386", day01.Solve_2());
        }
    }
}