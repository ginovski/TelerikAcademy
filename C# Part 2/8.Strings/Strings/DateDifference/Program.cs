namespace DateDifference
{
    using System;

    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.Write("Enter date (dd.mm.yyyy): ");
                DateTime firstDate = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter date (dd.mm.yyyy): ");
                DateTime secondDate = DateTime.Parse(Console.ReadLine());

                string dateDifference = string.Empty;

                if (secondDate > firstDate)
                {
                    dateDifference = (secondDate - firstDate).ToString();
                }
                else
                {
                    dateDifference = (firstDate - secondDate).ToString();
                }

                dateDifference = dateDifference.Substring(0, dateDifference.IndexOf("."));

                Console.WriteLine("Distance: {0} days", dateDifference);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format");
            }
        }
    }
}
