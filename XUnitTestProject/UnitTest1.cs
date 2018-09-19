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

        // test for: 
        
//	A ‘dot’ must be used as decimal separator.

//	Numeric values must be indicated without leading or trailing blanks or zeros; 
//  for the numeric data elements, when reported value is <1, 
//  the leading zero before the ‘dot’ (the decimal separator) has to be entered.

    }
}
