//**Задание 1:**Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7->max = 7
//a = 2 b = 10->max = 10
//a = -9 b = -3->max = -3

Console.Clear();
Console.WriteLine("Задание 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее");

int firstNumber1 = 0;
int secondNumber1 = 0;

Console.WriteLine("Введите первое число");

if (Int32.TryParse(Console.ReadLine(), out firstNumber1))
{
    Console.WriteLine("Введите второе число");

    if (Int32.TryParse(Console.ReadLine(), out secondNumber1))
    {
        Console.WriteLine($"Из двух чисел {firstNumber1} и {secondNumber1} максимальное " + ((firstNumber1 > secondNumber1) ? firstNumber1 : secondNumber1));
    }
    else
    {
        Console.WriteLine("Второй ввод не является числом");
    }
}
else
{
    Console.WriteLine("Первый ввод не является числом");
}

Console.ReadKey();

////* *Задание 2:**Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

////2, 3, 7 -> 7
////44 5 78 -> 78
////22 3 9 -> 22

Console.Clear();
Console.WriteLine("Задание 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");

int number1 = 0;

Console.WriteLine("Введите первое число");

if (Int32.TryParse(Console.ReadLine(), out number1))
{
    int max = number1;

    Console.WriteLine("Введите второе число");

    if (Int32.TryParse(Console.ReadLine(), out number1))
    {
        Console.WriteLine("Введите третье число");

        max = number1 > max ? number1 : max;

        if (Int32.TryParse(Console.ReadLine(), out number1))
        {
            max = number1 > max ? number1 : max;
            Console.WriteLine("Максимальное число " + max);
        }
        else
        {
            Console.WriteLine("Третий ввод не является числом");
        }
    }
    else
    {
        Console.WriteLine("Второй ввод не является числом");
    }
}
else
{
    Console.WriteLine("Первый ввод не является числом");
}

Console.ReadKey();

////**Задание 3:**Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

////4->да
////- 3->нет
////7->нет

Console.Clear();
Console.WriteLine("Задание 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");

int number2 = 0;

Console.WriteLine("Введите число");

if (Int32.TryParse(Console.ReadLine(), out number2))
{
    
    if ((number2 % 2) == 0)
    {
        Console.WriteLine($"Число {number2} четное");
    }
    else
    {
        Console.WriteLine($"Число {number2} нечетное");
    }
}
else
{
    Console.WriteLine("Ваш ввод не является числом");
}
Console.ReadKey();

////* *Задание 4:**Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

////5  -> 2, 4
////8  -> 2, 4, 6, 8

Console.Clear();
Console.WriteLine("Задание 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

int number3 = 0;

Console.WriteLine("Введите число");

if (Int32.TryParse(Console.ReadLine(), out number3))
{
    for(int i = 2;i<= number3; i = i + 2)
    {
        if (i == number3 || i == (number3 - 1))
        { 
            Console.WriteLine(i);
        }
        else
        {
            Console.Write(i + ", ");
        }
    }
}
else
{
    Console.WriteLine("Ваш ввод не является числом");
}

Console.ReadKey();