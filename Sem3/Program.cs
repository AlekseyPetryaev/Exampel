// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
Console.Clear();
/*
Console.Write("ВведитеX: ");
int x = int.Parse( Console.ReadLine()!);

Console.Write("ВведитеY: ");
int y = int.Parse( Console.ReadLine()!);

if (y > 0)
{
    if (x > 0)
    {
        Console.WriteLine("Первая четверть");
    }
    else
    {
        Console.WriteLine("Вторая четверть");
    }
}
else
{
    if (x > 0)
    {
        Console.WriteLine("Четвертая четверть");
    }
    else
    {
        Console.WriteLine("Третья четверть");
    }
}
*/

// Мы задаем чномер четверти, а программа нам пишет какой Х и У в даннной четверти
/*
Console.Write("Введите номер четверти: ");
int num = int.Parse( Console.ReadLine()!);

if(num == 1)
{    
    Console.WriteLine("В 1 четверти Х > 0 ");
    Console.WriteLine("В 1 четверти Y > 0 ");
}
else
{
    if(num == 2)
    {
        Console.WriteLine("Во 2 четверти -Х < 0 ");
        Console.WriteLine("Во 2 четверти  У > 0 ");
    }
    else
    {
        if(num == 3)
        {
            Console.WriteLine("В 3 четверти -Х < 0 ");
            Console.WriteLine("В 3 четверти -У < 0 ");
        }
        else
        {
            if(num == 4)
            {
                Console.WriteLine("В 4 четверти  Х > 0 ");
                Console.WriteLine("В 4 четверти -У < 0 ");
            }
            else
            {
                Console.WriteLine("Нету");
            }
        }
        
    }
}
*/

/*
Вариант 2 этой задачи 
*/
//Console.Write("Введите номер четверти: ");
//int num = int.Parse( Console.ReadLine()!);
/*
switch (num)
{
    case 1:
    {
        Console.WriteLine("В 1 четверти Х > 0 ");
        Console.WriteLine("В 1 четверти Y > 0 ");
        break;
    }
    case 2:
    {
        Console.WriteLine("Во 2 четверти -Х < 0 ");
        Console.WriteLine("Во 2 четверти  У > 0 ");
        break;
    }
    case 3:
    {
        Console.WriteLine("В 3 четверти -Х < 0 ");
        Console.WriteLine("В 3 четверти -У < 0 ");
        break;
    }
    case 4:
    {
        Console.WriteLine("В 4 четверти  Х > 0 ");
        Console.WriteLine("В 4 четверти -У < 0 ");
        break;
    }

    default:
    {
        Console.WriteLine("Введена неправельная четверть");
        break; 
    }
}
*/
/*
// d = v (x*A - x *B) 2 + (y*A - y*B) 2
// Math.Sqrt (); // находит квадратный корень числа
// Math.Pow(a,2); // возводит число в степень
// Math.Round(); // округляет число

Задача №21. Общее обсуждение
Напишите программу, которая принимает на входкоординаты двух точек и находит расстояние между
ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1, -1) -> 7,21
*/
/*
Console.Clear();

Console.Write("Введите координату X1: ");
int x1 = int.Parse( Console.ReadLine()!);
Console.Write("Введите координату Y1: ");
int y1 = int.Parse( Console.ReadLine()!);

Console.Write("Введите координату X2: ");
int x2 = int.Parse( Console.ReadLine()!);
Console.Write("Введите координату Y2: ");
int y2 = int.Parse( Console.ReadLine()!);

double result=Math.Sqrt((Math.Pow((x1-x2),2)+Math.Pow((y1-y2),2)));//d = v (x*A - x *B) 2 + (y*A - y*B) 2
//result=Math.Round(result,3); // или эту строчу пишим для округления или в следуюшей добавляем :f3
Console.WriteLine($"Расcтояние между заданными точками {result:f3}"); // или не дабавляем для округления
*/
//
/*
Задача №22. Работа в группах
Напишите программу, которая принимает на вход
число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4
*/
/*
Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse( Console.ReadLine()!);

int count=1;
while (count<=num)
{
    double result=Math.Pow(count,2);
    Console.Write($"{result},");
    
    count++;
}
*/
//Второй вариант
/*
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse( Console.ReadLine()!);

int count=1;
Console.Write($"{Math.Pow(count,2)}"); 
count++;
while (count<=num)
{
    Console.Write($", {Math.Pow(count++,2)} ");
}
*/
//Вариант 3

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse( Console.ReadLine()!);
int count=1;
while (count<=num)
{
    Console.Write($"{Math.Pow(count,2)} ");
    if (count!=num) Console.Write(", ");
    count++;
}
