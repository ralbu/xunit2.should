using System.Collections.Generic;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class RangeAssertionTest
    {
        [Fact]
        public void ShouldBeInRange()
        {
            2.ShouldBeInRange(1, 3);
        }

        [Fact]
        public void ShouldNotBeInRange()
        {
            1.ShouldNotBeInRange(2, 4);
        }

        [Fact]
        public void ShouldBeInRangeWithComparer()
        {
            4.ShouldBeInRange(1, 5, new IntComparer());
        }

        [Fact]
        public void ShouldNotBeInRangeWithComparer()
        {
            6.ShouldNotBeInRange(1, 5, new IntComparer());
        }
    }

    public class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }
}