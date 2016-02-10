using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class CollectionAssertion
    {
        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected)
        {
           Assert.Contains(expected, actual);
        }

        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.Contains(expected, actual, comparer);
        }

        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected)
        {
            Assert.DoesNotContain(expected, actual);
        }

        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.DoesNotContain(expected, actual, comparer);
        }

        public static void ShouldContainElementsWithCriteriaAs<T>(this IEnumerable<T> actual, params Action<T>[] elementInspectors)
        {

            Assert.Collection(actual, elementInspectors);


        }

    }
}
