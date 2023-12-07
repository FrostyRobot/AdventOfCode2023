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

        //
        [Fact]
        public void Day1_Part02_SubTest1()
        {
            Assert.Equal(29, Day01.readLine_PartTwo("two1nine"));
            Assert.Equal(48, Day01.readLine_PartTwo("4seventhreekmxsz335eight"));
            Assert.Equal(31, Day01.readLine_PartTwo("jffvtzkbjnkdtvfsfthree431lrpgmtv"));
            Assert.Equal(44, Day01.readLine_PartTwo("fourrrdcl624"));
            Assert.Equal(-1, Day01.readLine_PartTwo("nothinghere"));
            Assert.Equal(22, Day01.readLine_PartTwo("sxqztv22"));
            Assert.Equal(34, Day01.readLine_PartTwo("35448284"));
            Assert.Equal(77, Day01.readLine_PartTwo("7phdp"));
            Assert.Equal(88, Day01.readLine_PartTwo("8ttreight4eight"));
            Assert.Equal(14, Day01.readLine_PartTwo("mhmppdtvfonecrjzlktlnkpzdbqtvtwo4"));
        }

        //
        [Fact]
        public void Day1_Part02_SubTest2()
        {
            Assert.Equal(12, Day01.readLine_PartTwo("onetwo"));
            Assert.Equal(34, Day01.readLine_PartTwo("threefour"));
            Assert.Equal(56, Day01.readLine_PartTwo("fivesix"));
            Assert.Equal(78, Day01.readLine_PartTwo("seveneight"));
            Assert.Equal(99, Day01.readLine_PartTwo("ninenine"));
            Assert.Equal(11, Day01.readLine_PartTwo("oneone"));
            Assert.Equal(22, Day01.readLine_PartTwo("twotwo"));
            Assert.Equal(33, Day01.readLine_PartTwo("threethree"));
            Assert.Equal(44, Day01.readLine_PartTwo("fourfour"));
            Assert.Equal(55, Day01.readLine_PartTwo("fivefive"));
            Assert.Equal(66, Day01.readLine_PartTwo("sixsix"));
            Assert.Equal(77, Day01.readLine_PartTwo("sevenseven"));
            Assert.Equal(88, Day01.readLine_PartTwo("eighteight"));
            Assert.Equal(99, Day01.readLine_PartTwo("ninenine"));     
        }

        [Fact]
        public void Day1_Part02_Actual()
        {
            Day01 day01 = new Day01("01");
            String result = day01.Solve_2();

            //Assert.Equal("55386", day01.Solve_2());
        }
    }
}