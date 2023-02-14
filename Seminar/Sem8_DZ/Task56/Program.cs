/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/

Console.Clear();

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите чоличество сталбцов: ");
int colu = int.Parse(Console.ReadLine()!);

int[,] table = new int[line, colu];

void columax(int[,] array)
{
    int mincolu = 0;
    int minsumcolu = 0;
    int sumcolu = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        mincolu += table[0, i];
    }
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++) 
        {
            sumcolu += table[i, j];
        }
        if (sumcolu < mincolu)
        {
            mincolu = sumcolu;
            minsumcolu = i;
        }
        sumcolu = 0;
    }
    Console.Write($"C наименьшей суммой элементов строка: {minsumcolu + 1} ");
}

void randomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++ )
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine(" ");
    }
}

randomArray(table);
PrintArray(table);
Console.WriteLine("");
columax(table);
