using System;
using FluentAssertions;
using TokenizerLibrary;
using Xunit;

namespace TokenizerTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("a", new[] { "a" })]
        [InlineData("A", new[] { "A" })]
        [InlineData("AB", new[] { "A", "B" })]
        [InlineData("single", new[]{"single"})]
        [InlineData("Single", new[] { "Single" })]
        [InlineData("firstSecond", new[]{"first", "Second"})]
        [InlineData("firstSecondThird", new[]{"first", "Second", "Third"})]
        [InlineData("LMiddleR", new[] { "L", "Middle", "R" })]
        public void Test1(string input, string[] expected)
        {
            var result = Tokenizer.Tokenize(input);
            result.Should().Equal(expected, StringComparer.OrdinalIgnoreCase.Equals);
        }
    }
}
