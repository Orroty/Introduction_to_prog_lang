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



//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

int NumberOfPositiveMembers(int[] arr)
{
    int count = 0;
    foreach(int i in arr)
    {
        if (i % 2 == 0) count++;
    }
    return count;
}

if(insertOfOneNumber(out int numMass, "элементов массива"))
{
    var array = CreateRandomArray(numMass, 100, 999);
    ShowArray(array);
    Console.WriteLine("В массиве "+ NumberOfPositiveMembers(array) + " четных элементов");
}


Console.ReadKey();
Console.Clear();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6]-> 0

Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

int SumOfOddNumbers(int[] arr)
{
    int count = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
        count += arr[i];

    return count;
}

if (insertOfOneNumber(out  numMass, "элементов массива") && insertOfOneNumber(out int min_a, " минимального размера массива") && insertOfOneNumber(out int max_a, " максимального размера массива"))
{
    var array = CreateRandomArray(numMass, min_a, max_a);
    ShowArray(array);
    Console.WriteLine("Сумма элементов на нечетных позициях равна: " + SumOfOddNumbers(array));
}



Console.ReadKey();
Console.Clear();

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");



double realnumbers(double[] arr)
{
    int max = 0;
    int min = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[max] < arr[i])
        {
            max = i;
        }
        if (arr[min] > arr[i])
        {
            min = i;
        }
    }
    return arr[max] - arr[min];
}

double[] CreateRandomDoubleArray(int size = 8)
{
    double[] array = new double[size];
    var rand = new Random(DateTime.Now.Millisecond);
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble()*rand.Next();
    }
    return array;
}

void ShowDoubleArray(double[] array)
{
    foreach (double i in array) { Console.Write(" | " + i); }
    Console.WriteLine(" |");
}


if (insertOfOneNumber(out numMass, "элементов массива"))
{
    var array = CreateRandomDoubleArray(numMass);
    ShowDoubleArray(array);
    Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + realnumbers(array));
}



Console.ReadKey();
Console.Clear();