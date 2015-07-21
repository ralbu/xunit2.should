using Xunit;

namespace Xunit2.Should
{
    public static class NullAssertions
    {
        public static void ShouldNotBeNull(this object objectToAssert)
        {
            Assert.NotNull(objectToAssert);
        }

        public static void ShouldBeNull(this object objectToAssert)
        {
            Assert.Null(objectToAssert);
        }
    }
}