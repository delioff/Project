using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Point {
        public int X { get; set; }
        public int Y { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = new Point();
            var entry1 = Console.ReadLine().Split(' ');
            var entry2 = Console.ReadLine().Split(' ');
            p1.X = int.Parse(entry1[0]);
            p1.Y = int.Parse(entry1[1]);
            p2.X = int.Parse(entry2[0]);
            p2.Y = int.Parse(entry2[1]);
            Console.WriteLine($"{CalculateDistance(p1, p2):f3}");
        }
        static double CalculateDistance(Point p1, Point p2)
        {
            var a = Math.Abs(p1.X - p2.X);
            var b=  Math.Abs(p1.Y - p2.Y);
            var c = Math.Sqrt(a * a + b * b);
            return c;
        }
    }
}
