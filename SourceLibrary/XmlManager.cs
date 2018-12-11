using System.Xml;

namespace SourceLibrary
{
    public class XmlManager
    {
        public static string GetXmlStringFromFile(string xmlFilePath)
        {
            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(xmlFilePath);
            return XmlDoc.InnerXml;
        }
    }
}
