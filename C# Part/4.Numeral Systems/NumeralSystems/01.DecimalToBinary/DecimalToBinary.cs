using System;

class DecimalToBinary
{
    static string ConvertToBinary(int number)
    {
        int systemBase = 2;
        int reminder = 0;
        string reminders = string.Empty;
        string result = string.Empty;
        while (number > 0)
        {
            reminder = number % systemBase;
            reminders = reminders + reminder.ToString();
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
        string result = ConvertToBinary(number);
        Console.WriteLine(result);
    }
}
