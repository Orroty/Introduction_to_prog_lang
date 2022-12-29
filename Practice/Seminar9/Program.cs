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

void Swap(ref int x, ref int y)
{
    var t = x;
    x = y;
    y = t;
}
//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

//N = 5 -> "1, 2, 3, 4, 5"
//N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.");

void PrintNum(int num)
{
    if (num == 1)
    {
        Console.Write(num + " ");
    }
    else
    {
        PrintNum(num - 1);
        Console.Write(num + " ");
    }
}


if (insertOfOneNumber(out int num, "до ввода"))
{
    PrintNum(num);
}

Console.ReadKey();
Console.Clear();
//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

//453 -> 12
//45 -> 9


Console.WriteLine("Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.");

int FindSumm(int num)
{
    if (num/10 > 0)
    {
        return FindSumm(num / 10) + num % 10;
    }
    else
    {
        return num;
    }
}

if (insertOfOneNumber(out num, "для поиска суммы цифр"))
{
    Console.WriteLine("Сумма цифр --> " + FindSumm(num));
}

Console.ReadKey();
Console.Clear();



//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"
 
Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");


void PrintFromNumToNum(int num1, int num2)
{
    if(num1 > num2) Swap(ref num1, ref num2);

    if (num1 == num2)
    {
        Console.Write(num2 + " ");
    }
    else
    {
        PrintFromNumToNum(num1, num2 - 1);
        Console.Write(num2 + " ");
    }
}


if (insertOfOneNumber(out num, "как начало ввода")&& insertOfOneNumber(out int num2, "как конец ввода"))
{
    PrintFromNumToNum(num, num2);
}


Console.ReadKey();
Console.Clear();


//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.WriteLine("Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.");

int PowNumber(int number, int step)
{
    if (step == 1) return number;
    else return number * PowNumber(number, step - 1);
}

if (insertOfOneNumber(out num, "для возведения в степень") && insertOfOneNumber(out  num2, "степень для возведения"))
{
    Console.WriteLine($"Число {num} в степени {num2} степени --> " + PowNumber(num, num2));
}

Console.ReadKey();
Console.Clear();