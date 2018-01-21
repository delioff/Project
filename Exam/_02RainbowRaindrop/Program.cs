using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RainbowRaindrop
{
    class ColorUniverse
    {
        public double Volume { get; set; }
        private int blue;
        private int red;
        private int green;
        public int Blue {
            get
            {
                return blue;
            }
            set
            {
                if (value >= 0 && value <= 255)
                    blue = value;
            }
        }
        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (value >= 0 && value <= 255)
                    green = value;
            }
        }
        public int Red
        {
            get
            {
                return red;
            }
            set
            {
                if (value >= 0 && value <= 255)
                    red = value;
            }
        }
        public bool IsReindrop
        {
            get
            {
                if ((Red>200 || Green>200 || Blue>200) && ((Blue<100 && Red<100) || (Green<100 && Red<100) || (Green<100 && Blue<100)))
                {
                    return true;
                }
                return false;
            }
        }
        public override string ToString()
        {
            return string.Format("V:{0:0.00} -> R:{1} G:{2} B:{3}",Volume,Red,Green,Blue);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            List<ColorUniverse> inputs =new List<ColorUniverse>();
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (input == "End") break;
                var rez = input.Split(' ');
                if (rez.Length < 4) continue;
                ColorUniverse color = new ColorUniverse();
                color.Volume = Math.Round(Double.Parse(rez[0]),2);
                color.Red = int.Parse(rez[1]);
                color.Green = int.Parse(rez[2]);
                color.Blue= int.Parse(rez[3]);
                if (color.IsReindrop) inputs.Add(color);
            }
            while (true);
            Console.WriteLine($"Rainbow Raindrops: {inputs.Count}");
            int n = 1;
            foreach (var item in inputs.OrderBy(e=>e.Volume))
            {
                Console.WriteLine(string.Format("{0}. {1}",n,item));
                n++;
            }
        }
       
    }
}
