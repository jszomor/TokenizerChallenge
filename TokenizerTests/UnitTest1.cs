using TokenizerLibrary;
using Xunit;

namespace TokenizerTests
{
  public class UnitTest1
  {
    [Theory]
    [InlineData("single", new[] { "single" })]
    [InlineData("firstSecond", new[] { "first", "Second" })]
    [InlineData("firstS", new[] { "first", "S" })]
    [InlineData("firstSecondThird", new[] { "first", "Second", "Third" })]
    public void Test1(string input, string[] expected)
    {
      var tokenizer = new Tokenizer(input);
      var result = tokenizer.Tokenize();

      Assert.Equal(expected, result);
    }
  }
}
