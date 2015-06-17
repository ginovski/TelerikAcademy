using System;

class CardsInDeck
{
    static void Main(string[] args)
    {
        string suit = "";
        for (int i = 1; i <= 13; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (j)
                {
                    case 1:
                        suit = "Clubs";
                        break;
                    case 2:
                        suit = "Hearts";
                        break;
                    case 3:
                        suit = "Spades";
                        break;
                    case 4:
                        suit = "Diamonds";
                            break;
                }
                switch (i)
                {
                    case 1:
                        Console.WriteLine("Two of " + suit);
                        break;
                    case 2:
                        Console.WriteLine("Three of " + suit);
                        break;
                    case 3:
                        Console.WriteLine("Four of " + suit);
                        break;
                    case 4:
                        Console.WriteLine("Five of " + suit);
                        break;
                    case 5:
                        Console.WriteLine("Six of " + suit);
                        break;
                    case 6:
                        Console.WriteLine("Seven of " + suit);
                        break;
                    case 7:
                        Console.WriteLine("Eight of " + suit);
                        break;
                    case 8:
                        Console.WriteLine("Nine of " + suit);
                        break;
                    case 9:
                        Console.WriteLine("Ten of " + suit);
                        break;
                    case 10:
                        Console.WriteLine("Jack of " + suit);
                        break;
                    case 11:
                        Console.WriteLine("Queen of " + suit);
                        break;
                    case 12:
                        Console.WriteLine("King of " + suit);
                        break;
                    case 13:
                        Console.WriteLine("Ace of " + suit);
                        break;
                } 
            }
        }
    }
}

