using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.ConcatenateTwoFiles
{
    class ConcatenateTextFiles
    {
        private static string ReadFile(string path)
        {
            StreamReader reader = new StreamReader(path);
            string text = "";
            using (reader)
            {
                text = reader.ReadToEnd();
            }
            return text;
        }
        private static void Concatenate(string textOne, string textTwo)
        {
            StreamWriter writer = new StreamWriter("../../concatenated.txt");
            string fullText = textOne + textTwo;
            using (writer)
            {
                writer.WriteLine(fullText); 
            }
        }

        static void Main(string[] args)
        {
            string textOne = ReadFile("../../textOne.txt");
            string textTwo = ReadFile("../../textTwo.txt");
            Concatenate(textOne, textTwo);
        }

        
    }
}
