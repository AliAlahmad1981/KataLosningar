using System;
using Xunit;

namespace GitHubTestning
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("EnStr�ngH�r", Kata.ToCamelCase("en-str�ng_h�r"));
        }
    }
}
