using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFactorial
{
    class Program
    {
        static BigInteger Factoriel(int n)
        {
            BigInteger factoriel = 1;
            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }
            return factoriel;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            BigInteger rez = Factoriel(n);
            int trailingzeros = TrailingZeros(rez);
            Console.WriteLine(trailingzeros);
        }

        private static int TrailingZeros(BigInteger rez)
        {
            int count = 0;
            string temp = rez.ToString();
            int k = temp.Length-1;
            while (k>=0)
            {
                if (temp[k] == '0')
                {
                    count++;
                }
                else
                {
                    break;
                }
                k--;
            }
            return count;
        }
    }
}