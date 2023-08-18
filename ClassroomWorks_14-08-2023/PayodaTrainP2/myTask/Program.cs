using myTask;
Link link = new Link();
link.ShowResults();
 

ExceptionHadling exceptionHadling = new ExceptionHadling(10,2,0,15);
Console.WriteLine(exceptionHadling.Add());

try
{
    Console.WriteLine(exceptionHadling.Divide());
    exceptionHadling.CheckAge();
}catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}