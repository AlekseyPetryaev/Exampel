// Урок 3. Базовые алгоритмы. Продолжение
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int numA = num /1000;
int numB = num %10;
int numD = ((num /1000)%10); 
int numC = (num %100/10);  
if(numA == numB)
{
    Console.WriteLine($"Число не является палиндромом: {num}");
}    
else
{
    if(numD == numC)
    {   
        Console.WriteLine($"Число является палиндромом: {num}");
    }
    else
    {
        Console.WriteLine($"Число не является палиндромом: {num}");
    }           
}

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Console.Clear();
Console.Write("Введите координаты точеки X1: ");
int X1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точеки Y1: ");
int Y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точеки Z1: ");
int Z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точеки X2: ");
int X2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точеки Y2: ");
int Y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точеки Z2: ");
int Z2 = int.Parse(Console.ReadLine()!);
double X3 = Math.Pow(X1 - X2,2);
double Y3 = Math.Pow(Y1 - Y2,2);
double Z3 = Math.Pow(Z1 - Z2,2);
double num = Math.Sqrt(X3 + Y3 + Z3);
Console.WriteLine($"Расстояние между ними в 3D пространстве: {num:F2}");
*/

/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
Console.WriteLine("Hello, World!");
*/
/*
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse( Console.ReadLine()!);
int count=1;
while (count<=num)
{
    Console.Write($"{Math.Pow(count,3)} ");
    if (count!=num) Console.Write(", ");
    count++;
}
*/