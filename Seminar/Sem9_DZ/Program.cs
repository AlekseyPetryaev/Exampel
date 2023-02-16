﻿/*Урок 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

// Функция Аккермана без рекурсии
/*
Console.Write("Введите начальное число m : ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число n : ");
int n = int.Parse(Console.ReadLine()!);

int Akkerman = num(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int num(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return num(m - 1, 1);
    else return (num(m - 1, num(m, n - 1)));

}
*/

/*
Задача со звездочкой: Пользователь вводит скобочные последовательности. В последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность, составленная в алфавите, состоящем из символов, сгруппированных в упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная последовательность была введена
*/