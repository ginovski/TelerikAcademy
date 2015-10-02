//Implement the previous using XPath.
namespace ExtractAllArtistsWithAlbumsWithXPath
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
        private static Dictionary<string, int> GetArtistsWithAlbums(XmlDocument catalog)
        {
            var artistsWithAlbums = new Dictionary<string, int>();
            var artists = catalog.SelectNodes("catalog/album/artist");
            foreach (XmlNode artist in artists)
            {
                if (!artistsWithAlbums.ContainsKey(artist.InnerText))
                {
                    artistsWithAlbums.Add(artist.InnerText, 0);
                }

                artistsWithAlbums[artist.InnerText]++;
            }

            return artistsWithAlbums;
        }

        internal static void Main()
        {
            var catalog = new XmlDocument();
            catalog.Load("../../catalog.xml");

            var artistsWithAlbums = GetArtistsWithAlbums(catalog);
            foreach (var artist in artistsWithAlbums)
            {
                Console.WriteLine("Artist: {0} -- Albums: {1}", artist.Key, artist.Value);
            }
        }
    }
}