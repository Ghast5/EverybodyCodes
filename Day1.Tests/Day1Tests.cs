namespace Day1.Tests
{
    public class Day1Tests
    {
        private readonly Battle battle;
        private readonly Everybody.Codes.ReadInput.ReadFile readInput;
        private readonly string day = "Day1";

        public Day1Tests()
        {
            readInput = new();
            battle = new Battle();
        }

        [Fact]
        public void Passed_Part1()
        {
            string input = readInput.LoadInput(day, "Part1", true);
            int result = battle.CountTotalNeededPotions(input, 1);

            Assert.Equal(5, result);
        }

        [Fact]
        public void Passed_Part2()
        {
            string input = readInput.LoadInput(day, "Part2", true);
            int result = 0;

            result += battle.CountTotalNeededPotions(input, 2);

            Assert.Equal(28, result);
        }

        [Theory]
        [InlineData("AAA", 0)]
        [InlineData("xCC", 1)]
        [InlineData("xBx", 2)]
        [InlineData("xxx", 3)]
        public void Passed_Part3(string input, int expect)
        {
            int result = battle.CountXLetters(input);

            Assert.Equal(expect, result);
        }
    }
}