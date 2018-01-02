using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrimeCheckerRange
{
    class Program
    {
        static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            else
            {
                for (int a = 2; a <= Math.Sqrt(num); a++)
                {
                    if (num % a == 0)
                    {

                        return false;
                    }

                }


            }
            return true;
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var rez = new List<int>();
            for (var i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i)) rez.Add(i);
            }
            return rez;
        }

        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var rez = FindPrimesInRange(startNum, endNum);
            if (rez.Count == 0)
            {
                Console.WriteLine("empty List");
            }
            else
            {
                Console.WriteLine(string.Join(", ",rez));
            }
        }
    }
}
