//Using the DOM parser write a program to delete from catalog.xml all albums having price > 20.
namespace DeleteAllAlbumsWithPriceGreaterThan20
{
    using System;
    using System.Xml;

    public class Program
    {
        internal static void Main()
        {
            var catalogDocument = new XmlDocument();
            catalogDocument.Load("../../catalog.xml");
            var catalogRoot = catalogDocument.DocumentElement;

            DeleteAlbumWithPrice(20, catalogRoot);

            catalogDocument.Save("../../catalog.xml");
        }

        private static void DeleteAlbumWithPrice(int price, XmlElement catalogRoot)
        {
            foreach (XmlNode album in catalogRoot.ChildNodes)
            {
                if (int.Parse(album["price"].InnerText) >= price)
                {
                    Console.WriteLine("Album: {0} with price: {1} has been removed", album["name"].InnerText, album["price"].InnerText);
                    catalogRoot.RemoveChild(album);
                }
            }
        }
    }
}