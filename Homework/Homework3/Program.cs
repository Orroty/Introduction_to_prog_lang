


//---------------------------------------------------------------------------------------------------------------------

//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да

Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

// Функция



// метод 1 - числа
void IsPolindrom1(string number)
{
    if (!Int32.TryParse(number, out var result))
    {
        Console.WriteLine($"Введенный текст {number} не является числом");
        return;
    }
    if (result < 10000 || result > 99999)
    {
        Console.WriteLine($"Введенное число {number} не является пятизначным");
        return;
    }
    if ((result%10)==(result/10000))
    {
        if((result/1000)%10 == (result % 100) / 10)
        {
            Console.WriteLine($"Число {result} является палиндромом");
            return;
        }
    }
    Console.WriteLine($"Число {number} не является палиндромом");

}


// тело программы 1


Console.WriteLine(" \n Метод  1".PadRight(30) + " Введите пятизначное число");
IsPolindrom1(Console.ReadLine());




// метод 2 - текст

void IsPolindrom2(string number)
{
    if(!Int32.TryParse(number, out var result))
    {
        Console.WriteLine($"Введенный текст {number} не является числом");
        return;
    }
    if (number.Length != 5)
    {
        Console.WriteLine($"Введенное число {number} не является пятизначным");
        return;
    }
    if (number[0].Equals(number[4]) && number[1].Equals(number[3]) )
    {
        Console.WriteLine($"Число {number} является палиндромом");
        return;
    }
  
    Console.WriteLine($"Число {number} не является палиндромом");
    
}

// тело программы 2

Console.WriteLine(" \n Метод  2".PadRight(30) + " Введите пятизначное число");
IsPolindrom2(Console.ReadLine());




// метод 3 - текст для любой длины (укажем 5 для задания, но можно произвольную)

void IsPolindrom3(string number, int stoplen = 5)  //указать пятизначное, или другое ограничение
{
    if (!Int32.TryParse(number, out var result))
    {
        Console.WriteLine($"Введенный текст {number} не является числом");
        return;
    }
    if (number.Length != stoplen)
    {
        Console.WriteLine($"Введенное число {number} не содержит {stoplen} знаков");
        return;
    }
    int b = number.Length;
    for(int i = 0; i <= b-1-i; i++)
    {
        if (!number[i].Equals(number[b-1-i])) 
        {
            Console.WriteLine($"Число {number} не является палиндромом");
            return;
        }
    }
    Console.WriteLine($"Число {number} является палиндромом");

}

// тело программы 3

Console.WriteLine(" \n Метод  3".PadRight(30) + " Введите пятизначное число");
IsPolindrom3(Console.ReadLine());
Console.WriteLine(" \n Метод  3".PadRight(30) + " Введите шестизначное число");
IsPolindrom3(Console.ReadLine(), 6);




Console.ReadKey();
Console.Clear();




//---------------------------------------------------------------------------------------------------------------------

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

// Функция



bool insertOfOneNumber(out double number, string name)// ввод чисел - координат
{
    Console.WriteLine($"Введите {name} число");

    if (Double.TryParse(Console.ReadLine(), out number))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Ввод не является числом");
        return false;
    }
}

void GetDist3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    Console.WriteLine("Растояние между точками (" + x1 + "," + y1 + "," + z1 + ") и (" + x2 + "," + y2 + "," + z2 + ")  \n" +
        "равно".PadRight(30) + Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 3));
}

// тело программы 


if (insertOfOneNumber(out double x1, "x1") && insertOfOneNumber(out double y1, "y1") && insertOfOneNumber(out double z1, "z1") && insertOfOneNumber(out double x2, "x2") && insertOfOneNumber(out double y2, "y2") && insertOfOneNumber(out double z2, "z2"))
{

    GetDist3D(x1, y1, z1, x2, y2, z2);
}




Console.ReadKey();
Console.Clear();




//---------------------------------------------------------------------------------------------------------------------

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");


// Функция

bool insertOfOneNumber2(out int number, string name) //ввод N
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


void Cube(int number, int start = 1) //start - начало возведение в куб (по умолчанию 1)
{
    if (number > start)
    {
        Console.Write("| ");
        for (int i = start; i <= number; i++)
        {
           
            Console.Write(((i + " - > " + Math.Pow(i, 3)).PadRight(15) + " | ").PadRight(5));
            if (Math.Abs(i % 5) == 0 && i!=number)
            {
                Console.Write("\n| ");
            }
        }
        Console.Write("\n");
    }
    else
    {
        Console.WriteLine($"Вы ввели неверное число (меньше {start})");
    }
}

// тело программы 

if (insertOfOneNumber2(out int quart, " N"))
{
    Cube(quart,1);
}


Console.ReadKey();