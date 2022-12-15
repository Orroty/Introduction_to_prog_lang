Console.Clear();
Console.WriteLine("Input number");
int x = 0;
if (Int32.TryParse(Console.ReadLine(), out x))
{
    int y = x * x;
    Console.WriteLine($"Quade of {x} -> {y}");
}
else
{
    Console.WriteLine("You input not a number");
}

Console.ReadKey();

Console.Clear();
int a = 0;
int b = 0;
Console.WriteLine("Input a first number");

if (Int32.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Input a second number");

    if (Int32.TryParse(Console.ReadLine(), out b))
    {
        if (b * b == a)
        {
            Console.WriteLine($"{a} is a quade of {b}");
        }
        else
        {
            Console.WriteLine($"{a} is not a quade of {b}");
        }
    }
    else
    {
        Console.WriteLine("Your 2 input not a number");
    }

}
else
{
    Console.WriteLine("Your 1 input not a number");
}
Console.ReadKey();

//5.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
//2 -> " -2, -1, 0, 1, 2"

Console.Clear();

int n = 0;
Console.WriteLine("Input a number");
if (Int32.TryParse(Console.ReadLine(), out n))
{
    if (n > 0)
    {
        n = -n;
    }
    int temp = -n;
    while (n <= temp)
    {
        Console.Write(n + " ");
        n++;
    }
}
else
{
    Console.WriteLine("Your input not a numbe");
}
Console.ReadKey();

//1.Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

//    456 -> 6

//    782 -> 2

//    918 -> 8
Console.Clear();
int modofnumber = 0;
Console.WriteLine("Input a xxx number");
if (Int32.TryParse(Console.ReadLine(), out modofnumber))
{
    Console.WriteLine($"**Последняя** цифра в {modofnumber} -> {modofnumber % 10}");
}
else
{
    Console.WriteLine("Your input not a numbe");
}

Console.ReadKey();