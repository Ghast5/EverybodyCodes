using Day4;

namespace Day4Tests
{
    public class HummerStrikesTests
    {
        private readonly Everybody.Codes.ReadInput.ReadFile readInput;
        private readonly HummerStrikes hummerStrikes;
        private readonly string day = "Day4";

        public HummerStrikesTests()
        {
            readInput = new();
            hummerStrikes = new();
        }

        [Fact]
        public void IsExsist()
        {
            Assert.NotNull(hummerStrikes);
        }

        [Theory]
        [InlineData(true, 10)]
        [InlineData(false, 77)]
        public void Passed_Part1(bool isTest, int expected)
        {
            string[] inputs = readInput.LoadInput(day, "Part1", isTest).Split("\n");
            int result = hummerStrikes.GetHummerStrikes(inputs, "Part1");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(true, 10)]
        [InlineData(false, 850737)]
        public void Passed_Part2(bool isTest, int expected)
        {
            string[] inputs = readInput.LoadInput(day, "Part2", isTest).Split("\n");
            int result = hummerStrikes.GetHummerStrikes(inputs, "Part2");

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(true, 8)]
        [InlineData(false, 121708193)]
        public void Passed_Part3(bool isTest, int expected)
        {
            string[] inputs = readInput.LoadInput(day, "Part3", isTest).Split("\n");
            int result = hummerStrikes.GetHummerStrikes(inputs, "Part3");

            Assert.Equal(expected, result);
        }
    }
}