namespace CustomException
{
    using System;

    public class TestException
    {
        public static void Main()
        {
            var numbersException = new InvalidRangeException<int>("Number is out of range", 50, 100);

            Console.WriteLine("Enter a number [{0}, {1}]", numbersException.Start, numbersException.End);
            int number = int.Parse(Console.ReadLine());

            if (number < numbersException.Start || number > numbersException.End)
            {
                throw numbersException;
            }

            Console.WriteLine("Number is in range: {0}", number);

            var dateException = new InvalidRangeException<DateTime>
                ("Date is out of range", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31));

            Console.WriteLine("Enter a date [{0}, {1}]", dateException.Start, dateException.End);
            var date = DateTime.Parse(Console.ReadLine());

            if (date < dateException.Start || date > dateException.End)
            {
                throw dateException;
            }

            Console.WriteLine("Date is valid: {0}", date);
        }
    }
}
