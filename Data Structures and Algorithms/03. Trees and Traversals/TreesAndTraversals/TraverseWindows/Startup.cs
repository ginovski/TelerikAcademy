// Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe.Use the class System.IO.Directory.
namespace TraverseWindows
{
    using System;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static void FindAllFilesEndingWithExe(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                if (file.EndsWith(".exe"))
                {
                    Console.WriteLine(new FileInfo(file).Name);
                }
            }

            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (var directory in directories)
                {
                    FindAllFilesEndingWithExe(directory);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Skipping folders in which we don't have access
            }
        }

        public static void Main()
        {
            string path = @"C:\Windows";

            FindAllFilesEndingWithExe(path);
        }
    }
}