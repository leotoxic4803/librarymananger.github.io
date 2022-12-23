using System;
using System.Collections.Generic;
using System.Linq;
using Book;

namespace Book
{
   class Program
  {
    public static void Main(string[] args)
    {
      List<AptechBook> aptechBooks = new List<AptechBook>();
      int choose;

      do
      {
        Showmenu();
        choose = Int32.Parse(Console.ReadLine());

        switch (choose)
        {
          case 1:
            Input(aptechBooks);
            break;
          case 2:
            Display(aptechBooks);
            break;
          case 3:
            Searchingbytitlebook(aptechBooks);
            break;
          case 4:
            FindbyAuthorname(aptechBooks);
            break;
          case 5:
            UpdateBook(aptechBooks);
            break;
          default:
            Console.WriteLine("Enter Again");
            break;
          case 6:
            Delete(aptechBooks);
            break;
          case 7:
            Console.WriteLine("End the App");
            break;
        }
      } while (choose != 7);
    }
    static void FindbyAuthorname(List<AptechBook> aptechBooks)
    {
      Console.WriteLine("Enter Author name");
      string searching = Console.ReadLine();

      for (int i = 0; i < aptechBooks.Count; i++)
      {
        if (aptechBooks[i].Author.Equals(searching))
        {
          aptechBooks[i].Display();
        }
      }
    }
    static void Searchingbytitlebook(List<AptechBook> aptechBooks)
    {
      Console.WriteLine("Enter title book");
      string searching = Console.ReadLine();

      for (int i = 0; i < aptechBooks.Count; i++)
      {
        if (aptechBooks[i].Category.Equals(searching))
        { 
          aptechBooks[i].Display();
        }
      }
    }
    static void Display(List<AptechBook> aptechBooks)
        {
          for (int i = 0; i < aptechBooks.Count; i++)
          {
            aptechBooks[i].Display();
          }
        }
      
    

    static void Input(List<AptechBook> aptechBooks)
    {
      Console.WriteLine("How many book?");
      int n = Int32.Parse(Console.ReadLine());

      for (int i = 0; i < n; i++)
      {
        AptechBook book = new AptechBook();
        book.Input();
        aptechBooks.Add(book);
      }
    }

    static void UpdateBook(List<AptechBook> aptechBooks)
    {
      Console.WriteLine("Enter category book");
      string searching = Console.ReadLine();
      var result = new AptechBook();
      for (int i = 0; i < aptechBooks.Count; i++)
      {
        if (aptechBooks[i].Category.Equals(searching))
        { 
          result = aptechBooks[i];
        }
      }
      Console.Write("Enter book name: ");
      result.Name=Console.ReadLine();
      Console.Write("\nEnter Author name: ");
      result.Author=Console.ReadLine();
      Console.Write("\nEnter Category name: ");
      result.Category=Console.ReadLine();
      Console.WriteLine("Edited");
    }

    static void Delete(List<AptechBook> aptechBooks)
    {
      Console.WriteLine("Enter name book");
      string searching = Console.ReadLine();
      var result = aptechBooks.FirstOrDefault(a => a.Name == searching);
      if (result == null)
      {
        Console.WriteLine("Book does not exist");
      }
      else
      {
        aptechBooks.Remove(result);
        Console.WriteLine("Deleted");
      }
    }

    static void Showmenu()
    {
      Console.WriteLine("1. Enter Book Information");
      Console.WriteLine("2. Print Book Information");
      Console.WriteLine("3. Find by Book title ");
      Console.WriteLine("4. Find by Author name");
      Console.WriteLine("5. Update");
      Console.WriteLine("6. Delete");
      Console.WriteLine("7. Exit");
      Console.WriteLine("Option");
    }
  }
}