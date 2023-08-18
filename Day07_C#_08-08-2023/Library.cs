using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTask
{
    class Library
    {
        
        private readonly List<Book> _books = new List<Book>();

        public Library()
        {
            _books = new List<Book>
            {
                new Book(1,"Brief Answers to the Big Questions","Stephen Hawking",true),
                new Book(2,"The Science of Interstellar","Kip Thorne",true),
                new Book(3,"Life of Galileo","Berlot brecht",false),
                new Book(4,"The Sleepwalkers","Arthur koestler",false),
                new Book(5,"A Brief History of Time","Stephen Hawking",true),
                new Book(6,"The First Three Minutes","Steven Weinberg",true),
                new Book(7,"Time Travel in Einstein's Universe","Richard Gott",true),
                new Book(8,"Time Travel in Einstein's Universe","Richard Gott",true),
                new Book(9,"Relativity","Albert Einstein",true),
                new Book(10,"The Edge of Reaseon","Lawrance Krauss",true)
            };

        }

        public List<Book> Books => _books;

        public int BorrowBooks(string? title) { 
        
             
            foreach (var item in Books)
            {

                if (item.Title.Equals(title) && item.IsAvail)
                {

                    item.LendItem(title);
                    return 1;

                }

            }
            return 0;

        }
           

        

        public int ReturnBook(string title)
        {
            foreach (var item in Books)
            {
                if(item.Title == title && !item.IsAvail)
                {
              
                    item.LendItem(title);
                    return 1;

                }
               
            }
            return 0;
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Available Books");
            Console.WriteLine("_______________");
            foreach (var book in Books)
            {
                if (book.IsAvail)
                {
                    Console.WriteLine(book.Title + " " + book.IsAvail);
                }               
            }
        }
    }
}
