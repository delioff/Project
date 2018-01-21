
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

public class Book
{
    public string Title { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public DateTime ReleaseDate { get; set; }

    public static Book ReadBook()
    {
        string[] book = Console.ReadLine().Split(' ');
        Book b = new Book() { Name = book[1], Price = decimal.Parse(book[5]), Title = book[0], ReleaseDate = DateTime.ParseExact(book[3], "dd.MM.yyyy", CultureInfo.InvariantCulture) };
        return b;
    }
}

public class Library
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Programa
{
    static void Main(string[] args)
    {

        int number = int.Parse(Console.ReadLine());
        List<Book> books = new List<Book>();
        for (int i = 0; i < number; i++)
        {
            Book b1 = Book.ReadBook();
            books.Add(b1);
        }
        List<Library> libs = new List<Library>();
        for (int i = 0; i < books.Count; i++)
        {
            Library l1 = new Library() { Name = books[i].Name };
            if (libs.Any(e => e.Name == l1.Name))
            {
                for (int s = 0; s < libs.Count; s++)
                {
                    if (libs[s].Name == l1.Name)
                    {
                        libs[s].Price += books[i].Price;
                    }
                }
            }
            else
            {
                l1.Price = books[i].Price;
                libs.Add(l1);
            }
        }
        List<Library> output = new List<Library>(libs.OrderByDescending(s => s.Price).ThenBy(a => a.Name).ToList());
        foreach (var item in output)
        {
            Console.WriteLine("{0} -> {1:f2}", item.Name, item.Price);
        }
    }
}


