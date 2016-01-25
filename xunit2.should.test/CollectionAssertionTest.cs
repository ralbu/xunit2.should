using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit2.Should;

namespace xunit2.should.test
{
    public class CollectionAssertionTest
    {
        [Fact]
        public void ShouldContain()
        {
            var collection = new List<string> {"xunit"};
            collection.ShouldContain("xunit");
        }

        [Fact]
        public void ShouldContainWithComparer()
        {
            var collection = new List<string> { "nunit", "xunit" };
            collection.ShouldContain("xUnit", new StringLowerComparer());
        }

        [Fact]
        public void ShouldNotContain()
        {
            var collection = new List<string> { "nunit" };
            collection.ShouldNotContain("xunit");
        }

        [Fact]
        public void ShouldNotContainWithComparer()
        {
            var collection = new List<string> { "xunit", "nunit" };
            collection.ShouldNotContain("funit", new StringLowerComparer());
        }
    }


    public class StringLowerComparer : IEqualityComparer<string>
    {

        public bool Equals(string x, string y)
        {
            return x.ToLower().CompareTo(y.ToLower()) == 0;
        }

        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }

    }
}
