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



//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4-> 16

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");


ulong Pow_A_To_B_WithLoop(int A, int B)
{
    ulong res = 1;
    for (int i = 0; i < B; i++)
    {
        res = res * (ulong)A;
    }
    return res;
}


if (insertOfOneNumber(out int NumA, "A - число для возведения") && insertOfOneNumber(out int NumB, "B - степень в которую будут возводить"))
{
    Console.WriteLine($"Число {NumA} возведенное в степень {NumB} равно {Pow_A_To_B_WithLoop(NumA, NumB)}    (Для проверки функция Math.Pow  ->  {Math.Pow(NumA, NumB)})");
}


Console.ReadKey();
Console.Clear();

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");


void SumOfDigitsInNumber(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма всех цифр равна {sum}");
}


if (insertOfOneNumber(out int num, ""))
{
    SumOfDigitsInNumber(num);
}

Console.ReadKey();
Console.Clear();

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33-> [6, 1, 33]
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

int[] CreateRandomArray(int size = 8, int min_val = 0, int max_val = 99)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++) 
    { 
        array[i] = new Random().Next(min_val, max_val + 1); 
    }
    return array;
}

void ShowArray(int[] array)
{
    foreach (int i in array) { Console.Write(" | " + i); }
    Console.WriteLine(" |");
}


ShowArray(CreateRandomArray());
Console.WriteLine();

if (insertOfOneNumber(out int leng, " размера массива") && insertOfOneNumber(out int min_a, " минимального размера массива") && insertOfOneNumber(out int max_a, " максимального размера массива"))
{
    ShowArray(CreateRandomArray(leng, min_a, max_a));
}



Console.ReadKey();