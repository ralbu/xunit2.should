using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Xunit2.Should
{
    public static class ExceptionAssertion
    {
        public static void ShouldThrowException<T>(this T ex, Action action) where T: Exception
        {
            Assert.Throws<T>(action);
        }

        public static void ShouldTrhow<T>(this Action a) where T : Exception
        {
            Assert.Throws<T>(a);
        }
    }
}
