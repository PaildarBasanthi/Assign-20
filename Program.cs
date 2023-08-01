using Assignment_20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Please Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter a Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Name of the Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Is Available (true/false): ");
                        bool isAvailable = bool.Parse(Console.ReadLine());

                        Book newBook = new Book(bookId, title, author, genre, isAvailable);
                        library.AddBook(newBook);
                        break;

                    case 2:
                        Console.WriteLine("All Books:");
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter a Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter a Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice choosen. Please try again.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
