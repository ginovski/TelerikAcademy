using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CSharp2Exam2014
{
    class Program
    {
        static void Main(string[] args)
        {

            BigInteger number = BigInteger.Parse(Console.ReadLine());
            string convertedNumber = ConvertToSystem(number);

            var tresNumber = new StringBuilder();

            for (int i = 0; i < convertedNumber.Length; i++)
            {
                char digit = convertedNumber[i];

                switch (digit)
                {
                    case '0': tresNumber.Append("LON+"); break;
                    case '1': tresNumber.Append("VK-"); break;
                    case '2': tresNumber.Append("*ACAD"); break;
                    case '3': tresNumber.Append("^MIM"); break;
                    case '4': tresNumber.Append("ERIK|"); break;
                    case '5': tresNumber.Append("SEY&"); break;
                    case '6': tresNumber.Append("EMY>>"); break;
                    case '7': tresNumber.Append("/TEL"); break;
                    case '8': tresNumber.Append("<<DON"); break;
                }
            }
            Console.WriteLine(tresNumber.ToString());
        }

        private static string ConvertToSystem(BigInteger number)
        {
                BigInteger systemBase = 9;
                string reminders = "";
                BigInteger reminder = 0;
                string result = "";
                if (number == 0)
                {
                    return "0";
                }
                while (number > 0)
                {
                    reminder = number % systemBase;
                    reminders = reminders + reminder.ToString();
                    number = number / systemBase;
                }

                for (int i = reminders.Length - 1; i >= 0; i--)
                {
                    result = result + reminders[i];
                }
                return result;
        }
    }
}
