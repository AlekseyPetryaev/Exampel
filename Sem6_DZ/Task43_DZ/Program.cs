/*Задача 43 Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
У = к1*х+b1,y=k2*x+b2; Значения b1,k1,b2, и k2 задаються пользователем. 
b1 = 2,k1 = 5,k2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Write("Введите число k1:");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1:");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2:");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2:");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 -b2) / (k1 -k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(x, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y}})")