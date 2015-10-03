namespace XsdValidation
{
    using System;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public class Program
    {
        private static bool ValidateXmlDocument(XDocument document, XmlSchemaSet schemas)
        {
            bool errors = false;
            document.Validate(schemas, (obj, ev) =>
            {
                errors = true;
            });

            return errors;
        }

        internal static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, new XmlTextReader("../../catalog.xsd"));

            XDocument catalog = XDocument.Load("../../catalog.xml");
            XDocument invalidCatalog = XDocument.Load("../../invalidCatalog.xml");

            Console.WriteLine("Validating catalog.xml");
            bool isCatalogValid = ValidateXmlDocument(catalog, schemas);
            Console.WriteLine("catalog.xml {0}", isCatalogValid ? "is not valid" : "is valid");

            Console.WriteLine();

            Console.WriteLine("Validating invalidCatalog.xml");
            bool isInvalidCatalogValid = ValidateXmlDocument(invalidCatalog, schemas);

            Console.WriteLine("invalidCatalog.xml {0}", isInvalidCatalogValid ? "is not valid" : "is valid");
        }
    }
}