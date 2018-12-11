using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using SourceLibrary;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class XmlManagerTest : TestBase
    {
        public XmlManagerTest(ITestOutputHelper tempOutput) : base(tempOutput)
        {
        }

        [Theory]
        [InlineData("<?xml version='1.0' ?><root><item>test</item></root>", "test.xml")]
        public void InnerXmlTest(string xml, string fileName)
        {
            var exePath = Application.ExecutablePath;
            var exeFolder = Path.GetDirectoryName(exePath);
            Assert.False(exeFolder == null);
            Output.WriteLine(exeFolder);

            var element = XElement.Parse(xml);
            var xmlPath = Path.Combine(exeFolder, fileName);
            element.Save(xmlPath);
            Output.WriteLine(element.ToString());

            var content = XmlManager.GetXmlStringFromFile(xmlPath);
            Output.WriteLine(content);

        }
    }
}
