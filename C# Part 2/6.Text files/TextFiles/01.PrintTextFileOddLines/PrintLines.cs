using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.PrintTextFileOddLines
{
    class PrintLines
    { 
        private static void Print()
        {
            StreamReader reader = new StreamReader("../../digits.txt");
            int counter = 0;
            string line = "";
            using (reader)
            {
                while (line != null)
                {
                    counter++;
                    line = reader.ReadLine();
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: " + line, counter);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Print();
        }

       
    }
}
