using TokenizerLibrary;
using Xunit;

namespace TokenizerTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("single", new[]{"single"})]
        [InlineData("firstSecond", new[]{"first", "second"})]
        [InlineData("firstSecondThird", new[]{"first", "second", "third"})]
        public void Test1(string input, string[] expected)
        {
            var result = Tokenizer.Tokenize(input);
            Assert.Equal(result, expected);
        }
    }
}
