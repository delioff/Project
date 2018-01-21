using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendsRainyUniverse
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Dictionary<string,int>> inputs = new Dictionary<string, Dictionary<string,int>>();
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (input == "End") break;
                var rez = input.Split(new string[] { "->" }, StringSplitOptions.None);
                if (inputs.ContainsKey(rez[0].Trim()))
                {
                    var el = rez[1].Split(':');
                    if (inputs[rez[0].Trim()].ContainsKey(el[0].Trim()))
                    {
                        var item = inputs[rez[0].Trim()];
                        item[el[0].Trim()] += int.Parse(el[1]);
                    }
                    else
                    {
                        var item = inputs[rez[0].Trim()];
                        item.Add(el[0].Trim(), int.Parse(el[1]));
                    }
                }
                else
                {
                    Dictionary<string, int> item = new Dictionary<string, int>();
                    var el = rez[1].Split(':');
                    item.Add(el[0].Trim(), int.Parse(el[1]));
                    inputs.Add(rez[0].Trim(),item);
                }
            }
            while (true);
            foreach(var item in inputs.OrderBy(e=>e.Key))
            {
                Console.WriteLine(string.Format("{0} Liquids:", item.Key));
                foreach(var localitem in item.Value.OrderBy(e=>e.Value))
                {
                    Console.WriteLine(string.Format("--- {0}: {1}", localitem.Key,localitem.Value));
                }
            }
        }
    }
}
