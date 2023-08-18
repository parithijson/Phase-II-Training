using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySample;

namespace MySample
{
    class Library
    {
       private readonly List<Book> _books = new List<Book>();

       public Library() {
            _books = new List<Book>
            {
                new Book(1,"Brief Answers to the Big Questions","tephen Hawking",true),
                new Book(2,"The Science of Interstellar","Kip Thorne",true),
                new Book(3,"Life of Galileo","Berlot brecht",false),
                new Book(4,"The Sleepwalkers","Arthur koestler",false)
            };
            
        }

        public List<Book> Books => _books;

        public int BorrowBooks(string title)
        {
            foreach (var item in Books)
            {
                if (item.Title == title && item.IsAvail)
                {
                    item.IsAvail = false;
                    return 1;
    
                }

            }
            return 0;
            
        }

        public int ReturnBook(string title)
        {
            foreach (var item in Books)
            {
                if (item.Title == title && !item.IsAvail) {
                item.IsAvail = true;
                return 1;
                }
            }
        return 0;
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Available Books");
            Console.WriteLine("_______________");
            foreach (var book in Books) {

                Console.WriteLine(book.Title);
            }
        }
    }
}
