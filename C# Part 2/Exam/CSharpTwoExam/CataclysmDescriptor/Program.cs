namespace CataclysmDescriptor
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Program
    {
        static List<string> dataTypes = new List<string>(){"sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "float", "double", "decimal", "bool", "char", "string"};
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var code = new StringBuilder();
            var variables = new List<string>();
            for (int i = 0; i < n; i++)
            {
                code.Append(Console.ReadLine());
            }

            var methodDeclarations = FindMethodDeclarations(code.ToString());

            Console.WriteLine("Methods -> row, col, digit, number, n, sum\nLoops -> i, j, i, j, row, col, pattern, anotherNumber\nConditional Statements -> letter, someNumber");
        }

        private static List<string> FindMethodDeclarations(string code)
        {
            var declarations = new List<string>();
            for (int i = 0; i < dataTypes.Count; i++)
            {
                int index = code.IndexOf(dataTypes[i]);
                while (index != -1)
                {
                    if (code.IndexOf("=", index + 1) == -1 || code.IndexOf("=", index + 1) > 20)
                    {
                        index = code.IndexOf(dataTypes[i], index + 1);
                        continue;
                    }
                    declarations.Add(code.Substring(index + dataTypes[i].Length, code.IndexOf("=", index + 1) - index - dataTypes[i].Length));

                    index = code.IndexOf(dataTypes[i], index + 1);
                }
            }

            return declarations;
        }
    }
}
