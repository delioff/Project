using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool until = true;
            Dictionary<string, long> resources = new Dictionary<string, long>();
            while (until)
            {
                var res = Console.ReadLine();
                if (res != "stop")
                {
                    var quantity = long.Parse(Console.ReadLine());
                    if (resources.ContainsKey(res))
                    {
                        resources[res] += quantity;
                    }
                    else
                    {
                        resources.Add(res, quantity);
                    }
                }
                else
                {
                    until = false;
                }
            }
            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
