/*
//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.Write("Введите число 1): ");//в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): ");//в терминале напишет то что ("........:  ");
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);" 
if (numberA==numberB )  //если А больше мах то будет мах
{
    Console.WriteLine("Введите другие числа, эти равны!!!");
}
else 
{
    if (numberA > numberB) //если А больше мах то будет мах
    {
        Console.WriteLine($"максимальное число {numberA}");
        Console.WriteLine($"минимальное число {numberB}");
    }
    else 
    {
        Console.WriteLine($"максимальное число {numberB}");
        Console.WriteLine($"минимальное число {numberA}");
    }
}
  


