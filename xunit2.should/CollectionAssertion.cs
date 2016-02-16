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

        /// <summary>
        /// Should contain exactly a given number of elements and elements should meet the criteria provided in the criteria parameter.
        /// </summary>
        /// <typeparam name="T">Type of object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="criteria">The criteria which inspect each element. The total number of criteria should match the number of elements in the collection.</param>
        public static void ShouldContainElementsWithCriteriaAs<T>(this IEnumerable<T> actual, params Action<T>[] criteria)
        {
            Assert.Collection(actual, criteria);
        }

        /// <summary>
        /// Verifies that all items in the collection pass when executed against action.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="action">The action to test each item against</param>
        public static void ShouldAllPass <T>(this IEnumerable<T> actual, Action<T> action)
        {
            Assert.All(actual, action);
        }

    }
}
