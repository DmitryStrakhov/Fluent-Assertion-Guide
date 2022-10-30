using System;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class EnumGuide {
    [Test]
    public void Test() {
        MyEnum x = MyEnum.Opt3 | MyEnum.Opt4;

        x.Should().HaveFlag(MyEnum.Opt3)
            .And.NotHaveFlag(MyEnum.Opt2);
    }

    [Flags]
    enum MyEnum {
        Opt1 = 1,
        Opt2 = 2,
        Opt3 = 4,
        Opt4 = 8,
    }
}