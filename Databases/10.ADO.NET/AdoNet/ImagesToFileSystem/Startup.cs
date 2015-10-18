//05. Write a program that retrieves the images for all categories in the Northwind database and stores them as JPG files in the file system.
namespace ImagesToFileSystem
{
    using System.Data.SqlClient;
    using System.IO;

    public class Startup
    {
        private const int HeaderLength = 78;

        private static void Main()
        {
            var db = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=true");

            db.Open();

            using (db)
            {
                var picturesCommand = new SqlCommand("SELECT CategoryID, Picture FROM Categories", db);

                var picturesReader = picturesCommand.ExecuteReader();

                using (picturesReader)
                {
                    while (picturesReader.Read())
                    {
                        int categoryId = (int)picturesReader["CategoryID"];
                        byte[] pictureBytes = (byte[])picturesReader["Picture"];
                        byte[] imageWithoutHeader = RemoveHeaderFromPictureBytes(pictureBytes);

                        File.WriteAllBytes(string.Format("../../images/Category{0}.jpg", categoryId), imageWithoutHeader);
                    }
                }
            }
        }

        private static byte[] RemoveHeaderFromPictureBytes(byte[] pictureBytes)
        {
            byte[] imageWithoutHeader = new byte[pictureBytes.Length - HeaderLength];

            int index = 0;
            for (int i = 78; i < pictureBytes.Length; i++)
            {
                imageWithoutHeader[index] = pictureBytes[i];
                index++;
            }

            return imageWithoutHeader;
        }
    }
}