using System;
using System.Collections.Generic;
using System.Xml;

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(xml);
        XmlElement xmlElement = xmlDocument.DocumentElement;
        XmlNodeList xmlNodeList = xmlElement.SelectNodes("*");
        Console.WriteLine(xmlElement.Attributes["name"].Value);
        foreach(XmlNode item in xmlNodeList)
        {
            Console.WriteLine(item.Attributes["name"].Value);
        }
        return new List<string>();
    }

    public static void Main2(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
            Console.WriteLine(name);
    }
}