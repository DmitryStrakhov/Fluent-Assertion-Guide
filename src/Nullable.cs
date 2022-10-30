using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class NullableGuide {
    [Test]
    public void Test() {
        int? x = null;

        x.Should().BeNull();
        x = 5;
        x.Should().NotBeNull();
    }
}