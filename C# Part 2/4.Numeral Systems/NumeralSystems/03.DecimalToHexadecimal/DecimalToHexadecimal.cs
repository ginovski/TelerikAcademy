using System;

class DecimalToHexadecimal
{
    static string ConvertDecimalToHexadecimal(int number)
    {
        int systemBase = 16;
        int reminder = 0;
        string reminders = string.Empty;
        string result = string.Empty;
        while (number > 0)
        {
            reminder = number % systemBase;
            switch (reminder)
            {
                case 10:
                    reminders = reminders + "A";
                    break;
                case 11:
                    reminders = reminders + "B";
                    break;
                case 12:
                    reminders = reminders + "C";
                    break;
                case 13:
                    reminders = reminders + "D";
                    break;
                case 14:
                    reminders = reminders + "E";
                    break;
                case 15:
                    reminders = reminders + "F";
                    break;
                default: 
                    reminders = reminders + reminder.ToString();
                    break;
            }
            number = number / systemBase;
        }
        for (int index = reminders.Length - 1; index >= 0; index--)
        {
            result += reminders[index];
        }
        return result;
    }
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string result = ConvertDecimalToHexadecimal(number);
        Console.WriteLine("0x{0}",result);
    }
}
