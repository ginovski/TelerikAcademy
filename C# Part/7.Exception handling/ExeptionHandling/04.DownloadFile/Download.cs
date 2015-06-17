using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _04.DownloadFile
{
    class Download
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please write a name for your file.. Example: my-file.jpg");
                string name = Console.ReadLine();
                Console.WriteLine("Enter url ");
                string url = @Console.ReadLine();
                WebClient web = new WebClient();
                web.DownloadFile(url, name);
                Console.WriteLine("Download Complete");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid url address");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Something is wrong with your input");
            }
        }
    }
}
