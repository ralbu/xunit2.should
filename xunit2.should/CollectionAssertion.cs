using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace Xunit2.Should
{
    public static class CollectionAssertion
    {
        /// <summary>
        /// Should contain a given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The object expected to be in the collection.</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected)
        {
           Assert.Contains(expected, actual);
        }

        /// <summary>
        /// Should contain a given object using an equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected to be in the collection.</param>
        /// <param name="comparer">The equality comparer</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.Contains(expected, actual, comparer);
        }

        /// <summary>
        /// Should contain a given object using a filter to find that object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="filter">The filter used to find the item you're ensuring the collection contains.</param>
        public static void ShouldContain<T>(this IEnumerable<T> actual, Predicate<T> filter)
        {
            Assert.Contains(actual, filter);
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
        /// Should Not contain a given object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected Not to be in the collection.</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected)
        {
            Assert.DoesNotContain(expected, actual);
        }

        /// <summary>
        /// Should Not contain a given object using an equality comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="expected">The object expected Not to be in the collection.</param>
        /// <param name="comparer">The equality comparer</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected, IEqualityComparer<T> comparer)
        {
            Assert.DoesNotContain(expected, actual, comparer);
        }


        /// <summary>
        /// Should Not contain a given object using a filter to find that object.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified.</typeparam>
        /// <param name="actual">The collection to be inspected.</param>
        /// <param name="filter">The filter used to search for the item you're ensuring is Not in the collection.</param>
        public static void ShouldNotContain<T>(this IEnumerable<T> actual, Predicate<T> filter)
        {
            Assert.DoesNotContain(actual, filter);
        }

        /// <summary>
        /// Verifies that all items in the collection pass when executed against action.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="action">The action to test each item against</param>
        public static void ShouldAllPass<T>(this IEnumerable<T> actual, Action<T> action)
        {
            Assert.All(actual, action);
        }

        /// <summary>
        /// Collection should be empty.
        /// </summary>
        /// <param name="actual">The collection to be inspected</param>
        public static void ShouldBeEmpty(this IEnumerable actual)
        {
            Assert.Empty(actual);
        }

        /// <summary>
        /// Collection should not be empty.
        /// </summary>
        /// <param name="actual">The collection to be inspected</param>
        public static void ShouldNotBeEmpty(this IEnumerable actual)
        {
            Assert.NotEmpty(actual);
        }

        /// <summary>
        /// Collections should be equivalent using a default comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The action to test each item against</param>
        public static void ShouldBeEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Collections should be equivalent using a custom comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The action to test each item against</param>
        /// <param name="comparer">The comparer to compare two objects</param>
        public static void ShouldBeEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected, IEqualityComparer<T> comparer)
        {
            Assert.Equal(expected, actual, comparer);
        }

        /// <summary>
        /// Collections elements should not be equivalent.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The action to test each item against</param>
        public static void ShouldNotBeEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected)
        {
            Assert.NotEqual(expected, actual);
        }

        /// <summary>
        /// Collections should not be equivalent using a custom comparer.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The action to test each item against</param>
        /// <param name="comparer">The comparer to compare two objects</param>
        public static void ShouldNotBeEqual<T>(this IEnumerable<T> actual, IEnumerable<T> expected,
            IEqualityComparer<T> comparer)
        {
            Assert.NotEqual(expected, actual, comparer);
        }
        
        /// <summary>
        /// Collection should contain only one element.
        /// </summary>
        /// <param name="actual">The collection to be inspected</param>
        public static void ShouldContainOneElement(this IEnumerable actual)
        {
            Assert.Single(actual);
        }

        /// <summary>
        /// Collection should contain only one element of a given value. The collection may or may not contains
        /// other values.
        /// </summary>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="expected">The value to find in the collection</param>
        public static void ShouldContainOneElement(this IEnumerable actual, object expected)
        {
            Assert.Single(actual, expected);
        }

        /// <summary>
        /// Collection should contain only one element.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        public static void ShouldContainOneElement<T>(this IEnumerable<T> actual)
        {
            Assert.Single(actual);
        }

        /// <summary>
        /// Collection should contain only one element which matches the predicate.
        /// The collection may contain other elements but they should not match the given predicate.
        /// </summary>
        /// <typeparam name="T">The type of the object to be verified</typeparam>
        /// <param name="actual">The collection to be inspected</param>
        /// <param name="predicate">Predicate to match the item</param>
        public static void ShouldContainOneElement<T>(this IEnumerable<T> actual, Predicate<T> predicate)
        {
            Assert.Single(actual, predicate);
        }

    }
}
