using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class NumericGuide {
    [Test]
    public void Test() {
        double x = 1.51;

        x.Should().BePositive()
            .And.BeGreaterThan(1.5)
            .And.BeApproximately(1.5, 0.05);
    }
}