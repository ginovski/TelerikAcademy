//Rewrite the last exercise using XDocument, XElement and XAttribute.
namespace ProcessDirectoriesAndSubDirectoriesUsingXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public class Program
    {
        internal static void Main()
        {
            string path = "..\\..\\root";
            if (Directory.Exists(path))
            {
                XDocument document = new XDocument();

                document.Add(ProcessDirectory(path, document, null));
                document.Save("../../directory.xml");

                Console.WriteLine("Directories traversed! Look at directories.xml");
            }
        }

        public static XElement ProcessDirectory(string path, XDocument document, XElement currentDir)
        {
            string directoryName = path.Substring(path.LastIndexOf("\\") + 1);
            if (currentDir == null)
            {
                currentDir = new XElement("dir", new XAttribute("dirName", directoryName));
            }

            var innerDir = new XElement("dir", new XAttribute("dirName", directoryName));
            currentDir.Add(innerDir);

            string[] fileEntries = Directory.GetFiles(path);
            foreach (string filePath in fileEntries)
            {
                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                currentDir.Add(new XElement("file", fileName));
            }

            string[] subdirectoryEntries = Directory.GetDirectories(path);
            foreach (string subdirectory in subdirectoryEntries)
            {
                ProcessDirectory(subdirectory, document, innerDir);
            }

            return currentDir;
        }
    }
}