/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Clear();

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colu = int.Parse(Console.ReadLine()!);

int[,] table = new int[line, colu];

GetArray(table);
PrintArray0(table);
Decreasing(table);
Console.WriteLine("По убыванию элементы");    
PrintArray0(table);

void GetArray(int[,] array)
{
    for( int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Decreasing(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int x = 0; x < array.GetLength(1) -1; x++)
            {
                if(array[i, x] < array[i, x + 1])
                {
                    int temp = array[i, x + 1]; 
                    array[i, x + 1] = array[i, x];
                    array[i, x] = temp;
                }
            }
        }          
    }
}

void PrintArray0(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    } 
}


