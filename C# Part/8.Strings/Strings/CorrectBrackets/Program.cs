//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
namespace CorrectBrackets
{
    using System;

    public class Program
    {
        private static bool AreBracketsCorrect(string expression)
        {
            int openingBracketsCount = 0;
            int closingBracketsCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracketsCount++;
                }
                if (expression[i] == ')')
                {
                    closingBracketsCount++;
                }
            }

            if (openingBracketsCount == closingBracketsCount)
            {
                return true;
            }

            return false;
        }

        public static void Main()
        {
            string expression = Console.ReadLine();

            bool areCorrect = AreBracketsCorrect(expression);

            Console.WriteLine("Brackets are correct ---> {0}", areCorrect);
        }
    }
}
