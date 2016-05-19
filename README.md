## A fluent assertion library for xUnit.net v2
The library is built as a wrapper on the existing xUnit.net v2 Asserts.

## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/xunit2.should.svg?style=flat)](https://www.nuget.org/packages/xunit2.should/)

https://www.nuget.org/packages/xunit2.should/

    PM> Install-Package xunit2.should

### Assertions
Contains the following assertions
* [Boolean](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/BooleanAssertionTest.cs)
* [Collection](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/CollectionAssertionTest.cs)
* [Equality](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/EqualityAssertionTest.cs)
* [Exception](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/ExceptionAssertionTest.cs)
* [Identity](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/IdentityAssertionTest.cs)
* [Null](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/NullAssertionTest.cs)
* [Range](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/RangeAssertionTest.cs)
* [String](https://github.com/ralbu/xunit2.should/blob/dev/xunit2.should.test/StringAssertionTest.cs)

For more details check the [Unit Test project](https://github.com/ralbu/xunit2.should/tree/dev/xunit2.should.test)

### Examples
```c#
    true.ShouldBeTrue("Error message");

    var frameworks = new List<string> { "nunit", "xunit" };
    frameworks.ShouldContain("xUnit", new StringLowerComparer());

    var frameworks = new List<string> {"xunit", "nunit", "msunit"};
    frameworks.ShouldContain(i => i.Contains("nunit"));

    var frameworks = new[] {"xunit", "nunit", "msunit"};
    frameworks.ShouldAllPass(i => i.ShouldContain("unit"));

    var notEmpty = new[] {"xunit", "nunit"};
    notEmpty.ShouldNotBeEmpty();

    var oneElement = new ArrayList();
    oneElement.Add("xunit");
    oneElement.ShouldContainOneElement();

    2.111223.ShouldBe(2.11144, 3);

    Action action = ThrowCustomException;
    action.ShouldThrow<CustomException>();

    object expected = new object();
    object expectedDifferent = new object();
    expected.ShouldNotBeTheSameAs(expectedDifferent);

    3.ShouldBeLessOrEqualTo(4);

    "xunitTest".ShouldStartWith("xunit");
    "xunit".ShouldNotMatch(new Regex(@"\d"));
```

[![Build status](https://ci.appveyor.com/api/projects/status/github/ralbu/xunit2.should?svg=true)](https://ci.appveyor.com/projects/status/ralbu/xunit2-should)