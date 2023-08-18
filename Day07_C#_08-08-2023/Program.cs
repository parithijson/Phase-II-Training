using myTask;

Library library = new Library();
int choice;
do
{
    Console.WriteLine();

    Console.WriteLine("Enter your choice");
    Console.WriteLine("\n 1.Available Books \n 2.Borrow Book \n 3.Return Book \n 4.Exit \n");
    choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    switch (choice)
    {
        case 1:
            library.DisplayBooks();
            Console.WriteLine();
            break;
        case 2:
            Console.WriteLine("Enter Book Title to borrow\n");
            string? title = Console.ReadLine();
            int bresult = library.BorrowBooks(title);
            Console.WriteLine();

            if (bresult == 1)
            {
                Console.WriteLine("Successfully Borrowed!");
                Console.WriteLine();

            }
            else if(bresult == 0)
            {
                Console.WriteLine("Sorry");
                Console.WriteLine();


            }
            break;
        case 3:
            Console.WriteLine("Enter Book Title to return\n");
            string? rtitle = Console.ReadLine();
            int rreuslt = library.ReturnBook(rtitle);
            Console.WriteLine();

            if (rreuslt == 1)
            {
                Console.WriteLine("Successfully Returned!");
                Console.WriteLine();

            }
            else if (rreuslt == 0)
            {
                Console.WriteLine("Sorry");
                Console.WriteLine();


            }
            break;
        case 4:
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
} while (choice != 4);
