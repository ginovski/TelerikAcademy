using System;

class UserInput
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 1,2 or 3 for int, double or string");
        string input = Console.ReadLine();
        byte selection = byte.Parse(input);

        switch (selection)
        {
            case 1:
                string Selection = Console.ReadLine();
                int userNumber = int.Parse(Selection);
                userNumber++;
                Console.WriteLine(userNumber);
                break;
            case 2:
                Selection = Console.ReadLine();
                double userNumberTwo = double.Parse(Selection);
                userNumberTwo++;
                Console.WriteLine(userNumberTwo);
                break;
            case 3:
                Selection = Console.ReadLine();
                Console.WriteLine(Selection + "*");
                break;
            default:
                Console.WriteLine("Wrong symbol");
                break;
        }
    }
}

