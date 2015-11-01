﻿// Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders }
// and using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS.Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly.Use recursive DFS traversal.
namespace FilesAndFoldersInWindows
{
    using System;
    using System.IO;

    public class Startup
    {
        // DFS Algorithm
        private static void GetSumOfFileSizesInFolder(Folder root, ref long size)
        {
            foreach (var file in root.Files)
            {
                size += file.Size;
            }

            foreach (var folder in root.Folders)
            {
                GetSumOfFileSizesInFolder(folder, ref size);
            }
        }

        private static string GetName(string path)
        {
            return new DirectoryInfo(path).Name;
        }

        private static void BuildTree(string rootFolderPath, Folder root)
        {
            string[] files = Directory.GetFiles(rootFolderPath);
            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                root.Files.Add(new File(fileInfo.Name, fileInfo.Length));
            }

            try
            {
                string[] directories = Directory.GetDirectories(rootFolderPath);
                foreach (var directory in directories)
                {
                    var directoryInfo = new DirectoryInfo(directory);
                    var newDir = new Folder(directoryInfo.Name);

                    BuildTree(directory, newDir);

                    root.Folders.Add(newDir);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Skipping folders in which we don't have access
            }
        }

        public static void Main()
        {
            string rootFolderPath = @"C:\Windows";
            var root = new Folder(GetName(rootFolderPath));

            BuildTree(rootFolderPath, root);

            long size = 0;
            GetSumOfFileSizesInFolder(root, ref size);

            Console.WriteLine("Size of all files in {0}: {1}", root.Name, size);
        }
    }
}