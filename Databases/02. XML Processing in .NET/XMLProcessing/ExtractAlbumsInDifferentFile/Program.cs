//Write a program, which(using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml,
//in which stores in appropriate way the names of all albums and their authors.
namespace ExtractAlbumsInDifferentFile
{
    using System;
    using System.Xml;

    public class Program
    {
        internal static void Main()
        {
            using (XmlReader reader = new XmlTextReader("../../catalog.xml"))
            {
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                using (XmlWriter writer = XmlWriter.Create("../../albums.xml", settings))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("albums");

                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            writer.WriteStartElement("album");
                            writer.WriteStartElement("name");

                            writer.WriteString(reader.ReadElementString());

                            writer.WriteEndElement();
                        }

                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "artist")
                        {
                            writer.WriteStartElement("artist");

                            writer.WriteString(reader.ReadElementString());

                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                    }

                    writer.WriteEndDocument();
                }
            }
        }
    }
}