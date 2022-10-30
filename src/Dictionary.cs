using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class DictionaryGuide {
    [Test]
    public void Test() {
        Dictionary<string, int> x = new Dictionary<string, int>{
            ["1"] = 1,
            ["2"] = 2,
            ["3"] = 3,
            ["4"] = 4,
        };

        x.Should().HaveCount(4)
            .And.ContainKey("1")
            .And.ContainKey("3")
            .And.Contain("2", 2);
    }
}