using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class ExceptionGuide {
    [Test]
    public void Test() {
        Action action1 = () => throw new InvalidOperationException("message");
        Action action2 = () => { };

        action1.Should().Throw<InvalidOperationException>().WithMessage("??ssa??");
        action2.Should().NotThrow();
    }
}