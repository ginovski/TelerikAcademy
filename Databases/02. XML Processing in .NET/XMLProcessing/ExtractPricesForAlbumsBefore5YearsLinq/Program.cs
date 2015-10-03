//Rewrite the previous using LINQ query.
namespace ExtractPricesForAlbumsBefore5YearsLinq
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        internal static void Main()
        {
            var catalog = XDocument.Load("../../catalog.xml");
            var albums = from al in catalog.Root.Elements("album")
                         where int.Parse(al.Element("year").Value) >= 2010
                         select new
                         {
                             Name = al.Element("name").Value,
                             Year = al.Element("year").Value
                         };

            foreach (var album in albums)
            {
                Console.WriteLine("Album: {0}, Year: {1}", album.Name, album.Year);
            }
        }
    }
}