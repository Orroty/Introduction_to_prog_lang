//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

//78 -> 8

//12-> 2

//85 -> 8

int MaxNumber(int num)
{
    if(num/10 > num % 10)
    {
        return num / 10;
    }
    else
    {
        return num % 10;
    }
}

int DelitNumber(int num)
{
    return ((num / 100) * 10 + (num % 10));
}

void KratNumber(int num1, int num2)
{
    if (num2 % num1 == 0)
    {
        Console.WriteLine(num2 + " кратно " + num1 );
        return;
    }
    Console.WriteLine(num2 + " не кратно " + num1 + " остаток равен " + num1 % num2);
}

void squareNumber(int num1, int num2)
{
    if (num2 * num2 == num1)
    {
        Console.WriteLine(num1 + " является квадратом " + num2);
        return;
    }
    Console.WriteLine(num1 + " не является квадратом " + num2 );
}

bool Krat7And23(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
    {
        return true;
    }
    else
        return false;
}


int firstNumber1, secondNumber1;


Console.Clear();

int randomNumber = new Random().Next(10, 100);
Console.WriteLine("Рандомное число: " + randomNumber);

Console.WriteLine("Максимальная цифра в числе " + randomNumber + " -> " + MaxNumber(randomNumber));

Console.ReadKey();


Console.WriteLine("Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.");

//456 -> 46

//782 -> 72

//918 -> 98

Console.Clear();

randomNumber = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + randomNumber);

Console.WriteLine("Число из 1 и последней цифры " + randomNumber + " -> " + DelitNumber(randomNumber));

Console.ReadKey();

Console.Clear();


Console.WriteLine("Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.");

//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно



Console.WriteLine("Введите первое число");

if (Int32.TryParse(Console.ReadLine(), out firstNumber1))
{
    Console.WriteLine("Введите второе число");

    if (Int32.TryParse(Console.ReadLine(), out secondNumber1))
    {
        KratNumber(firstNumber1, secondNumber1);
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

Console.Clear();


Console.WriteLine("Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.");

//14  ->  нет
//46  ->  нет
//161 ->  да

Console.WriteLine("Введите число");

if (Int32.TryParse(Console.ReadLine(), out firstNumber1))
{
    if (Krat7And23(firstNumber1))
    {
        Console.WriteLine("Число " + firstNumber1 + " является кратным 7 и 23 ");
    }
    else
    {
        Console.WriteLine("Число " + firstNumber1 + " не является кратным 7 и 23 ");
    }
}
else
{
    Console.WriteLine("Первый ввод не является числом");
}

Console.ReadKey();

Console.Clear();


Console.WriteLine("Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.");

Console.WriteLine("Введите первое число");

if (Int32.TryParse(Console.ReadLine(), out firstNumber1))
{
    Console.WriteLine("Введите второе число");

    if (Int32.TryParse(Console.ReadLine(), out secondNumber1))
    {
        squareNumber(firstNumber1, secondNumber1);
    }
    else
    {
        Console.WriteLine(" Второй ввод не является числом");
    }
}
else
{
    Console.WriteLine("Первый ввод не является числом");
}

Console.ReadKey();