using System;
using System.Security.Cryptography;

namespace Book
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Book()
        {
        }

        public Book(string name, string author, string Category)
        {
            this.Name = name;
            this.Author = author;
            this.Category = Category;
   
        }

        public virtual  void Input()
        {
            Console.WriteLine("Enter name of book");
            Name = Console.ReadLine();
            
            Console.WriteLine("Enter Auther's name");
            Author = Console.ReadLine();
            
            Console.WriteLine("Enter genge");
            Category = Console.ReadLine();

        }

        public virtual void Display()
        {
            Console.WriteLine("Book Information(Name of book : {0}, " +
                              "\nAuther's name : {1}" +
                              "\nCategory : {2}", Name, Author, Category);
        }

    }
}