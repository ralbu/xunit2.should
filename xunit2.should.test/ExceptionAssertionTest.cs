using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class ExceptionAssertionTest
    {
        
        [Fact]
        public void Abc()
        {
            MyClass myc = new MyClass();
//            Assert.Throws<ApplicationException>(_testCode);

            

            Action ac = () => { myc.Do(); };
            ac.ShouldTrhow<ApplicationException>();

//            myc.Do();
        }
    }
    public class MyClass
    {

        public void Do()
        {
            throw new ApplicationException("Error here");
        }
    }
}
