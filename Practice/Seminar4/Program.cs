//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
Console.WriteLine("Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.");


bool insertOfOneNumber(out int number, string name) //ввод A
{
    Console.WriteLine("Введите число " + name);

    if (Int32.TryParse(Console.ReadLine(), out number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Ввод не является числом");
        return false;
    }
}


int FindSum(int number)
{
    int sum = 0;
    for(int current=1; current<=number; current++)
    {
        sum+= current;
    }
    return sum;
}

if (insertOfOneNumber(out int a, " A"))
{
    Console.WriteLine($"Сумма положительных чисел до {a} равна " + FindSum(a));
}

Console.ReadKey();
Console.Clear();

// Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5

Console.WriteLine("Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.");

int FindLength(int num)
{
    int i = 0;
    for(i = 0; num > 0;i++)
    {
        num = num / 10;
    }
    return i;
}


if (insertOfOneNumber(out int num, " число"))
{
    Console.WriteLine($"В числе {num} цифр - >" + FindLength(num));
}

Console.ReadKey();
Console.Clear();

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

Console.WriteLine("Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");

int FindFact(int N)
{
    int num = 1;
    for (int i = 2; i <= N; i++)
    {
        num = num * i;
    }
    return num;
}

if (insertOfOneNumber(out int n, " N"))
{
    Console.WriteLine($"Факториал {n} равен " + FindFact(n));
}


Console.ReadKey();
Console.Clear();

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

Console.WriteLine("Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.");

int[] CreateRandomArray(int size,int min_val, int max_val)
{
    int[] array = new int[size];
    for(int i = 0; i<size;i++) { array[i] = new Random().Next(min_val, max_val + 1); }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int i in array) { Console.Write(" | " + i); }
    Console.WriteLine(" |" );
}


if (insertOfOneNumber(out int leng, " размера массива") && insertOfOneNumber(out int min_a, " минимального размера массива") && insertOfOneNumber(out int max_a, " максимального размера массива"))
{
    ShowArray(CreateRandomArray(leng, min_a, max_a));
}



Console.ReadKey();
Console.Clear();