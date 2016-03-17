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
    }
}
