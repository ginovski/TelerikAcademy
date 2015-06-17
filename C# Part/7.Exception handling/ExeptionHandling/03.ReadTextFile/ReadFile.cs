using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.ReadTextFile
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            try
            {
                string input = @Console.ReadLine();
                string read = File.ReadAllText(input);
                Console.WriteLine(read);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You don't have access to this file");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
