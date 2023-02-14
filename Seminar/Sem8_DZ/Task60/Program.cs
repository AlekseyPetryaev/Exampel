/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Clear();

Console.Write("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во сталбцов: ");
int colu = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во третьего: ");
int three = int.Parse(Console.ReadLine()!);

int[ , , ] matrix = new int[line, colu, three];

void randomArray(int[, , ] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int p = 0; p < array.GetLength(2); p++)
            {
                array[i, j, p] = new Random().Next(10, 100);
            }
        }
    }
}

void PrintArray(int[, , ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            for(int p = 0; p < inArray.GetLength(2); p++)
            {
                Console.Write($"{inArray[i, j, p]}({i},{j},{p})\t ");
            }
            Console.WriteLine(" ");
        }
    }
}

randomArray(matrix);
PrintArray(matrix);
