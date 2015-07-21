using System;
using System.Collections.Generic;
using Xunit;

namespace Xunit2.Should
{
    public static class RangeAssertion
    {
        public static void ShouldBeInRange<T>(this T actual, T low, T high) where T : IComparable
        {
            Assert.InRange(actual, low, high);
        }

        public static void ShouldBeInRange<T>(this T actual, T low, T high, IComparer<T> comparer) where T : IComparable
        {
            Assert.InRange(actual, low, high, comparer);
        }

        public static void ShouldNotBeInRange<T>(this T actual, T low, T high) where T : IComparable
        {
            Assert.NotInRange(actual, low, high);
        }

        public static void ShouldNotBeInRange<T>(this T actual, T low, T high, IComparer<T> comparer) where T : IComparable
        {
            Assert.NotInRange(actual, low, high, comparer);
        }
    }
}