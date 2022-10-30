using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class GuidGuide {
    [Test]
    public void Test() {
        Guid x = new("11111111-2222-3333-4444-999999999999");
        x.Should().Be("11111111-2222-3333-4444-999999999999");
    }
}