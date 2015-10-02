//Create a XML file representing catalogue.
//The catalogue should contain albums of different artists.
//For each album you should define: name, artist, year, producer, price and a list of songs.
//Each song should be described by title and duration.
//2. Write program that extracts all different artists which are found in the catalog.xml.
//For each author you should print the number of albums in the catalogue.
//Use the DOM parser and a hash-table.
namespace ExtractAllArtistsWithAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class Program
    {
        private static Dictionary<string, int> GetArtistsWithAlbums(XmlDocument catalog)
        {
            var artistsWithAlbums = new Dictionary<string, int>();
            var artists = catalog.GetElementsByTagName("artist");
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