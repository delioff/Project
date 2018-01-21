using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04MakeitRain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int T = 0;
            int F = 0;
            for (int i=1;i<=n;i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (b!=0 && a / b == c)
                {
                    T += (int)'T';
                    F = F / ((int)'T' / 10);
                }
                else
                {
                    F += (int)'F';
                    T = T / ((int)'F' / 10);
                }
                
            }
            Console.WriteLine($"T: {T}");
            Console.WriteLine($"F: {F}");
            if (F != 0)
            {
                string trorf = T / F % 2 == 0 ? "True" : "False";
                Console.WriteLine($"Got a Roin coin: {trorf}");
            }
            else
            {
                Console.WriteLine($"Got a Roin coin: False");
            }
        }
    }
}
