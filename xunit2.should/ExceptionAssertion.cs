using System;
using System.Runtime.CompilerServices;
using Xunit;

// Visible to tests only because still working on this. Only Actions can be used in a fluent way
[assembly:InternalsVisibleTo("xunit2.should.test")]
namespace Xunit2.Should
{
    public static class ExceptionAssertion
    {
        internal static TException ShouldBeThrownBy<TException>(this TException exception, Func<object> method)
            where TException : Exception
        {
            return Assert.Throws<TException>(method);
        }

        internal static TException ShouldThrow<TException>(this Action action) where TException : Exception
        {
            return Assert.Throws<TException>(action);
        }
    }
}