using Xunit;

namespace Xunit2.Should
{
    public static class IdentityAssertion
    {
        /// <summary>
        /// Verifies that two objects are the same instance.
        /// </summary>
        /// <param name="expected">The expected object instance</param>
        /// <param name="actual">The actual object instajce</param>
        public static void ShouldBeTheSameAs(this object expected, object actual)
        {
            Assert.Same(expected, actual);
        }


        /// <summary>
        /// Verifies that two objects are not the same instance.
        /// </summary>
        /// <param name="expected">The expected object instance</param>
        /// <param name="actual">The actual object instajce</param>
        public static void ShouldNotBeTheSameAs(this object expected, object actual)
        {
            Assert.NotSame(expected, actual);
        }
    }
}
