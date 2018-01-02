using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethotGreaterThan2
{
    class Program
    {
        private static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int maxab = GetMax(first,second);
            Console.WriteLine(GetMax(maxab, third));
        }
    }
}
