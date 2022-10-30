using System;
using System.Xml.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace FluentAssertionGuide;

[TestFixture]
public class XDocumentGuide {
    [Test]
    public void Test() {
        XDocument xDoc = XDocument.Parse(Xml);

        xDoc.Should().HaveRoot("Root")
            .Which.Elements().Should().HaveCount(1);
        
        xDoc.Root.Should().HaveElement("Settings")
            .Which.Elements().Should().HaveCount(3)
            .And.AllSatisfy(x => {
                x.Attributes().Should().HaveCount(2);
                x.Attribute("Name").Should().NotBeNull();
                x.Attribute("Value").Should().NotBeNull();
            });
    }

    const string Xml = @"
<Root>
  <Settings>
    <Option1 Name=""opt1"" Value=""value1"" />
    <Option1 Name=""opt2"" Value=""value2"" />
    <Option1 Name=""opt3"" Value=""value3"" />
  </Settings>
</Root>
";
}