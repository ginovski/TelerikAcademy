//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9
namespace SubStringInText
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string subString = Console.ReadLine();
            int subStringCounter = 0;

            text = text.ToLower();

            int index = text.IndexOf(subString);

            while (index != -1)
            {
                subStringCounter++;
                index = text.IndexOf(subString, index + 1);
            }

            Console.WriteLine("The result is {0}", subStringCounter);
        }
    }
}
