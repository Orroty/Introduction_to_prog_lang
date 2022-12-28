using System.Runtime.CompilerServices;

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
        Swap(ref min_val, ref max_val);
    }
    max_val += 1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min_val, max_val);
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

//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2



Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
// смена переменных местами
void Swap(ref int x, ref int y)
{
    var t = x;
    x = y;
    y = t;
}

// выборка pivot для сортировки Шоара (quicksort)
int Partition(int[] array, int minIndex, int maxIndex)
{
    var pivot = minIndex - 1;
    for (var i = minIndex; i < maxIndex; i++)
    {
        if (array[i] > array[maxIndex])
        {
            pivot++;
            Swap(ref array[pivot], ref array[i]);
        }
    }

    pivot++;
    Swap(ref array[pivot], ref array[maxIndex]);
    return pivot;
}

// быстрая сортировка -> выбирается точка разделения -> слева все больше точки (pivot), справа все меньше -> рекурсивно вызываются методы quicksort для левой и правой части (pivot не добавляют)
int[] QuickSort(int[] array, int minIndex, int maxIndex)
{


    if (minIndex >= maxIndex)
    {
        return array;
    }

    var pivotIndex = Partition(array, minIndex, maxIndex);
    QuickSort(array, minIndex, pivotIndex - 1);
    QuickSort(array, pivotIndex + 1, maxIndex);

    return array;
}


// сортировка на убывание строки, эксперимент с quicksort и LINQ
void SortARowDESC(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        var c = Enumerable.Range(0, arr.GetLength(1))
                .Select(x => arr[i, x])
                .ToArray();  //LINQ запрос на получение строки из двумерного массива
        c = QuickSort(c, 0, arr.GetLength(1) - 1);
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = c[j]; // заносим измененные значения в старый массив
        }
    }

    Show2DArray(arr); // вывод на печать нового массива
}


if (insertOfOneNumber(out int rows, " строк")
    && insertOfOneNumber(out int col, " столбцов") 
    && insertOfOneNumber(out int min_a, " минимального значения массива")
    && insertOfOneNumber(out int max_a, " максимального значения массива"))
{
    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Console.WriteLine("\n До сортировки\n");
    Show2DArray(array);
    Console.WriteLine("\n После сортировки\n");
    SortARowDESC(array);
}

Console.ReadKey();
Console.Clear();





//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

int FindMinArrayRow(int[,] arr)
{
    long summ = 0; // последняя минимальная сумма
    int result = 0; // возвращаемый индекс

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        var c = Enumerable.Range(0, arr.GetLength(1))
                .Select(x => arr[i, x]).Sum();  //LINQ запрос на получение суммы элементов строки в двумерном массиве

        if (summ > c || i == result)
        {
            result = i;
            summ = c;
        }
    }

    return result;
}


if (insertOfOneNumber(out rows, " строк") 
    && insertOfOneNumber(out col, " столбцов") 
    && insertOfOneNumber(out min_a, " минимального значения массива") 
    && insertOfOneNumber(out max_a, " максимального значения массива"))
{
    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Show2DArray(array);
    int buff;
    Console.WriteLine($"\nПервая строка с минимальной суммй имеет индекс {buff = FindMinArrayRow(array)} (или {buff + 1} если считать от 1)");
}



Console.ReadKey();
Console.Clear();


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

bool ArrayProduct(int[,] arr1, int[,] arr2, ref int[,] Resultarray)
{
    if (arr1.GetLength(1) != arr2.GetLength(0))
    {
        return false;
    }

    Resultarray = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                Resultarray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return true;
}

if (insertOfOneNumber(out rows, " строк 1 массива") 
    && insertOfOneNumber(out col, " столбцов 1 массива")
    && insertOfOneNumber(out min_a, " минимального значения 1 массива") 
    && insertOfOneNumber(out max_a, " максимального значения 1 массива"))
{
    var array1 = Create2DRandomArray(rows, col, min_a, max_a);

    if (insertOfOneNumber(out rows, " строк 2 массива") 
        && insertOfOneNumber(out col, " столбцов 2 массива") 
        && insertOfOneNumber(out min_a, " минимального значения 2 массива") 
        && insertOfOneNumber(out max_a, " максимального значения 2 массива"))
    {
        var array2 = Create2DRandomArray(rows, col, min_a, max_a);
        Console.WriteLine("\n   Первый массив \n");
        Show2DArray(array1);
        Console.WriteLine("\n   Второй массив \n");
        Show2DArray(array2);
        Console.WriteLine();

        int[,] arrayProduct = new int[1, 1];
        if (ArrayProduct(array1, array2, ref arrayProduct))
        {
            Console.WriteLine("Результат перемножения массивов");
            Show2DArray(arrayProduct);
        }
        else
        {
            Console.WriteLine(" Ошибка. Число столбцов 1 массива не совпадает с числом строк 2 массива. ");
        }
    }
}


Console.ReadKey();
Console.Clear();


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0, 1, 0)
//34(1, 0, 0) 41(1, 1, 0)
//27(0, 0, 1) 90(0, 1, 1)
//26(1, 0, 1) 55(1, 1, 1)

Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

//проходит все элементы и сравнивает, если в массиве цифра встречается больше 1 раза, то возвращает false для повторного заполнения
bool CheckIfNotIndividual(int[,,] arr, int value)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i == value) count++;
    }
    return count > 1;
}

// проверяет, хватит ли цифр в интервале для заполнения без повторов
bool CheckPosibilityOfRandomIndividul(int arrSize, int rangeOfRandom)
{
    if (arrSize < rangeOfRandom) return false;
    return true;
}


int[,,] Create3DIndividualRandomArray(int dimmensions = 2, int rows = 2, int columns = 2, int min_val = 0, int max_val = 99)
{
    int[,,] resultArr;
    if (min_val > max_val)
    {
        Swap(ref min_val, ref max_val);
    }
    max_val += 1;

    if (CheckPosibilityOfRandomIndividul(dimmensions * rows * columns, max_val - min_val)) // проверка, хватит ли цифр в рандомном интервале
    {
        Console.WriteLine("Невозможно создать указанное количество неповторяющихся элементов для массива указанного размера");
        resultArr = null;
    }
    else
    {
        resultArr = new int[dimmensions, rows, columns];

        for (int i = 0; i < dimmensions; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < columns; k++)
                {
                    resultArr[i, j, k] = new Random().Next(min_val, max_val);
                    if (CheckIfNotIndividual(resultArr, resultArr[i, j, k])) // проверка, является ли последнее введеное число неповторимым
                    {
                        k--; // если не является, то заполняем заного
                    }
                }
            }
        }
    }
    return resultArr;
}


void Show3DArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        Console.WriteLine($"\n*****    Слой: {i + 1}    *****\n");

        for (int j = 0; j < arr3D.GetLength(1); j++)
        {

            for (int k = 0; k < arr3D.GetLength(2); k++)
            {

                Console.Write((" | " + arr3D[i, j, k] + $" ({i},{j},{k})").PadRight(20));
            }
            Console.WriteLine(" |");
        }
    }
    Console.WriteLine();
}

if (insertOfOneNumber(out int dim, " слоев") 
    && insertOfOneNumber(out rows, " строк") 
    && insertOfOneNumber(out col, " столбцов") 
    && insertOfOneNumber(out min_a, " минимального значения массива") 
    && insertOfOneNumber(out max_a, " максимального значения массива"))
{
    var array = Create3DIndividualRandomArray(dim, rows, col, min_a, max_a);
    if (array != null)
    {
        Show3DArray(array);
    }
}


Console.ReadKey();
Console.Clear();


//Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.WriteLine("Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.");

void SpesialArrayFilling(int[,] array , int startNumber = 1)
{
    int ArrayNotPrintidSideSize = array.GetLength(0);
    int line = 0; //стартовая строка для движения
    int collumn = 0; // стартовый столбец для движения
    int valuetoinsert = startNumber; // вводимое значение

    for (; valuetoinsert < array.Length + startNumber;) // цикл пока значение не будет больше максимума возможного в массиве
    {
        int numberOfSteps1 = 0;
        do
        {
            array[line, collumn++] = valuetoinsert++;
            numberOfSteps1++;
        }
        while (numberOfSteps1 < ArrayNotPrintidSideSize - 1);// движемся вправо до предпоследнего незаполненного столбца используем постпроверку
     

        if (valuetoinsert < array.Length)
        {
            for (int numberOfSteps = 0; numberOfSteps < ArrayNotPrintidSideSize - 1; numberOfSteps++) // движемся вниз до предпоследней незаполненной строки
            {
                array[line++, collumn] = valuetoinsert++;
            }

            for (int numberOfSteps = 0; numberOfSteps < ArrayNotPrintidSideSize - 1; numberOfSteps++) // движемся вправо до второго незаполненного столбца
            {
                array[line, collumn--] = valuetoinsert++;
            }

            for (int numberOfSteps = 0; numberOfSteps < ArrayNotPrintidSideSize - 1; numberOfSteps++) // движемся влево до второй незаполненной строки
            {
                array[line--, collumn] = valuetoinsert++;
            }

            ArrayNotPrintidSideSize = ArrayNotPrintidSideSize - 2; // по стороне с каждой стороны уже заполнены, их не недо заполнять.
            line++;
            // переход к незаполненным линиям вниз
            // (на первом круге заполнена первая строка, поэтому переходим для старта на вторую,
            // на втором круге заполнена вторая строка, поэтому переходим для старта на третью и т.д.)
            collumn++;
            //переход к незаполненым колонкам вправо
            // (на первом круге заполнена первый столбец, поэтому переходим для старта на второй,
            // на втором круге заполнена второй столбец, поэтому переходим для старта на третий и т.д.)
        }
    }
    Console.WriteLine();
}


if (insertOfOneNumber(out  rows, " строк/столбцов") 
    && insertOfOneNumber(out int startnum, " с которого надо начинать массив"))
{
    int[,] arr = new int[rows, rows];
    SpesialArrayFilling(arr, startnum);
    Show2DArray(arr);
}



Console.ReadKey();
Console.Clear();