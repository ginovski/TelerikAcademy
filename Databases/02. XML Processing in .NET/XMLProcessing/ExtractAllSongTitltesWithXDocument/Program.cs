//Rewrite the same using XDocument and LINQ query.
namespace ExtractAllSongTitltesWithXDocument
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class Program
    {
        internal static void Main()
        {
            XDocument catalogDocument = XDocument.Load("../../catalog.xml");

            var songs = from al in catalogDocument.Root.Elements("album")
                        from song in al.Element("songs").Elements("song")
                        select song.Element("title").Value;

            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
        }
    }
}