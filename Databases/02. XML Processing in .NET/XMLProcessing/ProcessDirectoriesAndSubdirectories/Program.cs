//Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
//Use tags<file> and<dir> with appropriate attributes.
//For the generation of the XML document use the class XmlWriter.
namespace ProcessDirectoriesAndSubdirectories
{
    using System;
    using System.IO;
    using System.Xml;

    public class Program
    {
        internal static void Main()
        {
            string path = "..\\..\\root";
            if (Directory.Exists(path))
            {
                var settings = new XmlWriterSettings();
                settings.Indent = true;
                var writer = XmlWriter.Create("../../directory.xml", settings);
                using (writer)
                {
                    writer.WriteStartDocument();

                    ProcessDirectory(path, writer);

                    writer.WriteEndDocument();
                }

                Console.WriteLine("Directories traversed! Look at directories.xml");
            }
        }

        public static void ProcessDirectory(string path, XmlWriter writer)
        {
            string directoryName = path.Substring(path.LastIndexOf("\\") + 1);

            writer.WriteStartElement("dir");
            writer.WriteStartAttribute("dirName");
            writer.WriteString(directoryName);
            writer.WriteEndAttribute();

            string[] fileEntries = Directory.GetFiles(path);
            foreach (string filePath in fileEntries)
            {
                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);

                writer.WriteStartElement("file");
                writer.WriteString(fileName);
                writer.WriteEndElement();
            }

            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory, writer);

                writer.WriteEndElement();
            }
        }
    }
}