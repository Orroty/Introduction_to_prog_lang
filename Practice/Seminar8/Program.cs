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


// Задайте двумерный массив Напишите программу, которая меняет местами указанные строки

Console.WriteLine("Задайте двумерный массив Напишите программу, которая меняет местами указанные строки");

// смена переменных местами
void Swap(ref int x, ref int y)
{
    var t = x;
    x = y;
    y = t;
}

int[,] ChangeRows(int[,] array, int firstrow, int secondrow)
{
    if (firstrow < array.GetLength(0) && secondrow < array.GetLength(0))
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Swap(ref array[firstrow, i], ref array[secondrow, i]);
        }
    return array;
}


if (insertOfOneNumber(out int rows, " строк") && insertOfOneNumber(out int col, " столбцов") && insertOfOneNumber(out int min_a, " минимального значения массива") && insertOfOneNumber(out int max_a, " максимального значения массива") && insertOfOneNumber(out int firstMoveNumber, " первой из меняемых строк") && insertOfOneNumber(out int secondMoveNumber, " второй из меняемых строк"))
{

    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Console.WriteLine("\n До перемещения\n");
    Show2DArray(array);
    Console.WriteLine("\n После перемещения строки\n");
    ChangeRows(array, firstMoveNumber, secondMoveNumber);
    Show2DArray(array);
}


Console.ReadKey();
Console.Clear();

// Задайте двумерный массив Напишите программу, которая заменяет строки на столбцы, в случае если это невозможно программа должна вывести примеры для пользователя

Console.WriteLine("Задайте двумерный массив Напишите программу, которая заменяет строки на столбцы, в случае если это невозможно программа должна вывести примеры для пользователя");


int[,] RowsToColumns(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                Swap(ref array[i, j], ref array[j, i]);
            }
        }
    }

    return array;
}


if (insertOfOneNumber(out rows, " строк")
    && insertOfOneNumber(out col, " столбцов")
    && insertOfOneNumber(out min_a, " минимального значения массива")
    && insertOfOneNumber(out max_a, " максимального значения массива"))
{

    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Console.WriteLine("\n До поворота\n");
    Show2DArray(array);
    Console.WriteLine("\n После поворота массива\n");

    RowsToColumns(array);
    Show2DArray(array);
}

Console.ReadKey();
Console.Clear();


Console.WriteLine("Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент");

int[] MinValue(int[,] arr)
{
    int[] minCoordinates = new int[2];
    minCoordinates[0] = 0;
    minCoordinates[1] = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[minCoordinates[0], minCoordinates[1]] > arr[i, j])
            {
                minCoordinates[0] = i;
                minCoordinates[1] = j;
            }
        }

    return minCoordinates;

}

int[,] RemoveRowAndColumn(ref int[,] arr)
{
    var mincoord = MinValue(arr);

    int[,] temp = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int x = 0, y = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if (i == mincoord[0])
        {
            continue;
        }

        y = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == mincoord[1])
            {
                continue;
            }
            temp[x, y] = arr[i, j];
            y++;
        }
        x++;
    }
    arr = (int[,])temp.Clone();
    return arr;
}



if (insertOfOneNumber(out rows, " строк")
    && insertOfOneNumber(out col, " столбцов")
    && insertOfOneNumber(out min_a, " минимального значения массива")
    && insertOfOneNumber(out max_a, " максимального значения массива"))
{

    var array = Create2DRandomArray(rows, col, min_a, max_a);
    Console.WriteLine("\n До поворота\n");
    Show2DArray(array);
    Console.WriteLine("\n После поворота массива\n");

    RemoveRowAndColumn(ref array);
    Show2DArray(array);
}



Console.ReadKey();
Console.Clear();