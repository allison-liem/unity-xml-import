using System;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class XmlUtils
{
    public static T ImportXml<T>(string path)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (var stream = new FileStream(path, FileMode.Open))
            {
                return (T)serializer.Deserialize(stream);
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Exception importing xml file: " + e);
            return default;
        }
    }
}
