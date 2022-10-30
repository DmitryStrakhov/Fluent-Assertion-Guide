using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class IntrospectionGuide {
    [Test]
    public void PropertiesTest() {
        Type xType = typeof(X);
        xType.Properties().Should().BeDecoratedWith<MarkerAttribute>();
    }
    [Test]
    public void MethodsTest() {
        Type xType = typeof(X);
        xType.Methods().Should().BeVirtual();
    }

    class X {
        [Marker] int Property1 { get; set; }
        [Marker] int Property2 { get; set; }
        [Marker] string? Property3 { get; set; }

        public virtual void Method1() {
        }
        public virtual int Method2(int x) {
            return x;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    sealed class MarkerAttribute : Attribute {
    }
}