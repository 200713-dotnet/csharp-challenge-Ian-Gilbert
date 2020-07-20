using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class TrueTest
    {
        [Theory]
        [InlineData("testset")]
        [InlineData("Kayak")]
        [InlineData("race car")]
        [InlineData("1stats1")]
        [InlineData("1 abc cb a1")]
        [InlineData("racecar!")]
        [InlineData("Hello oll eh?")]
        public void Test1(string input)
        {
            var sut = Class1.PalindromeChecker(input);

            Assert.True(sut);
        }
    }

    public class FalseTest
    {
        [Theory]
        [InlineData("testse")]
        [InlineData("Kyak")]
        [InlineData("race ar")]
        [InlineData("1stats12")]
        [InlineData("1 abc cb a12")]
        [InlineData("5racecar!")]
        public void Test1(string input)
        {
            var sut = Class1.PalindromeChecker(input);

            Assert.False(sut);
        }
    }
}
