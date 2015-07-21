using Xunit;

namespace Xunit2.Should
{
    public static class IdentityAssertion
    {
        public static void ShouldBeTheSameAs(this object expected, object actual)
        {
            Assert.Same(expected, actual);
        }

        public static void ShouldNotBeTheSameAs(this object expected, object actual)
        {
            Assert.NotSame(expected, actual);
        }
    }
}
