using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitsOfWork
{
    internal class Program
    {
        private class Unit : IComparable<Unit>
        {
            public Unit(string name, string type, int attack)
            {
                this.Name = name;
                this.Type = type;
                this.Attack = attack;
            }

            public string Name { get; set; }

            public string Type { get; set; }

            public int Attack { get; set; }

            public override bool Equals(object obj)
            {
                Unit u = obj as Unit;
                if (u != null)
                {
                    return this.Name.Equals(u.Name);
                }

                return false;
            }

            public override int GetHashCode()
            {
                int result = 13;

                result = 37 * result + this.Name.GetHashCode();

                return result;
            }

            public override string ToString()
            {
                return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
            }

            public int CompareTo(Unit other)
            {
                int comp = this.Attack.CompareTo(other.Attack) * -1;
                if (comp != 0)
                {
                    return comp;
                }
                else
                {
                    return this.Name.CompareTo(other.Name);
                }
            }
        }

        private static SortedSet<Unit> units = new SortedSet<Unit>();
        private static Dictionary<string, SortedSet<Unit>> typesOfUnits = new Dictionary<string, SortedSet<Unit>>();
        private static Dictionary<string, string> unitsAndTypes = new Dictionary<string, string>();

        private static void Main(string[] args)
        {
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] lineParts = line.Split(' ');
                string command = lineParts[0];

                switch (command)
                {
                    case "add":
                        AddCommand(lineParts);
                        break;

                    case "remove":
                        RemoveCommand(lineParts);
                        break;

                    case "find":
                        FindCommand(lineParts);
                        break;

                    case "power":
                        PowerCommand(lineParts);
                        break;
                }

                line = Console.ReadLine();
            }
        }

        private static void PowerCommand(string[] lineParts)
        {
            int numberOfUnits = int.Parse(lineParts[1]);

            var result = units.Take(numberOfUnits).ToList();

            if (result.Count == 0)
            {
                Console.WriteLine("RESULT:");
            }
            else
            {
                Console.WriteLine("RESULT: {0}", string.Join(", ", result).Trim());
            }
        }

        private static void FindCommand(string[] lineParts)
        {
            string type = lineParts[1];
            var result = new List<Unit>();

            if (typesOfUnits.ContainsKey(type))
            {
                result = typesOfUnits[type].Take(10).ToList();
            }

            if (result.Count == 0)
            {
                Console.WriteLine("RESULT:");
            }
            else
            {
                Console.WriteLine("RESULT: {0}", string.Join(", ", result).Trim());
            }
        }

        private static void RemoveCommand(string[] lineParts)
        {
            string unitName = lineParts[1];
            if (unitsAndTypes.ContainsKey(unitName))
            {
                string type = unitsAndTypes[unitName];

                var unit = typesOfUnits[type].FirstOrDefault(u => u.Name == unitName);
                bool res = typesOfUnits[type].Remove(unit);
                units.Remove(unit);
                if (res)
                {
                    Console.WriteLine("SUCCESS: {0} removed!", unitName);
                }
                else
                {
                    Console.WriteLine("FAIL: {0} could not be found!", unitName);
                }
            }
            else
            {
                Console.WriteLine("FAIL: {0} could not be found!", unitName);
            }
        }

        private static void AddCommand(string[] lineParts)
        {
            string name = lineParts[1];
            string type = lineParts[2];
            int attack = int.Parse(lineParts[3]);

            var newUnit = new Unit(name, type, attack);

            if (units.Contains(newUnit))
            {
                Console.WriteLine("FAIL: {0} already exists!", newUnit.Name);
            }
            else
            {
                units.Add(newUnit);
                if (!typesOfUnits.ContainsKey(newUnit.Type))
                {
                    typesOfUnits[newUnit.Type] = new SortedSet<Unit>();
                }

                typesOfUnits[newUnit.Type].Add(newUnit);
                unitsAndTypes.Add(name, type);

                Console.WriteLine("SUCCESS: {0} added!", newUnit.Name);
            }
        }
    }
}