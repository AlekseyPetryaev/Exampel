/* Задача 10: Напишите программу, которая принимает на вход трёхзначное 
число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int numberA = num % 100;
int numberB = numberA / 10;
Console.WriteLine($"Второе число из трех {numberB}"); 
