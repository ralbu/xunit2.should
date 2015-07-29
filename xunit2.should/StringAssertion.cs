using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class StringAssertion
    {
        public static void ShouldContain(this string actual, string substring)
        {
            Assert.Contains(substring, actual);
        }

        public static void ShouldContain(this string actual, string substring, StringComparison comparison)
        {
            Assert.Contains(substring, actual, comparison);
        }

        public static void ShouldNotContain(this string actual, string substring)
        {
            Assert.DoesNotContain(substring, actual);
        }
        public static void ShouldNotContain(this string actual, string substring, StringComparison comparison)
        {
            Assert.DoesNotContain(substring, actual, comparison);
        }

        public static void ShouldStartWith(this string actual, string expectedStartWith)
        {
            Assert.StartsWith(expectedStartWith, actual);
        }
        
        public static void ShouldStartWith(this string actual, string expectedStartWith, StringComparison comparison)
        {
            Assert.StartsWith(expectedStartWith, actual, comparison);
        }

        public static void ShouldEndWith(this string actual, string expectedEndWith)
        {
           Assert.EndsWith(expectedEndWith, actual); 
        }

        public static void ShouldEndWith(this string actual, string expectedEndWith, StringComparison comparison)
        {
           Assert.EndsWith(expectedEndWith, actual, comparison); 
        }

        public static void ShouldMatch(this string actual, string regex)
        {
            Assert.Matches(regex, actual);
        }

        public static void ShouldMatch(this string actual, Regex regex)
        {
            Assert.Matches(regex, actual);
        }

        public static void ShouldNotMatch(this string actual, string regex)
        {
            Assert.DoesNotMatch(regex, actual);
        }

        public static void ShouldNotMatch(this string actual, Regex regex)
        {
            Assert.DoesNotMatch(regex, actual);
        }

        public static void ShouldBeEqual(this string expected, string actual, bool ignoreCase = false,
            bool ignoreLineEndingDifferences = false, bool ignoreWhiteSpaceDifferences = false)
        {
            Assert.Equal(expected, actual, ignoreCase, ignoreLineEndingDifferences, ignoreWhiteSpaceDifferences);
        }
 
    }
}
