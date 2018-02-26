using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public string Title
    {
        get => this.title;
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get => this.author;
        set
        {
            string[] authorNames = value
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (authorNames.Length == 2)
            {
                char[] chArray = authorNames[1].ToCharArray();
                if (char.IsDigit(chArray[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get => this.price;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name}\n" +
               $"Title: {this.Title}\n" +
               $"Author: {this.Author}\n" +
               $"Price: {this.Price:f2}";
    }
}