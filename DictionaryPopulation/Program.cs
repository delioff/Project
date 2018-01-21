using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPopulation
{
    class Population
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> stat = new Dictionary<string, Dictionary<string, long>>();
            bool until = true;
            while (until)
            {
                var line = Console.ReadLine();
                if (line == "report")
                {
                    until = false;
                }
                else
                {
                    var input = line.Split('|');
                    if (stat.ContainsKey(input[1]))
                    {
                        if (stat[input[1]] != null)
                        {
                            if (stat[input[1]].ContainsKey(input[0]))
                            {
                                var dict = stat[input[1]];
                                if (dict.ContainsKey(input[0]))
                                {
                                    dict[input[0]] += long.Parse(input[2]);
                                }
                                else
                                {
                                    dict.Add(input[0], long.Parse(input[2]));
                                }
                            }
                            else
                            {
                                stat[input[1]].Add(input[0],long.Parse(input[2]));
                            }
                            
                        }
                        else
                        {
                            stat[input[1]] = new Dictionary<string, long> { { input[0], long.Parse(input[2]) } };
                        }
                    }
                    else
                    {
                        stat.Add(input[1], new Dictionary<string, long> { { input[0], long.Parse(input[2]) } });
                    }
                    
                }
            }
            foreach (var state in stat.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                List<long> sumOfTowns = state.Value.Select(x => x.Value).ToList();
                Console.WriteLine($"{state.Key} (total population: {sumOfTowns.Sum()})");
                Console.Write($"=>{string.Join("=>", state.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            }
        }
    }
}
