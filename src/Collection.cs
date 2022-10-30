using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class CollectionGuide {
    [Test]
    public void Test() {
        IEnumerable<int> x = new[] {1, 2, 3, 4, 5, 6};

        x.Should().NotBeNullOrEmpty()
            .And.OnlyContain(v => v > 0)
            .And.BeEquivalentTo(new[] {6, 5, 4, 3, 2, 1})
            .And.BeInAscendingOrder();
    }
}