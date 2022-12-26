bool insertOfOneNumber(out int number, string name) //ввод текста в консоли и преобразование его в число number. Текстовая переменная name используется для уточнения запроса в консоли
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

int[,] Create2DRandomArray(int rows = 5, int columns = 5, int min_val = 0, int max_val = 99)
{
    int[,] array = new int[rows, columns];
    if (min_val > max_val)
    {
        int temp = min_val;
        min_val = max_val;
        max_val = temp;
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min_val, max_val + 1);
        }
    }
    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write((" | " + array[i, j]).PadRight(7));
        }
        Console.WriteLine(" |");
    }
}

void Show2DDoubleArray(double[,] array) //вывод double массивов (Перегрузка методов не работает)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" | " + String.Format("{0:0.00}", array[i, j]).PadRight(7));
        }
        Console.WriteLine(" |");
    }
}

//Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//m = 3, n = 4.

//0,5 7 -2 -0,2

//1 -3,3 8 -9,9

//8 7,8 -7,1 9

Console.WriteLine("Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");



double[,] Create2DRandomDoubleArray(int rows = 5, int columns = 5, int maxminNumber = 1000) // создание массива размером rows*colums со значениями от - maxminNumber до + maxminNumber
{
    double[,] array = new double[rows, columns];
    if (maxminNumber < 0) maxminNumber = -maxminNumber;

    var rand = new Random(DateTime.Now.Millisecond);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.NextDouble() * rand.Next(-maxminNumber, maxminNumber); ;
        }
    }
    return array;
}




if (insertOfOneNumber(out int rows, " строк") && insertOfOneNumber(out int col, " столбцов") && insertOfOneNumber(out int maximumValue, " максимальное/минимальное для массива"))
{
    Show2DDoubleArray(Create2DRandomDoubleArray(rows, col, maximumValue));
}



Console.ReadKey();
Console.Clear();

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17->такого числа в массиве нет



Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

// получение данных из массива по одному числу индексу
// индексы в массиве тогда идут так
// 0  1  2  3  4
// 5  6  7  8  9
// 10 11 12 13 14
bool GetDataFromElement1(int[,] array , int num , ref int result ) 
{
    if (num > array.Length)
    {
        return false;
    }
    else
    {
        result = array[(num-1)/array.GetLength(0),(num-1)%array.GetLength(1)];
        return true;
    }
}

// получение данных из массива по двум индексам - строки и столбца
bool GetDataFromElement2(int[,] array, int row, int collum, ref int result)
{
    if (row >= array.GetLength(0) || collum >= array.GetLength(1))
    {
        return false;
    }
    else
    {
        result = array[row, collum];
        return true;
    }
}

// поиск числа в массиве по значению с возвратом  строки и столбца, и порядкового номерв
bool GetDataFromElement3(int[,] array, int num, ref int[] result)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                result[0] = i;
                result[1] = j;
                result[2] = array.GetLength(0) * i + j + 1;
                return true;
            }
        }
    }
    return false;
}

// недопонял задание
// (по заданию ближе всего 2 метод в 1 пункте,
// по примеру в запросе (17) - ближе 1 метод 1 пункта,
// по ответу на запрос вообще ближе метод из 2 пункта)
void GetDataFromElementMain(int[,] arr) 
{
    int res = 0;

    Console.WriteLine(" 1. Если надо найти число по индексам \n");
    Console.WriteLine("     Первый метод");


    if (insertOfOneNumber(out int number, " позицию в двоичном массиве"))
    {
        if (GetDataFromElement1(arr,number,ref res))
        {
            Console.WriteLine($" На {number} позиции в массиве находится число {res}");
        }
        else
        {
            Console.WriteLine($" Числа с позицией {number} в массиве нет");
        }
    }

    Console.WriteLine("\n     Второй метод");

    if (insertOfOneNumber(out int row, " строку в двоичном массиве") && insertOfOneNumber(out int coll, " столбец в двоичном массиве"))
    {
        if (GetDataFromElement2(arr, row, coll, ref res))
        {
            Console.WriteLine($" На [{row},{coll}] позиции в массиве находится число {res}");
        }
        else
        {
            Console.WriteLine($" Числа с позицией [{row},{coll}] в массиве нет");
        }
    }

    
    Console.WriteLine("\n 2. Если надо найти существует ли данное число и вернуть индексы \n");
    
    if (insertOfOneNumber(out  number, " для проверки на наличие в массиве"))
    {
        int[] temp = new int[3]; // массив с результатами 0 элемент - строка, 1 элемент - столбец, 2 элемент номер по порядку из первого метода
        if (GetDataFromElement3(arr, number, ref temp))
        {
            Console.WriteLine($" Число {number}  в массиве находится на позиции [{temp[0]},{temp[1]}] и является {temp[2]} по порядку");
        }
        else
        {
            Console.WriteLine($" Числа с позицией {number} в массиве нет");
        }
    }

}


if (insertOfOneNumber(out  rows, " строк") && insertOfOneNumber(out  col, " столбцов") && insertOfOneNumber(out int min_a, " минимального значения массива") && insertOfOneNumber(out int max_a, " максимального значения массива"))
{
    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Show2DArray(array);

    Console.WriteLine();

    GetDataFromElementMain(array);
}


Console.ReadKey();
Console.Clear();


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

double[,] FindAverageColumnsIn2DArray(int[,] array)
{
    double[,] averages = new double[1, array.GetLength(1)]; // использую двумерный массив с 1 строкой, чтобы повторно не создавать метод для вывода одномерных массивов
    for(int i = 0; i < array.GetLength(1); i++) // столбец
    {
        for(int j =0; j < array.GetLength(0); j++) // строка
        {
            averages[0,i] += array[j, i];  
        }
        averages[0,i] /= array.GetLength(0); //делю на количество строк
    }
    return averages;
}


if (insertOfOneNumber(out rows, " строк") && insertOfOneNumber(out col, " столбцов") && insertOfOneNumber(out  min_a, " минимального значения массива") && insertOfOneNumber(out  max_a, " максимального значения массива"))
{
    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Show2DArray(array);
    Console.WriteLine("\n Средние по столбцам равны: \n");

    Show2DDoubleArray(FindAverageColumnsIn2DArray(array));
}


Console.ReadKey();
Console.Clear();