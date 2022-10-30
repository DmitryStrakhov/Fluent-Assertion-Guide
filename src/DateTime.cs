using System;
using FluentAssertions;
using FluentAssertions.Extensions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class DateTimeGuide {
    [Test]
    public void Test() {
        DateTime x = new(2022, 10, 24, 23, 39, 0);

        x.Should().BeAfter(1.January(2022))
            .And.HaveMonth(10);
    }
}