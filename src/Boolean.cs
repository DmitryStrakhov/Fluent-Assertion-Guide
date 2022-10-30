using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class BooleanGuide {
    [Test]
    public void Test() {
        bool x = true;

        x.Should().BeTrue();
        x = false;
        x.Should().BeFalse();
    }
}