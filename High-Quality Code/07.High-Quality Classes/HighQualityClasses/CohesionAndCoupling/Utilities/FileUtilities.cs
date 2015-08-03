namespace CohesionAndCoupling.Utilities
{
    using System;

    public static class FileUtilities
    {
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Missing file extension");
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                throw new ArgumentException("Invalid file name (File name must be provided with extension)");
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
