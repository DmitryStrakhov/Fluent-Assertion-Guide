using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class StringGuide {
    [Test]
    public void Test() {
        string x = "12345";

        x.Should().NotBeNullOrEmpty();
        x.Should().StartWith("1")
            .And.EndWith("5")
            .And.HaveLength(5)
            .And.Match("??3??");
    }
}