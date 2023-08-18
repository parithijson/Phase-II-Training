using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    internal class Book
    {
        private readonly int _bookId;
        private string title;
        private string author;
        private bool isAvail;

        public Book(int bookId, string title, string author, bool isAvail)
        {
            _bookId = bookId;
            Title = title;
            Author = author;
            IsAvail = isAvail;
           
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public bool IsAvail { get => isAvail; set => isAvail = value; }
    }
}
