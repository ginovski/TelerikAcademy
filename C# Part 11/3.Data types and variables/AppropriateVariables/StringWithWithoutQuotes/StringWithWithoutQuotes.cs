using System;

class StringWithWithoutQuotes
{
    static void Main(string[] args)
    {
        string withQuoutedString = @"The ""use"" of quotations causes difficulties.";
        string withoutQuoutedString = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine("With quouted string: {0}\nWithout quouted string: {1}", withQuoutedString, withoutQuoutedString);
    }
}

