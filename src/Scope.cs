using System;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class ScopeGuide {
    [Test]
    public void Test() {
        int x = 0;
        int y = 1;
        int z = 1;

        using(new AssertionScope()) {
            x.Should().Be(0);
            y.Should().Be(1);
            z.Should().Be(1);
        }
    }
}