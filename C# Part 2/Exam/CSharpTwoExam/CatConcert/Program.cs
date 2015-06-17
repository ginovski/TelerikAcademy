namespace CatConcert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int cats = int.Parse(input.Substring(0, input.IndexOf(" ")));
            input = Console.ReadLine();
            int songs = int.Parse(input.Substring(0, input.IndexOf(" ")));
            var knows = new List<string>();

            int counter = 0;
            input = Console.ReadLine();
            while (input != "Mew!")
            {
                counter++;
                knows.Add(input);
                input = Console.ReadLine();
            }
            if (counter < cats)
            {
                Console.WriteLine("No concert!");
            }
            else if ((cats + songs) >= counter)
            {
                Console.WriteLine((cats + songs) - counter);
            }
            else if (counter % cats > 2)
            {
                Console.WriteLine(counter / cats);
            }
            else
            {
                Console.WriteLine(cats / songs);
            }
        }
    }
}
