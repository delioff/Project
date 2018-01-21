using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPhonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool until = true;
            Dictionary<string, string> phones = new Dictionary<string, string>();
            while(until)
            {
                var input=Console.ReadLine().Split();
                switch (input[0])
                {
                    case "A":
                        if (phones.ContainsKey(input[1]))
                        {
                            phones[input[1]] = input[2];
                        }
                        else
                        {
                            phones.Add(input[1], input[2]);
                        }
                        break;
                    case "S":
                        if (phones.ContainsKey(input[1]))
                        {
                             Console.WriteLine($"{input[1]} -> {phones[input[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {input[1]} does not exist.");
                        }
                        break;
                    case "END": until = false; break;
                }
            }
        }
    }
}
