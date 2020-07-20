using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("testset")]
        [InlineData("Kayak")]
        [InlineData("race car")]
        [InlineData("1stats1")]
        [InlineData("1 abc cb a1")]
        [InlineData("racecar!")]
        public void Test1(string input)
        {
            var sut = Class1.PalindromeChecker(input);

            Assert.True(sut);
        }
    }
}
