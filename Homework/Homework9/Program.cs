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
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");

// Рекурсивно в строку добавляет следующее значение, пока оно не станет равно финальному. 

string RecursNumbersInIntervalToString(int begin, int end)
{
    if (begin == end)
    {
        return begin + "";
    }
    else
    {
        return begin + ", " + RecursNumbersInIntervalToString((begin < end) ? (begin + 1) : (begin - 1), end);
    }
}

// Запуск создания строки последовательности и печать.
void StartAndPrintRecursNumInterval(int begin, int end = 1)
{
    Console.WriteLine($"\nИнтервал в промежутке [{begin},{end}]");
    Console.WriteLine(RecursNumbersInIntervalToString(begin, end));
}

if (insertOfOneNumber(out int startN, "N с которого должен начаться вывод") && insertOfOneNumber(out int finN, " до которого должно выводиться значение"))
{
    StartAndPrintRecursNumInterval(startN, finN);
}


Console.ReadKey();
Console.Clear();

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");


int RecursNumSum(int M, int N)
{
    if (M < 0) M = 0;                                // Если M меньше 0, то меняем её значение на 0, и считаем сумму чисел от 0 до N;
    if (N < 0) N = 0;                                // Если N меньше 0, то меняем её значение на 0, и считаем сумму чисел от 0 до M;
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю (если оба будут равны нулю, то тут выкинет с ответом 0)
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + RecursNumSum(M, N - 1); // Если M<N
    else return N + RecursNumSum(M, N + 1);            // Если M>N
}

if (insertOfOneNumber(out int mNum, "M - начало для суммирования") && insertOfOneNumber(out int nNum, "N - конец суммирования"))
{

    Console.WriteLine($"\n Сумма натуральных элементов в промежутке [{mNum},{nNum}] равно --> " + RecursNumSum(mNum, nNum));
}

Console.ReadKey();
Console.Clear();


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");


double AkkerMan(double m, double n)
{
    for (; m != 0; m--)
    {
        n = (n == 0) ? 1 : (AkkerMan(m, n - 1));
    }
    return n + 1;
}

if (insertOfOneNumber(out int mAkkerman, "m для функции Аккермана") && insertOfOneNumber(out int nAkkerman, "n для функции Аккермана"))
{

    Console.WriteLine($"\n Функция Аккурмана A({mAkkerman},{nAkkerman}) равно --> " + AkkerMan(mAkkerman * 1.0, nAkkerman * 1.0));
}

Console.ReadKey();
Console.Clear();