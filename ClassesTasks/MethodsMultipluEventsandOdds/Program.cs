using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsMultipluEventsandOdds
{
    class Program
    {
        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEvens = GetSumOfEvensDigits(n);
            int sumOdds = GetSumOfOddsDigits(n);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddsDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit%2!=0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvensDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMultipleOfEvensAndOdds(Math.Abs(int.Parse(Console.ReadLine()))));
        }
    }
}
