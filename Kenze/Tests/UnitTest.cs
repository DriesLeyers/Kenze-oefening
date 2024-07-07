using Kenze;

namespace Tests
{
    public class UnitTest
    {
        [Fact]
        public void CheckIfFindValidsFunctionIsWorkingWithWorkingInputTest()
        {
            var words = new HashSet<string> { "foobar", "fo", "obar", "foo", "bar" };
            var combinations = Program.FindValids(words);

            var expectedCombinations = new HashSet<string>
            {
                "fo+obar=foobar",
                "foo+bar=foobar"
            };

            Assert.Equal(expectedCombinations, combinations);
        }

        [Fact]
        public void CheckIfFindValidsFunctionIsWorkingWitWrongInputTest()
        {
            var words = new HashSet<string> { "foobar", "foo", "obar", "foooo", "barrr" };
            var combinations = Program.FindValids(words);

            var expectedCombinations = new HashSet<string>();

            Assert.Equal(expectedCombinations, combinations);
        }

        [Fact]
        public void ReadDataFromTxtShouldNotThrowErrorTest()
        {
            var inputFile = "C:\\Users\\dries\\Documents\\GitHub\\Kenze-oefening\\Kenze\\Kenze\\input.txt";
            var words = File.ReadAllLines(inputFile);
            var wordSet = new HashSet<string>(words);

            Assert.NotEmpty(wordSet);
        }

        [Fact]
        public void ReadDataFromTxtShouldNotHaveNullValuesTest()
        {
            var inputFile = "C:\\Users\\dries\\Documents\\GitHub\\Kenze-oefening\\Kenze\\Kenze\\input.txt";
            var words = File.ReadAllLines(inputFile);
            var wordSet = new HashSet<string>(words);

            Assert.NotEmpty(wordSet);
            Assert.DoesNotContain(null, wordSet);
        }
    }
}
