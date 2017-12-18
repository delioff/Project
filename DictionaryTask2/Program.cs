using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split().ToList();
            Dictionary<string, int> count = new Dictionary<string, int>();
            foreach (var num in nums)
            {
                if (count.ContainsKey(num.ToLower()))
                {
                    count[num.ToLower()] += 1;
                }
                else
                {
                    count.Add(num.ToLower(), 1);
                }
            }
            bool first = true;
            foreach (var num in count)
            {
                if (num.Value % 2 != 0)
                {
                    if (first)
                    {
                        Console.Write($"{num.Key}");
                        first = false;
                    }
                    else
                    {
                        Console.Write($", {num.Key}");
                    }
                }
            }
        }
    }
}
