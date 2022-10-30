using System;
using FluentAssertions;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class ExecutionTimeGuide {
    [Test]
    public void Test() {
        Action action = () => { };
        action.ExecutionTime().Should().BeLessThan(1.Seconds());
    }
}