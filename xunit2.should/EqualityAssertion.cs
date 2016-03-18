using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class EqualityAssertion
    {
        /// <summary>
        /// Should be equal to. 
        /// </summary>
        /// <typeparam name="T">The type of the object to be compared.</typeparam>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        public static void ShouldBe<T>(this T actual, T expected)
        {
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Should be equal to using comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be compared.</typeparam>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="comparer">The comparer to compare two objects.</param>
        public static void ShouldBe<T>(this T actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.Equal(expected, actual, comparer);
        }

        public static void ShouldBe(this double actual, double expected, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }
        public static void ShouldBe(this decimal actual, double expected, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }
    }
}
