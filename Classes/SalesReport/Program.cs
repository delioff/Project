using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Sale
    {
        public string Town { get; set;}
        public string Product { get; set;}
        public double Price { get; set;}
        public double Quantity { get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();
            var towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (string town in towns)
            {
                var salesByTown = sales.Where(s => s.Town == town)
                .Select(s => s.Price * s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
            }
        }
        static Sale ReadSale()
        {
            var sale = new Sale();
            var input = Console.ReadLine().Split(' ');
            sale.Town = input[0];
            sale.Product = input[1];
            sale.Price = double.Parse(input[2]);
            sale.Quantity = double.Parse(input[3]);
            return sale;
        }
        static Sale[] ReadSales()
        {
            var n = int.Parse(Console.ReadLine());
            var sales = new Sale[n];
            for (var i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }
            return sales;
        }
    }
}
