using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void DoubleShouldBeEqual()
        {
            2.111223.ShouldBe(2.11144, 3);
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
