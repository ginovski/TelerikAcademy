namespace BoolAsStringRepresenter
{
    using System;

    public class Representer
    {
        public void RepresentBoolAsString(bool boolValue)
        {
            string boolAsString = boolValue.ToString();

            Console.WriteLine(boolAsString);
        }
    } 
}
