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
        public void ShouldBeInRangeWithComparer()
        {
            4.ShouldBeInRange(1, 5, new IntComparer());
        }

        [Fact]
        public void ShouldNotBeInRange()
        {
            1.ShouldNotBeInRange(2, 4);
        }

        [Fact]
        public void ShouldNotBeInRangeWithComparer()
        {
            6.ShouldNotBeInRange(1, 5, new IntComparer());
        }

        [Fact]
        public void ShouldBeGreater()
        {
            9.ShouldBeGreaterThan(8);
        }

        [Fact]
        public void ShouldBeGreaterWithComparer()
        {
            7.ShouldBeGreaterThan(4, new IntComparer());
        }

        [Fact]
        public void ShouldBeGreaterOrEqual_Equal()
        {
            1.ShouldBeGreaterOrEqualTo(1);
        }

        [Fact]
        public void ShouldBeGreaterOrEqualWithComparer_Equal()
        {
            3.ShouldBeGreaterOrEqualTo(3, new IntComparer());
        }

        [Fact]
        public void ShouldBeGreaterOrEqual_Greater()
        {
            2.ShouldBeGreaterOrEqualTo(1);
        }

        [Fact]
        public void ShouldBeGreaterOrEqualWithComparer_Greater()
        {
            8.ShouldBeGreaterOrEqualTo(3, new IntComparer());
        }


        [Fact]
        public void ShouldBeLess()
        {
            2.ShouldBeLessThan(5);
        }

        [Fact]
        public void ShouldBeLessWithComparer()
        {
            3.ShouldBeLessThan(4, new IntComparer());
        }

        [Fact]
        public void ShouldBeLessOrEqual_Equal()
        {
            3.ShouldBeLessOrEqualTo(3);
        }

        [Fact]
        public void ShouldBeLessOrEqualWithComparer_Equal()
        {
            4.ShouldBeLessOrEqualTo(4, new IntComparer());
        }

        [Fact]
        public void ShouldBeLessOrEqual_Less()
        {
            3.ShouldBeLessOrEqualTo(4);
        }

        [Fact]
        public void ShouldBeLessOrEqualWithComparer_Less()
        {
            4.ShouldBeLessOrEqualTo(7, new IntComparer());
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