using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SameLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int same = 0;
            int counter = 0;
            StreamReader readFirst = new StreamReader("../../textOne.txt");
            StreamReader readSecond = new StreamReader("../../textTwo.txt");
            string line1 = "";
            string line2 = "";
            using (readFirst)
            {
                using (readSecond)
                {
                    while (line1 != null && line2 != null)
                    {
                        line1 = readFirst.ReadLine();
                        line2 = readSecond.ReadLine();
                        if (line1 == line2)
                        {
                            same++;
                        }
                        counter++;
                    }
                }
            }
            same--; //Take out the null readLine
            counter--; 
            Console.WriteLine("The same lines are: {0}", same);
            Console.WriteLine("The different lines are: {0}", counter - same);
        }
    }
}
