using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortedDictionary<double, int> count = new SortedDictionary<double, int>();
            foreach (var num in nums)
            {
                if (count.ContainsKey(num))
                {
                    count[num] += 1;
                }
                else
                {
                    count.Add(num, 1);
                }
            }
            foreach (var num in count)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
