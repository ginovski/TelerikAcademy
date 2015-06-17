using System;
using System.Collections.Generic;

namespace List
{
    public class TestList
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);
            //list.Add(5);

            //Console.WriteLine(list.ToString());

            GenericList<string> list = new GenericList<string>();

            list.Add("Pesho");
            list.Add("Mitko");
            list.Add("Gosho");
        }
    }
}
