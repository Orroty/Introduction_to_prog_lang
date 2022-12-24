//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2

//1, -7, 567, 89, 223-> 3

bool insertOfOneNumberOrExit(ref int number, int counter) //ввод числ или выход
{
    Console.WriteLine($"Введите {counter} число для добавления или X для выхода из заполнения массива");
    string buff = Console.ReadLine();
    if (buff.ToLower().Equals("x")) //для выхода
    {
        
        return false;
    }
    else
    {
        if (Int32.TryParse(buff, out number))
        {
            return true;
        }
        else //если ввел букву
        {
            Console.WriteLine("Ввод не является числом. Для выхода нажмите любую клавишу");
            Console.ReadKey();
            return false;
        }
    }
}

void PosNumbers(int[] array)// подсчет положительных чисел в массиве
{
    int result = 0;
    foreach(int i in array)
    {
        if (i > 0) { result++; }
    }
    Console.WriteLine($"Положительных чисел в массиве - > {result}");
}

void ShowArray(int[] array) //печатаем массив
{
    foreach (int i in array) { Console.Write(" | " + i); }
    Console.WriteLine(" |");
}

void ShoWConsole(int[] arr) // отчистка массива, вывод массива, вывод количества введеных положительных чисел
{
    Console.Clear();
    Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("введеный до этого массив");
    ShowArray(arr);
    PosNumbers(arr);
}

void MassFill(int[] arr) // заполняем массив
{
    int Number = 0;
    int counter = 0;
    while (true) //бесконечный цикл с выходом по нажатию на клавишу X
    {
        ShoWConsole(arr);
        if (insertOfOneNumberOrExit(ref Number, counter+1))
        {

            if (counter == arr.Length) // изменяем размер массива
            {
                Array.Resize(ref arr, arr.Length + 1);
            }

            arr[counter] = Number;
            counter++;
        }
        else
        {
            break;
        }
    }
}




int[] array = new int[2];
MassFill(array);

ShoWConsole(array);

Console.ReadKey();
Console.Clear();

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


bool insertOfOneNumber(out int number, string name) //ввод чисел
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


double[] GetXYOfTheCross(int b1, int k1,int b2,int k2)
{
    double[] xy = new double[2];
    xy[0] = ((b2 - b1) * 1.0) / ((k1 - k2) * 1.0);
    xy[1] = (k1 * xy[0]) + b1;
    return xy;
}

Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");

if(insertOfOneNumber(out int b1, "b1") && insertOfOneNumber(out int k1, "k1") && insertOfOneNumber(out int b2, "b2") && insertOfOneNumber(out int k2, "k2"))
{
    var arr = GetXYOfTheCross(b1,k1, b2, k2);
    Console.WriteLine($"Прямые пересекаются в точке [{arr[0]};{arr[1]}]");
}

Console.ReadKey();
Console.Clear();