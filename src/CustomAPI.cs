using System;
using FluentAssertions;
using FluentAssertions.Execution;
using FluentAssertions.Primitives;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class CustomAPIGuide {
    [Test]
    public void Test() {
        X x = new X();
        x.Data = 11;
        x.Should().MeetCondition()
            .And.MeetAnotherCondition();
    }
}

class X {
    public int Data;
}

static class XExtensions {
    public static XAssertions Should(this X @this) {
        return new XAssertions(@this);
    }
}

class XAssertions : ReferenceTypeAssertions<X, XAssertions> {
    public XAssertions(X instance)
        : base(instance) {
    }
    public AndConstraint<XAssertions> MeetCondition(string because = "", params object[] becauseArgs) {
        Execute.Assertion.BecauseOf(because, becauseArgs)
            .Given(() => Subject.Data)
            .ForCondition(x => x > 5)
            .FailWith("Expected {context:X} to contain X > 5{reason}, but found {0}.", x => x);
        return new AndConstraint<XAssertions>(this);
    }
    public AndConstraint<XAssertions> MeetAnotherCondition(string because = "", params object[] becauseArgs) {
        Execute.Assertion.BecauseOf(because, becauseArgs)
            .Given(() => Subject.Data)
            .ForCondition(x => x > 10)
            .FailWith("Expected {context:X} to contain Data > 10{reason}, but found {0}.", x => x);
        return new AndConstraint<XAssertions>(this);
    }
    protected override string Identifier => "X";
}