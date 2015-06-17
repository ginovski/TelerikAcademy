using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + world;
        string castHelloWorld = helloWorld.ToString();
        Console.WriteLine(castHelloWorld);
    }
}

