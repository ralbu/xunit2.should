using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class BooleanAssertionTest
    {
        [Fact]
        public void ShouldBeTrue()
        {
            true.ShouldBeTrue();
        }

        [Fact]
        public void ShouldBeTrueWithMessage()
        {
            true.ShouldBeTrue("Error message");
        }

        [Fact]
        public void NullableShouldBeTrue()
        {
            bool? boolValue = true;

            boolValue.ShouldBeTrue();
        }

        [Fact]
        public void ShouldBeFalse()
        {
            false.ShouldBeFalse();
        }

        [Fact]
        public void ShouldBeFalseWithMessage()
        {
            false.ShouldBeFalse("Error message");
        }

        [Fact]
        public void NullableShouldBeFalse()
        {
            bool? boolValue = false;

            boolValue.ShouldBeFalse();
        }
    }
}