using System.Xml;
using System.Xml.Serialization;

[XmlRoot(ElementName = "trigger")]
public class TriggerXml
{
    [XmlElement(ElementName = "text")]
    public string text;

    [XmlElement(ElementName = "font")]
    public FontXml font;
}

[XmlRoot(ElementName = "font")]
public class FontXml
{
    [XmlElement(ElementName = "size")]
    public int size;

    [XmlElement(ElementName = "style")]
    public string style;
}
