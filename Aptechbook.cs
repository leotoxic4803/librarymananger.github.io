using System;

namespace Book
{
    public class AptechBook : Book
    {
        public string language { get; set; }

        public AptechBook()
        {
        }

        public AptechBook(string name, string author, 
            string Category, string language,
            string semester) : base(name,author, Category)
        {
            this.language = language;
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter language");
            language = Console.ReadLine();
        }

        public override void Display()
        {
            Console.WriteLine("Book Information(Name of book : {0}, " +
                              "\nAuther's name : {1}" +
                              "\nCategory : {2}" +
                              "\nlanguage: {3}", Name, Author, Category, language);
        }
        public void UpdateBookInformation(string name, string author, string category)
        {
            Name = name;
            Author = author;
            Category = category;
            Console.WriteLine("Edited ...");
        }
    }   

}