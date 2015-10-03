//Create an XSL stylesheet, which transforms the file catalog.xml into HTML document, formatted for viewing in a standard Web-browser.
//Write a C# program to apply the XSLT stylesheet transformation on the file catalog.xml using the class XslTransform.
namespace XSLTransforming
{
    using System;
    using System.Xml.Xsl;

    public class Program
    {
        internal static void Main()
        {
            XslTransform xslt = new XslTransform();
            xslt.Load("../../style.xslt");

            xslt.Transform("../../catalog.xml", "../../catalog.html");

            Console.WriteLine("Catalog transformed. Look at catalog.html");
        }
    }
}