using System.Globalization;

bool insertOfOneNumber(out int number, string name) //ввод A
{
    Console.Write("Введите число " + name + "    - >    ");

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

//Задайте двумерный массив размером m*n, заполненный случайными целыми числами

Console.WriteLine("Задайте двумерный массив размером m*n, заполненный случайными целыми числами");

int[,] Create2DRandomArray(int rows = 5, int columns = 5, int min_val = 0, int max_val = 99)
{
    int[,] array = new int[rows,columns];
    if (min_val > max_val)
    {
        int temp = min_val;
        min_val = max_val;
        max_val = temp;
    }
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(min_val, max_val + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i =0; i<array.GetLength(0);i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((" | " + array[i,j]).PadRight(7));
        }
        Console.WriteLine(" |");
    }
}

if(insertOfOneNumber(out int rows, " строк") && insertOfOneNumber(out int col, " столбцов") && insertOfOneNumber(out int min_a, " минимального значения массива") && insertOfOneNumber(out int max_a, " максимального значения массива"))
{
    Show2DArray(Create2DRandomArray(rows, col, min_a, max_a));
}

Console.ReadKey();
Console.Clear();


//Задача 2. ****Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

Console.WriteLine("Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.");

int[,] Create2DNotRandomArray(int rows = 5, int columns = 5)
{
    int[,] array = new int[rows, columns];
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i+j;
        }
    }
    return array;
}


if (insertOfOneNumber(out  rows, " строк") && insertOfOneNumber(out  col, " столбцов") )
{
    Show2DArray(Create2DNotRandomArray(rows, col));
}

Console.ReadKey();
Console.Clear();

// Задача 3.Задайте двумерный массив.Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

//Например, изначально массив выглядел вот так:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//Новый массив будет выглядеть вот так:

//1 4 7 2
//5 **81  ** 2 **9**
//8 4 2 4

Console.WriteLine("Задача 3.Задайте двумерный массив.Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.");

int[,] ArrayEvenSqare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i=i+2)
    {
        for (int j = 0; j < array.GetLength(1); j=j+2)
        {
            array[i, j] = array[i, j] * array[i, j]; 
        }
    }
    return array;
}


if (insertOfOneNumber(out  rows, " строк") && insertOfOneNumber(out  col, " столбцов") && insertOfOneNumber(out  min_a, " минимального значения массива") && insertOfOneNumber(out  max_a, " максимального значения массива"))
{
    var arr = Create2DRandomArray(rows, col, min_a, max_a);
    Show2DArray(arr);
    Console.WriteLine();
    Show2DArray(ArrayEvenSqare(arr));
}


Console.ReadKey();
Console.Clear();

//Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

//Например, задан массив:

//1 4 7 2                      Главная диагональ это когда i и j совпадают
//5 9 2 3
//8 4 2 4

//Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Задача 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.");

int SummDiag(int[,] arr)
{
    int result = 0;

    int min = arr.GetLength(0);
    if (min > arr.GetLength(1))
    {
        min = arr.GetLength(1);
    }

    for(int i = 0; i < min; i++)
    {
        result += arr[i, i];
    }
    return result;
}

if (insertOfOneNumber(out rows, " строк") && insertOfOneNumber(out col, " столбцов") && insertOfOneNumber(out min_a, " минимального значения массива") && insertOfOneNumber(out max_a, " максимального значения массива"))
{
    var arr = Create2DRandomArray(rows, col, min_a, max_a);
    Show2DArray(arr);
    Console.WriteLine();
    Console.WriteLine("Сумма диагонали  - >" + SummDiag(arr));
}


Console.ReadKey();
Console.Clear();

