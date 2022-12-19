

int firstNumber1;

//функция ввода

bool insertOfOneNumber(out int number)
{
    Console.WriteLine("Введите число");

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


//функция ввода 2
bool insertOftextNumber2(out string number)
{
    Console.WriteLine("Введите число");
    number = Console.ReadLine();

    int number2;
    if (Int32.TryParse(number, out number2))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Ввод не является числом");
        return false;
    }
}


Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

//456 -> 5
//782 -> 8
//918 -> 1



//  функция 1

int secondСharacterOfNumber(int Number)
{
    return (Number / 10) % 10;
}



//  тело программы

if (insertOfOneNumber( out firstNumber1))
{
    if (firstNumber1 < 1000 && firstNumber1 > 99)
    {
        Console.WriteLine("Второй цифрой в " + firstNumber1 + " -> " + secondСharacterOfNumber(firstNumber1));
    }
    else
    {
        Console.WriteLine("Введеное число не является трехзначным");
    }
}



Console.ReadKey();

Console.Clear();
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 1");

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


//  функция 2

int thirdСharacterOfNumberFromBegining(int Number)
{
    if(Number < 100)
    {
        return -1;
    }
    else
    {
        while (Number > 999)
        {
            Number = Number / 10;
        }
        return Number % 10;
    }
}

//  тело программы

if (insertOfOneNumber(out firstNumber1))
{
    int temp;
    if ((temp = thirdСharacterOfNumberFromBegining(firstNumber1)) == -1)
    {
        Console.WriteLine("В числе " + firstNumber1 + " третьей цифры нет");
    }
    else
    {
        Console.WriteLine("В числе " + firstNumber1 + " третьей цифрой является " + temp);
    }
}

Console.ReadKey();

Console.Clear();

Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 2");

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6


//  функция 2

char thirdСharacterOftextFromBegining(string textNumber)
{
    int len = textNumber.Length;
    if (len < 3)
    {
        
        return 'a';
    }
    else
    {
        
        return textNumber[2];
    }
}

//  тело программы
string textNumber = "";

if (insertOftextNumber2(out textNumber))
{
    char temp2;
    if ((temp2 = thirdСharacterOftextFromBegining(textNumber)).Equals('a'))
    {
        Console.WriteLine("В числе " + textNumber + " третьей цифры нет");
    }
    else
    {
        Console.WriteLine("В числе " + textNumber + " третьей цифрой является " + temp2);
    }
}

Console.ReadKey();

Console.Clear();

Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");

//6 -> да
//7 -> да
//1 -> нет


//  функция 3

//      проверка на интервал 1 - 7
bool isInInterval(int numer,int begint, int endint)
{
    return numer >= begint && numer <= endint;
}

//      проверка на выходной
bool isADayOff(int numer)
{
    return isInInterval(numer,1,5);
}

//  тело программы

if (insertOfOneNumber(out firstNumber1))
{
    Console.WriteLine(firstNumber1 + (isInInterval(firstNumber1,1,7) ? ((isADayOff(firstNumber1) ? " не" : "") + " является выходным") : " не входит в интервал"));

}

Console.ReadKey();
