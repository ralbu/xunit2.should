using System;
using System.CodeDom;
using System.Collections;
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
            var frameworks = new List<string> {"xunit"};
            frameworks.ShouldContain("xunit");
        }

        [Fact]
        public void ShouldContainWithComparer()
        {
            var frameworks = new List<string> { "nunit", "xunit" };
            frameworks.ShouldContain("xUnit", new StringLowerComparer());
        }

        [Fact]
        public void ShouldContainsWitFilter()
        {
            var frameworks = new List<string> {"xunit", "nunit", "msunit"};

            frameworks.ShouldContain(i => i.Contains("nunit"));
        }

        [Fact]
        public void ShouldContainsElementsWithCriteria()
        {
            var frameworks = new List<string> { "xunit", "nunit"};

            frameworks.ShouldContainElementsWithCriteriaAs(e => e.ShouldBeTheSameAs("xunit"),
                e => e.ShouldBeTheSameAs("nunit"));
        }

        [Fact]
        public void ShouldNotContain()
        {
            var frameworks = new List<string> { "nunit" };
            frameworks.ShouldNotContain("xunit");
        }

        [Fact]
        public void ShouldNotContainWithComparer()
        {
            var frameworks = new List<string> { "xunit", "nunit" };
            frameworks.ShouldNotContain("funit", new StringLowerComparer());
        }

        [Fact]
        public void ShouldNotContainWithFilter()
        {
            var frameworks = new[] {"xunit", "nunit"};
            frameworks.ShouldNotContain(x => x.Contains("msunit"));
        }

        [Fact]
        public void ShouldAllPass()
        {
            var frameworks = new[] {"xunit", "nunit", "msunit"};
            frameworks.ShouldAllPass(i => i.ShouldContain("unit"));
        }

        [Fact]
        public void ShouldBeEmpty()
        {
            var empty = new string[0];
            empty.ShouldBeEmpty();
        }

        [Fact]
        public void ShouldNotBeEmpty()
        {
            var notEmpty = new[] {"xunit", "nunit"};

            notEmpty.ShouldNotBeEmpty();
        }

        [Fact]
        public void ShouldBeEqual()
        {
            var frameworks = new[] {"xunit", "nunit", "msunit"};
            var sameFrameworks = new[] {"xunit", "nunit", "msunit"};
            frameworks.ShouldBeEqual(sameFrameworks);
        }

        [Fact]
        public void ShouldBeEqualWithComparer()
        {
            var frameworks = new[] {"xunit", "nunit"};
            var frameworksUpperCase = new[] {"XUNIT", "NUNIT"};
            frameworks.ShouldBeEqual(frameworksUpperCase, new StringLowerComparer());
        }

        [Fact]
        public void ShouldNotBeEqual()
        {
            var unitTesing = new[] {"xunit", "nunit"};
            var ioc = new[] {"ninject", "autofac"};

            unitTesing.ShouldNotBeEqual(ioc);
        }

        [Fact]
        public void ShouldNotBeEqualWithComparer()
        {
            var frameworksUpperCase = new[] {"xunit", "nunit"};
            var sameFramework = new[] {"xunit", "nunit"};

            frameworksUpperCase.ShouldNotBeEqual(sameFramework, new PrependDash());
        }

        [Fact]
        public void ShouldContainOneElement()
        {
            var oneElement = new ArrayList();
            oneElement.Add("xunit");

            oneElement.ShouldContainOneElement();
        }

        [Fact]
        public void ShouldContainOneElementOfGivenValue()
        {
            var oneElement = new[] {"xunit"};
            oneElement.ShouldContainOneElement("xunit");
        }

        [Fact]
        public void ShouldContainOneElementTyped()
        {
            var oneElement = new[] {"xunit"};
            oneElement.ShouldContainOneElement();
        }

        [Fact]
        public void ShouldContainOneElement

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

    public class PrependDash : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x == "-" + y;
        }

        public int GetHashCode(string ob)
        {
            throw new NotImplementedException();
        }
    }
}
