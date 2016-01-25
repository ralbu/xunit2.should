using System;
using System.Text.RegularExpressions;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class StringAssertionTest
    {
        [Fact]
        public void ShouldContain()
        {
            "xunit".ShouldContain("unit");
        }

        [Fact]
        public void ShouldContainWithComparison()
        {
            "xunit".ShouldContain("UNIT", StringComparison.CurrentCultureIgnoreCase); }

        [Fact]
        public void ShouldNotContain()
        {
            "xunit".ShouldNotContain("nunit");
        }

        [Fact]
        public void ShouldNotContainWithComparison()
        {
           "xunit".ShouldNotContain("nunit", StringComparison.CurrentCultureIgnoreCase); 
        }

        [Fact]
        public void ShouldStartWith()
        {
            "xunitTest".ShouldStartWith("xunit");
        }

        [Fact]
        public void ShouldStartWithComparison()
        {
            "xunitTest".ShouldStartWith("XUNIT", StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void ShouldEndWith()
        {
            "testxunit".ShouldEndWith("xunit");
        }
        [Fact]
        public void ShouldEndWithComparision()
        {
            "testxunit".ShouldEndWith("xunit", StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        public void ShouldMatch()
        {
            "xunit".ShouldMatch(@"\w");
        }

        [Fact]
        public void ShouldMatchRegEx()
        {
            "xunit".ShouldMatch(new Regex(@"\w"));
        }

        [Fact]
        public void ShouldNotMatch()
        {
            "xunit".ShouldNotMatch(@"\d");
        }

        [Fact]
        public void ShouldNotMatchRegEx()
        {
            "xunit".ShouldNotMatch(new Regex(@"\d"));
        }

        [Fact]
        public void ShouldBeEqual()
        {
            "xunit".ShouldBeEqual("xunit");
        }

        [Fact]
        public void ShouldBeEqualIgnoreCase()
        {
            "xunit".ShouldBeEqual("xUnit", ignoreCase: true);
        }

    }
}
