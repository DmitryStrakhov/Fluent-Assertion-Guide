using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class BasicGuide {
    [Test]
    public void Test() {
        object x = "ss";

        x.Should().BeSameAs(x);
        x.Should().Be("ss");
        x.Should().BeOfType<string>()
            .Which.Should().StartWith("s")
            .And.EndWith("s");
    }
}