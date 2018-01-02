using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPrimeChecker
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
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
