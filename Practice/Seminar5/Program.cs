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


void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    foreach (int i in array)
    {
        if (i > 0) sumPositive += i;
        else sumNegative += i;
    }
    Console.WriteLine($"Сумма положительных элементов - > {sumPositive} \nСумма отрицательных элементов - > {sumNegative} ");
}

if (insertOfOneNumber(out int leng, " размера массива") && insertOfOneNumber(out int min_a, " минимального размера массива") && insertOfOneNumber(out int max_a, " максимального размера массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    FindMinMaxSum(arr);
}




Console.ReadKey();
Console.Clear();

//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] ChangeEllement(int[] array)
{

    for (int i =0;i<array.Length;i++)
    {
        array[i] = -array[i];
    }
    return array;
}


if (insertOfOneNumber(out leng, " размера массива") && insertOfOneNumber(out min_a, " минимального размера массива") && insertOfOneNumber(out max_a, " максимального размера массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    arr = ChangeEllement(arr);
    ShowArray(arr);
}




Console.ReadKey();
Console.Clear();


//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

bool FindNumber(int[] arr, int num)
{
    foreach(int i in arr)
    {
        if (i == num)
        {
            return true;
        }
    }
    return false;

}

if (insertOfOneNumber(out leng, " размера массива") && insertOfOneNumber(out min_a, " минимального размера массива") && insertOfOneNumber(out max_a, " максимального размера массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    if(insertOfOneNumber(out int num, " проверки на наличие"))
    {
    Console.WriteLine(num + " " + (FindNumber(arr, num) ? " " : " не ") + "находиться в массиве");
    }

}

Console.ReadKey();
Console.Clear();




//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*


int NumberInInterval(int[] arr, int nummin, int mummax)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i >= nummin && i<= mummax)
        {
            count++;
        }
    }
    return count;

}

if (insertOfOneNumber(out leng, " размера массива") && insertOfOneNumber(out min_a, " минимального размера массива") && insertOfOneNumber(out max_a, " максимального размера массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    if (insertOfOneNumber(out int minotrnum, " минимума интервала") && (insertOfOneNumber(out int maxotrnum, " максимума интервала")))
    {

        Console.WriteLine($"Количество элементов в интервале [{minotrnum},{maxotrnum}] :" + NumberInInterval(arr, minotrnum,maxotrnum)) ;
    }

}

Console.ReadKey();



// Доп задача.Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
//второй и предпоследний и т.д. Результат запишите в новом массиве.

//[1 2 3 4 5] -> 5 8 3

//[6 7 3 6] -> 36 21

void NumberMulti(int[] arr)
{
    Console.WriteLine("Произведение пар  ----> ");

    for(int i = 0; i <= arr.Length - 1 - i;i++)
    {
        Console.Write(((i == arr.Length - 1 - i)? arr[i] : arr[i] * arr[arr.Length-1-i]) + " ");
    }
    Console.WriteLine("");

}


int[] NumberMulti2(int[] arr)
{
    Console.WriteLine("Произведение пар  ----> ");

    int[] arr1 = new int[((arr.Length % 2) == 0) ?( arr.Length / 2 ):(( arr.Length / 2) + 1)];

    for (int i = 0; i <= arr.Length - 1 - i; i++)
    {
        arr1[i] = (((i == arr.Length - 1 - i) ? arr[i] : arr[i] * arr[arr.Length - 1 - i])); //при нечете нет пары
    }
    return arr1;

}

if (insertOfOneNumber(out leng, " размера массива") && insertOfOneNumber(out min_a, " минимального размера массива") && insertOfOneNumber(out max_a, " максимального размера массива"))
{
    var arr = CreateRandomArray(leng, min_a, max_a);
    ShowArray(arr);
    NumberMulti(arr);
    Console.WriteLine();
    ShowArray(NumberMulti2(arr));

}

Console.ReadKey();
