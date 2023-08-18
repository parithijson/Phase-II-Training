
using MySample;
/* Banking System */

Console.WriteLine("Enter your account number:");
long AccountNumber = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Enter your account number:");
String AccountHolderName = Console.ReadLine();
Console.WriteLine("Enter a amount to deposit:");
int DepositAmount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a amount to Withdraw:");
int WithDrawAmount = Convert.ToInt32(Console.ReadLine());



BankAccount bankAccount = new BankAccount(AccountNumber, AccountHolderName);
bankAccount.Deposit(DepositAmount);
int WithDrawAcc = bankAccount.WithDraw(WithDrawAmount);

Console.WriteLine();

if (WithDrawAcc == 0)
{
    Console.WriteLine("Sorry insufficient Balance");
}
else if (WithDrawAcc == 1)
{
    bankAccount.AccountDetails();
}


Console.WriteLine();

/* Library Management System */


Library library = new Library();
library.DisplayBooks();
Console.WriteLine();
Console.WriteLine("Enter a Book name:");
string? bookName = Console.ReadLine();
int Borrowresult = library.BorrowBooks(bookName);
int ReturnResult = library.ReturnBook(bookName);
Console.WriteLine();


if(Borrowresult == 1)
{
    Console.WriteLine("Book has been borrowed");
}
else
{
    Console.WriteLine("Book is'nt available");
}

if (ReturnResult == 1)
{
    Console.WriteLine("Book has been returned !");
}
else
{
    Console.WriteLine("Sorrry");
}
