using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_20
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }

        public Book(int bookId, string title, string author, string genre, bool isAvailable)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = isAvailable;
        }


    }
}
