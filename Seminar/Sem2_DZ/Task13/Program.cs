﻿/*Задача 13: Напишите программу, которая выводит третью цифру заданного
числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
645 -> 6
78 -> третьей цифры нет
32679 -> 6
*/
Console.Write("Ведите число: ");
int numA = int.Parse(Console.ReadLine()!);
if(numA < 100)
{
    Console.WriteLine("Третьей цифры нет!!! ");
}  
else
{
    int numD = numA / 100 % 10;
    Console.WriteLine($"Третья цифра заданного числа: {numD} ");
}






