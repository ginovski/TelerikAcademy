//Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier.
//Use XPath query.
namespace ExtractPricesForAlbumsBefore5Years
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
        internal static void Main()
        {
            var catalog = new XmlDocument();
            catalog.Load("../../catalog.xml");

            var albumsAndPrices = GetPricesOfAlbumsBeforeYears(5, catalog);
            foreach (var album in albumsAndPrices)
            {
                Console.WriteLine("Album: {0}, Year: {1}", album.Key, album.Value);
            }
        }

        private static Dictionary<string, string> GetPricesOfAlbumsBeforeYears(int numberOfYears, XmlDocument catalog)
        {
            var albumsAndPrices = new Dictionary<string, string>();
            var albums = catalog.SelectNodes("catalog/album[year >= 2010]");
            foreach (XmlNode album in albums)
            {
                albumsAndPrices.Add(album["name"].InnerText, album["year"].InnerText);
            }

            return albumsAndPrices;
        }
    }
}