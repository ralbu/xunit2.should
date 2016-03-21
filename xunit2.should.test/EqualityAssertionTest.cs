using System;
using System.Collections.Generic;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class EqualityAssertionTest
    {
        [Fact]
        public void IntsShouldBeEqual()
        {
            1.ShouldBe(1);
        }

        [Fact]
        public void StringsShouldBeEqual()
        {
            "xunit".ShouldBe("xunit");
        }

        [Fact]
        public void ShouldBeEqualUsingComparer()
        {
            3.ShouldBe(3, new IntEqualityComparer());
        }

        [Fact]
        public void DoubleShouldBeEqual()
        {
            2.111223.ShouldBe(2.11144, 3);
        }

        [Fact]
        public void DecimalsShouldBeEqual()
        {
            0.111223M.ShouldBe(0.11144M, 3);
        }

        [Fact]
        public void IntsShouldNotBeEqual()
        {
            1.ShouldNotBe(2);
        }

        [Fact]
        public void StringsShouldNotBeEqual()
        {
            "xunit".ShouldNotBe("nunit");
        }

        [Fact]
        public void ShouldNotBeEqualUsingComparer()
        {
            1.ShouldNotBe(2, new IntEqualityComparer());
        }
        [Fact]
        public void DoubleShouldNotBeEqual()
        {
            2.111223.ShouldNotBe(2.11244, 3);
        }

        [Fact]
        public void DecimalsShouldNotBeEqual()
        {
            0.111223M.ShouldNotBe(0.11344M, 3);
        }
    }

    public class IntEqualityComparer : IEqualityComparer<int>
    {
        public bool Equals(int x, int y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(int obj)
        {
            throw new NotImplementedException();
        }
    }


}
