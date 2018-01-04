using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var points = ReadPoints();
            var rez = FindClosestPoints(points);
            Console.WriteLine($"{CalculateDistance(rez[0], rez[1]):f3}");
            Console.WriteLine($"({rez[0].X}, {rez[0].Y})");
            Console.WriteLine($"({rez[1].X}, {rez[1].Y})");
        }
        static Point[] FindClosestPoints(Point[] points)
        {
            var poits = new Point[2];
            var mindistance = double.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    var dis = CalculateDistance(points[i], points[j]);
                    if (dis < mindistance)
                    {
                        mindistance = dis;
                        poits[0] = points[i];
                        poits[1] = points[j];
                    }
                }
            }
            return poits;
        }
        static double CalculateDistance(Point p1, Point p2)
        {
            var a = Math.Abs(p1.X - p2.X);
            var b = Math.Abs(p1.Y - p2.Y);
            var c = Math.Sqrt(a * a + b * b);
            return c;
        }
        static Point ReadPoint()
        {
            var sale = new Point();
            var input = Console.ReadLine().Split(' ');
            sale.X = int.Parse(input[0]);
            sale.Y = int.Parse(input[1]);
            
            return sale;
        }
        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (var i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }
            return points;
        }
    }
}
