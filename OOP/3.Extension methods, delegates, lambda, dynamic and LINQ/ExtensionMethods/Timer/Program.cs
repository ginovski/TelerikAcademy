// Problem 7. Timer
// Using delegates write a class Timer that can execute certain method at each t seconds.
namespace Timer
{
    using System;

    public class Program
    {
        private static void Main()
        {
            var writeOnConsole = new Action<string>(Console.WriteLine);
            while (true)
            {
                CustomTimer.Execute(writeOnConsole, "Test", 1500);
            }
        }
    }
}
