

double num1, num2;
int res;

num1 =  Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());

res = (int) (num1 + num2);

Console.WriteLine(res); 



int num = Convert.ToInt32(Console.ReadLine());
int rem,sum= 0;
int temp = num;
while (num>0)
{
    rem = num % 10;
    sum += (rem * rem * rem);
    num /= 10;
}

if(sum == temp)
{
    Console.WriteLine("Arm");
}
else
{
    Console.WriteLine("Not Arm");
}



/* perfect numbers */


int inc = 1;
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;



while(inc < num)
{
    if(num % inc == 0)
    {
        sum += inc;
        
    }

    inc++;

}
if (sum == num)
{
    Console.WriteLine("It's perfect number!");
}
else
{
    Console.WriteLine("It's not prefect number!");
}



int begin = Convert.ToInt32(Console.ReadLine());
int end = Convert.ToInt32(Console.ReadLine());
int count;
Console.WriteLine("The prime numbers between " + begin + " and " + end + " is :");
for (int i = begin; i <= end; i++)
{
    count = 0;
    for (int j = 2; j <= begin / 2; j++)
    {
        if (i % j == 0)
        {
            count++;
            break;
        }
    }
    if (count == 0)
    {
        Console.WriteLine(i);
       

}



/*string firstName = "Potter";
string lastName = "json";
String welcome = $"My full name is :{firstName}{lastName}";
Console.WriteLine(welcome);*/

class Car
{
    public string color = "red";

    static void Main(string[] args)
    {
        Car car = new Car();
        Console.WriteLine(car.color);
    }
}


class Vec : Car
{
    public string model = "Mustang";
}

class Programs
{
    static void Main(String[] args)
    {
        Vec vec = new Vec();
        Console.WriteLine(vec.model);
        Console.WriteLine(vec.color);
    }
}
