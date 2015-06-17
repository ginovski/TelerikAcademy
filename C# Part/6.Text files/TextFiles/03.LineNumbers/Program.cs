using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.LineNumbers
{
    class Program
    {
        private static void Write(string line, int lineNum)
        {
            StreamWriter writer = new StreamWriter("../../result.txt", true);
            if (line != null)
            {
                using (writer)
                {
                    writer.WriteLine(lineNum + ": " + line);
                }
            }
        }

        private static void Read()
        {
            StreamReader reader = new StreamReader("../../text.txt");
            string line = "";
            int lineNumber = 0;
            using (reader)
            {
                while (line != null)
                {
                    lineNumber++;
                    line = reader.ReadLine();
                    Write(line, lineNumber);
                }
            }
        }
        static void Main(string[] args)
        {
            Read();
        }

        
    }
}
