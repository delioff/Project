using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public string publisher { get; set; }
    public DateTime releaseDate { get; set; }
    public string ISBNnumber { get; set; }
    public decimal price { get; set; }
}

class Library
{
    public string name { get; set; }
    public List<Book> books { get; set; }
}

class BookLibrary
{
    static void Main(string[] args)
    {
        Library myLibrary = new Library();
        myLibrary.books = new List<Book>();
        myLibrary.name = "Yavor's library";
        int numberOfBooks = int.Parse(Console.ReadLine());
        for (int book = 0; book < numberOfBooks; book++)
        {
            string[] data = Console.ReadLine().Split().ToArray();
            string title = data[0];
            string author = data[1];
            string publisher = data[2];
            DateTime releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string ISBNnumber = data[4];
            decimal price = decimal.Parse(data[5]);
            Book myBook = new Book();
            myBook.title = title;
            myBook.author = author;
            myBook.publisher = publisher;
            myBook.releaseDate = releaseDate;
            myBook.ISBNnumber = ISBNnumber;
            myBook.price = price;
            myLibrary.books.Add(myBook);
        }
        DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

        Dictionary<string, DateTime> filteredBooks = new Dictionary<string, DateTime>();
        for (int book = 0; book < myLibrary.books.Count; book++)
        {
            if (!filteredBooks.ContainsKey(myLibrary.books[book].title))
            {
                filteredBooks.Add(myLibrary.books[book].title, myLibrary.books[book].releaseDate);
            }
            else filteredBooks[myLibrary.books[book].title] = myLibrary.books[book].releaseDate;
        }


        foreach (var book in filteredBooks.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
        {
            string date = book.Value.ToString("dd.MM.yyyy");
            Console.WriteLine("{0:f2} -> {1:f2}", book.Key, date);
        }

    }
}