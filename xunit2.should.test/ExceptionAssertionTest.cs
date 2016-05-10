using System;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class ExceptionAssertionTest
    {
        [Fact]
        public void ShouldAssertGenericException()
        {
            Action action = ThrowGenericException;

            action.ShouldThrow<ApplicationException>();
        }

        [Fact]
        public void ShouldAssertCustomException()
        {
            Action action = ThrowCustomException;
            action.ShouldThrow<CustomException>();
        }

        private void ThrowGenericException()
        {
            throw new ApplicationException();
        }

        private int ThrowGenericExceptionWithReturn()
        {
            throw new ApplicationException();
        }

        private void ThrowCustomException()
        {
            throw new CustomException("Error message");
        }
    }

    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }

        public override string Message
        {
            get { return "Custom Exception " + base.Message; }
        }
    }
}