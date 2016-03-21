using System.Collections.Generic;
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
        /// Should be equal to using a custom comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be compared.</typeparam>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="comparer">The comparer to compare two objects.</param>
        public static void ShouldBe<T>(this T actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.Equal(expected, actual, comparer);
        }

        /// <summary>
        /// Should be equal within the number of decimal places given by <paramref name="precision"/>.
        /// </summary>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="precision">The number of decimal places (valid values: 0-15)</param>
        public static void ShouldBe(this double actual, double expected, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }

        /// <summary>
        /// Should be equal within the number of decimal places given by <paramref name="precision"/>.
        /// </summary>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="precision">The number of decimal places (valid values: 0-15)</param>
        public static void ShouldBe(this decimal actual, decimal expected, int precision)
        {
            Assert.Equal(expected, actual, precision);
        }

        /// <summary>
        /// Should NOT be equal to. 
        /// </summary>
        /// <typeparam name="T">The type of the object to be compared.</typeparam>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        public static void ShouldNotBe<T>(this T actual, T expected)
        {
            Assert.NotEqual(expected, actual);
        }

        /// <summary>
        /// Should NOT be equal using a custom comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be compared.</typeparam>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="comparer">The comparer to compare two objects.</param>
        public static void ShouldNotBe<T>(this T actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.NotEqual(expected, actual, comparer);
        }

        /// <summary>
        /// Should NOT be equal within the number of decimal places given by <paramref name="precision"/>.
        /// </summary>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="precision">The number of decimal places (valid values: 0-15)</param>
        public static void ShouldNotBe(this double actual, double expected, int precision)
        {
            Assert.NotEqual(expected, actual, precision);
        }

        /// <summary>
        /// Should NOT be equal within the number of decimal places given by <paramref name="precision"/>.
        /// </summary>
        /// <param name="actual">The value to be compared against.</param>
        /// <param name="expected">The expected value.</param>
        /// <param name="precision">The number of decimal places (valid values: 0-15)</param>
        public static void ShouldNotBe(this decimal actual, decimal expected, int precision)
        {
            Assert.NotEqual(expected, actual, precision);
        }
    }
}
