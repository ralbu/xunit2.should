using Xunit;

namespace Xunit2.Should
{
    public static class BooleanAssertion
    {
        public static void ShouldBeTrue(this bool condition, string message = null)
        {
            Assert.True(condition, message);
        }

        public static void ShouldBeFalse(this bool condition, string message = null)
        {
            Assert.False(condition, message);
        }
    }
}