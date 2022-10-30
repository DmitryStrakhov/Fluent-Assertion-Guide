using System;
using System.Reflection;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class AssemblyGuide {
    [Test]
    public void Test() {
        Assembly coreLibAssembly = typeof(int).Assembly;
        Assembly nunitAssembly = typeof(Assert).Assembly;
        coreLibAssembly.Should().NotReference(nunitAssembly);
    }
}