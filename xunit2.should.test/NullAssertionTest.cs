using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class NullAssertionTest
    {
        [Fact]
        public void ShouldNotBeNull()
        {
            object notNullObject = new object();
            notNullObject.ShouldNotBeNull();
        }

        [Fact]
        public void ShouldBeNull()
        {
            object nullObject = null;
            nullObject.ShouldBeNull();
        }
    }
}