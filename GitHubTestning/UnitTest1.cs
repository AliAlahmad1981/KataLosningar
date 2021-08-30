using System;
using Xunit;

namespace GitHubTestning
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("EnSträngHär", Kata.ToCamelCase("en-sträng_här"));
        }
    }
}
