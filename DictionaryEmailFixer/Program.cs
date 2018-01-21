using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool until = true;
            Dictionary<string, string> emails = new Dictionary<string, string>();
            while (until)
            {
                var res = Console.ReadLine();
                if (res != "stop")
                {
                    var email = Console.ReadLine();
                    if (emails.ContainsKey(res))
                    {
                        emails[res] = email;
                    }
                    else
                    {
                        if (!email.EndsWith("us") && !email.EndsWith("uk"))
                        {
                            emails.Add(res, email);
                        }
                    }
                }
                else
                {
                    until = false;
                }
            }
            foreach (var email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}

