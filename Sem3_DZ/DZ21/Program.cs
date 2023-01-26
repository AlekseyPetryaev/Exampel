/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

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
