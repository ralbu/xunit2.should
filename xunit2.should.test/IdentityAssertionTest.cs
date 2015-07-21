using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class IdentityAssertionTest
    {
        [Fact]
        public void ShouldBeTheSame()
        {
            object expected = new object();
            object expectedTheSame = expected;

            expected.ShouldBeTheSameAs(expectedTheSame);
        }

        [Fact]
        public void ShouldNotBeTheSame()
        {
            object expected = new object();
            object expectedDifferent = new object();

            expected.ShouldNotBeTheSameAs(expectedDifferent);
        }
    }
}
