//функция ввода



bool insertOfOneNumber(out int number, string name)
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


bool insertOfOneNumber11(ref double number, string name)
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











//Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Задание1.  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.");

// функция

int FindQuart(double x,double y)
{
    if (x > 0 && y > 0) 
    {
        return 1;
    }
    if (x < 0 && y > 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x > 0 && y < 0)
    {
        return 4;
    }

    return 0;
}

// тело программы 

double x =0;
double y =0;

if(insertOfOneNumber11(ref x,"x") && insertOfOneNumber11(ref  y, "y"))
{
    int result;
    if ( (result = FindQuart(x,y)) == 0)
    {
        Console.WriteLine($"Точка ({x},{y}) не должна иметь координаты (0,0)");
    }
    else
    {
        Console.WriteLine($"Точка ({x},{y}) находится в четверти {result}");

    }
}


Console.ReadKey();
Console.Clear();






//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).");

// функция

void FindCoordinats( int quart)
{
    if(quart == 1)
    {
        Console.WriteLine($"Диапозон кородинат {quart} четверти (x+,y+)") ;
    }
    if (quart == 2)
    {
        Console.WriteLine($"Диапозон кородинат {quart} четверти (x-,y+)");
    }
    if (quart == 3)
    {
        Console.WriteLine($"Диапозон кородинат {quart} четверти (x-,y-)");
    }
    if (quart == 4)
    {
        Console.WriteLine($"Диапозон кородинат {quart} четверти (x+,y-)");
    }
    if(quart<1 || quart > 4)
    {
        Console.WriteLine("Заданной четверти не существует");
    }
}

// тело программы 
int quart =0;
if (insertOfOneNumber(out quart, " четверти"))
{
    FindCoordinats(quart);
}

Console.ReadKey();
Console.Clear();







//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.");

// функция

void GetDist(double x1, double y1, double x2, double y2)
{
    Console.WriteLine("Растояние между точками (" + x1 + "," + y1 + ") и (" + x2 + "," + y2 + ") равна " + Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)),2) );
}

// тело программы 

double x2 =0;
double y2 =0;

if (insertOfOneNumber11(ref x, "x1") && insertOfOneNumber11(ref y, "y1") && insertOfOneNumber11(ref x2, "x2") && insertOfOneNumber11(ref y2, "y2"))
{
    
    GetDist(x,y,x2,y2);
}


Console.ReadKey();
Console.Clear();






//Задача 4.Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N
Console.WriteLine("Задача 4.Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N");



// функция
void Quad(int number)
{
    if (number > 1)
    {
        Console.Write("| ");
        for (int i = 1; i <= number; i++)
        {
            Console.Write(i + " - > " + Math.Pow(i, 2) + " | ");
            if (i % 10 == 0)
            {
                Console.Write("\n");
            }
        }
        Console.Write("\n");
    }
    else
    {
        Console.WriteLine("Вы ввели неверное число (отрицательное или 0)");
    }
}

// тело программы 

if (insertOfOneNumber(out quart, " N"))
{
    Quad(quart);
}

Console.ReadKey();
Console.Clear();


