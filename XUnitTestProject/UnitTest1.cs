using FluentAssertions;
using System;
using Xunit;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestToCheckIfEverythingWorks()
        {
            string test = "hej";

            test.Should().Be("hej");
        }
    }
}
