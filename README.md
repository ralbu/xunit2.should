## A fluent assertion library for xUnit.net v2
The library is built as a wrapper on the existing xUnit.net v2 Asserts.

## The NuGet package [![NuGet Status](http://img.shields.io/nuget/v/xunit2.should.svg?style=flat)](https://www.nuget.org/packages/xunit2.should/)

https://www.nuget.org/packages/xunit2.should/

    PM> Install-Package xunit2.should

### Examples

## Boolean assertion
```c#
    true.ShouldBeTrue();
    
    true.ShouldBeTrue("Error message");

    bool? boolValue = true;
    boolValue.ShouldBeTrue();

    false.ShouldBeFalse()

    false.ShouldBeFalse("Error message");

    bool? boolValue = false;
    boolValue.ShouldBeFalse();
```

[![Build status](https://ci.appveyor.com/api/projects/status/github/ralbu/xunit2.should?svg=true)](https://ci.appveyor.com/projects/status/ralbu/xunit2-should)