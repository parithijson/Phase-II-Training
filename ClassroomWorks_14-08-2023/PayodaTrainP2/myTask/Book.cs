using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask
{
    class Book : ILendable
    {
        private readonly int _bookId;
        private string? title;
        private string? author;
        private bool isAvail;

        public Book(String title, string author, bool isAvail)
        {
           
            Title = title;
            Author = author;
            IsAvail = isAvail;

        }

        public string? Title { get => title; set => title = value; }
        public string? Author { get => author; set => author = value; }
        public bool IsAvail { get => isAvail; set => isAvail = value; }


        public void DisplayBookDetails()
        {
            Console.WriteLine($"Book Name: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            if (IsAvail)
            {
                Console.WriteLine("Book is avail");
            }
            else
            {
                Console.WriteLine("Book is unvail");
            }
        }

      

        public void LendItem(string? title)
        {
            if (Title == title && IsAvail)
            {
                IsAvail = false;


            }
            else if (Title == title && !IsAvail)
            {
                IsAvail = true;
            }
        }
    }
}
