using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BunnyFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            var cages = new List<BigInteger>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    cages.Add(long.Parse(input));
                }
                else
                {
                    break;
                }
            }

            int cycle = 1;
            BigInteger s = 0;
            BigInteger product = 1;
            BigInteger sum = 0;
            

            while (cycle < cages.Count)
            {
                for (int i = 0; i < cycle; i++)
                {
                    s += cages[i];
                }
                if (s <= cages.Count)
                {
                    var builder = new StringBuilder();
                    var counter = 1;
                    for (int i = cycle; i < cages.Count; i++)
                    {
                        if (counter <= s)
                        {
                            product *= cages[i];
                            sum += cages[i];
                            counter++;
                        }
                        else
                        {
                            builder.Append(cages[i]);
                        }
                    }
                    var stringedSum = sum.ToString();
                    var stringedProduct = product.ToString();

                    cages = new List<BigInteger>();

                    for (int i = 0; i < stringedSum.Length; i++)
                    {
                        cages.Add(long.Parse(stringedSum[i].ToString()));
                    }
                    for (int i = 0; i < stringedProduct.Length; i++)
                    {
                        cages.Add(long.Parse(stringedProduct[i].ToString()));
                    }
                    for (int i = 0; i < builder.Length; i++)
                    {
                        cages.Add(long.Parse(builder[i].ToString()));
                    }
                    while (cages.Remove(0) || cages.Remove(1))
                    {
                        cages.Remove(0);
                        cages.Remove(1);
                    }
                    s = 0;
                    product = 1;
                    sum = 0;
                    cycle++;
                }
                else
                {
                    break;
                }
            }
            foreach (var cage in cages)
            {
                Console.Write(cage + " ");
            }
            Console.WriteLine();
        }
    }
}
