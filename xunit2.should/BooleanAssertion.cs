using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class BooleanAssertion
    {
        public static void ShouldBeTrue(this bool val)
        {
            Assert.True(val);
        }
    }
}
