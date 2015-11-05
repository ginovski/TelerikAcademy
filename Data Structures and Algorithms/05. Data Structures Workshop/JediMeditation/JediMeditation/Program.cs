namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var jedis = Console.ReadLine().Split(' ');

            var jedisDivided = new Dictionary<string, Queue<string>>();

            jedisDivided["m"] = new Queue<string>();
            jedisDivided["k"] = new Queue<string>();
            jedisDivided["p"] = new Queue<string>();

            foreach (var jedi in jedis)
            {
                if (jedi.StartsWith("m"))
                {
                    jedisDivided["m"].Enqueue(jedi);
                }
                else if (jedi.StartsWith("k"))
                {
                    jedisDivided["k"].Enqueue(jedi);
                }
                else
                {
                    jedisDivided["p"].Enqueue(jedi);
                }
            }

            var result = new StringBuilder();

            result.Append(string.Join(" ", jedisDivided["m"]) + " ");
            result.Append(string.Join(" ", jedisDivided["k"]) + " ");
            result.Append(string.Join(" ", jedisDivided["p"]));

            Console.WriteLine(result.ToString());
        }
    }
}