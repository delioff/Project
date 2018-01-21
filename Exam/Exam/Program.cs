using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndergroundWaters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputair = Console.ReadLine();
            var inputrain = Console.ReadLine();
            List<int> airmaxs = new List<int>();
            List<int> rainmaxs = new List<int>();
            if (!string.IsNullOrWhiteSpace(inputair))
            {
                airmaxs = inputair.Split()
                    .Select(int.Parse)
                    .ToList();
                airmaxs = FindLocalMax(airmaxs);
            }
            if (!string.IsNullOrWhiteSpace(inputrain))
            {
                rainmaxs = inputrain.Split()
                    .Select(int.Parse)
                    .ToList();
                for (int i = 0; i < rainmaxs.Count; i++)
                {
                    rainmaxs[i] -= airmaxs.Count;
                }
                rainmaxs = rainmaxs.Where(x => x > 0).ToList();
            }
            var TotalMax = 0;
            var RainMax = 0;
            if (airmaxs.Count>0) TotalMax=airmaxs.Max();
            if (rainmaxs.Count>0)
            {
                if (rainmaxs.Contains(TotalMax))
                {
                    Console.WriteLine("Something interesting was found!");
                    rainmaxs = FindLocalMax(rainmaxs);
                    RainMax = rainmaxs.Max();
                    if (TotalMax == RainMax)
                    {
                        Console.WriteLine(string.Format("Sum: {0}", TotalMax + RainMax));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Difference: {0}", Math.Abs(TotalMax - RainMax)));
                    };
                }
                else
                {
                    Console.WriteLine("There is nothing unordinary!");
                    rainmaxs = FindLocalMax(rainmaxs);
                    if (rainmaxs.Count>0) { RainMax = rainmaxs.Max(); }
                    if (TotalMax == RainMax)
                    {
                        Console.WriteLine(string.Format("Sum: {0}", TotalMax + RainMax));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Difference: {0}", Math.Abs(TotalMax - RainMax)));
                    }
                }
            }
            else
            {
                if (!(TotalMax == RainMax))
                {
                    Console.WriteLine("There is nothing unordinary!");
                    Console.WriteLine(string.Format("Difference: {0}", Math.Abs(TotalMax)));
                }
                else
                {
                    Console.WriteLine("Something interesting was found!");
                    Console.WriteLine(string.Format("Sum: {0}", TotalMax + RainMax));
                }
            }
        }

        private static List<int> FindLocalMax(List<int> airArray)
        {
            List<int> rez = new List<int>();
            if (airArray.Count==1)
            {
                return airArray;
            }
            for(var i=0;i< airArray.Count;i++)
            {
                if (i>0 && i<airArray.Count-1)
                {
                    if ((airArray[i] > airArray[i + 1]) && (airArray[i] > airArray[i - 1]))
                    {
                        rez.Add(airArray[i]);
                        continue;
                    }
                }
                if (i==0)
                {
                    if (airArray[i] > airArray[i + 1])
                    {
                        rez.Add(airArray[i]);
                    }
                }
                if (i == airArray.Count-1)
                {
                    if (airArray[i] > airArray[i - 1])
                    {
                        rez.Add(airArray[i]);
                    }
                }
            }
            return rez;
        }
    }
}
