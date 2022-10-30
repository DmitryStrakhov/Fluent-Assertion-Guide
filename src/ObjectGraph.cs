using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide; 

[TestFixture]
public class ObjectGraphGuide {
    [Test]
    public void Test() {
        X x = new X {
            Field = "field-value",
            Property = 1,
        };

        Y y = new Y {
            FieldName = "field-value",
            Property = 1,
        };

        y.Should().BeEquivalentTo(x, options => options.Excluding(e => e.UnusedProperty)
            .WithMapping<X, Y>(e => e.Field, s => s.FieldName));
    }

    class X {
        public string? Field;
        public int Property { get; set; }
        public int UnusedProperty { get; set; }
    }

    class Y {
        public string? FieldName;
        public int Property { get; set; }
    }
}