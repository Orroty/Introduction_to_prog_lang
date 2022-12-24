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
    if(min_val > max_val)
    {
        int temp = min_val;
        min_val = max_val;
        max_val = temp;
    }
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

void ShowDoubleArray(double[] array)
{
    foreach (double i in array) { Console.Write(" | " + i); }
    Console.WriteLine(" |");
}

void swap(ref int firstN, ref int secondN)
{
    int temp = firstN;
    firstN = secondN;
    secondN = temp;
}
void swap2(ref double firstN, ref double secondN)
{
    double temp = firstN;
    firstN = secondN;
    secondN = temp;
}

//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

Console.WriteLine("Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)");

int[] SwapArray(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        swap(ref array[i], ref array[array.Length - 1 - i]);
        //int temp = array[i];
        //array[i] = array[array.Length-1-i];
        //array[array.Length - 1 - i] = temp;
    }
    return array;
}

if (insertOfOneNumber(out int leng, " размера массива") && insertOfOneNumber(out int min_a, " минимального значения массива") && insertOfOneNumber(out int max_a, " максимального значения массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    SwapArray(arr);
    Console.WriteLine();
    ShowArray(arr);
}

Console.ReadKey();
Console.Clear();

//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

Console.WriteLine("Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.Самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон\r\n");


bool CheckTriangle(int n1,int n2,int n3)
{
    if (n1 + n2 > n3 && n1 + n3 > n2 && n2 + n3 > n1)
    {
        return true;
    }
    return false;
}

if (insertOfOneNumber(out int s1, " размер первой стороны треугольника") && insertOfOneNumber(out int s2, " размер второй стороны треугольника") && insertOfOneNumber(out int s3, " размер третьей стороны треугольника"))
{
    Console.WriteLine($"Треугольник со сторонами размером [{s1},{s2},{s3}]" + (CheckTriangle(s1,s2,s3)?" ":" не ") + "существует");
}


Console.ReadKey();
Console.Clear();

//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
//[0, 1,2, 3, 5, 8, 13, ... ]

Console.WriteLine("Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.\r\n");

void FibFromNumber(double firstStarNumber = 0, double secondStartNumber = 1, int numberOfNumers = 5)
{

    if (firstStarNumber > secondStartNumber)
    {
        swap2(ref firstStarNumber, ref secondStartNumber);
    }
    Console.WriteLine($"Псевдофибоначи с чисел {firstStarNumber} и {secondStartNumber}:");

    Console.Write(firstStarNumber+" ," + secondStartNumber + " ,");
    for(int i = 2; i < numberOfNumers; i++)
    {
        double temp = firstStarNumber;
        firstStarNumber= secondStartNumber;
        secondStartNumber+= temp;
        if (i != numberOfNumers - 1)
        {
            Console.Write(secondStartNumber + " ,");
        }
        else
        {
            Console.Write(secondStartNumber);
        }
        if (i != 0 && i % 9 == 0)
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

double[] FibFromNumber2(double firstStarNumber = 0, double secondStartNumber = 1, int numberOfNumers = 5)
{
    if (firstStarNumber > secondStartNumber)
    {
        swap2(ref firstStarNumber, ref secondStartNumber);
    }

    double[] result = new double[numberOfNumers];
    result[0] = firstStarNumber;
    result[1] = secondStartNumber;


    for (int i = 2; i < numberOfNumers; i++)
    {
        result[i]= result[i-2]+result[i-1];
       
    }
    return result;
}

if (insertOfOneNumber(out  s1, " от которого считать последовательность номер 1") && insertOfOneNumber(out  s2, " от которого считать последовательность номер 2") && insertOfOneNumber(out  s3, " чисел, выводимых для последовательности Фибоначи"))
{
    FibFromNumber((double)s1, (double)s2, s3);
    Console.WriteLine();
    ShowDoubleArray(FibFromNumber2((double)s1, (double)s2, s3));
}

Console.ReadKey();
Console.Clear();

// Задача 4. * ***Напишите программу, которая будет преобразовывать десятичное число в двоичное.

//45 -> 101101
//3 -> 11
//2 -> 10

Console.WriteLine("Задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.\r\n");

string ToBinarFromNumber(int number)
{
    string result = "";
    for(int i = 0; number != 0; i++)
    {
        if (i != 0 && i % 4 == 0)
        {
            result = " " + result;
        }
        result = number%2 + result;
        number = number/2;

    }
    return result;
}
if (insertOfOneNumber(out s1, " для перевода в двоичное") )
{
    Console.WriteLine($"Число {s1} в двоичной форме - >" + ToBinarFromNumber(s1));
}
Console.ReadKey();
Console.Clear();
