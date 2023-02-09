/*
Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5    7     -2    -0,2
1    -3,3     8    -9,9
8     7,8   -7,1    9
*/
Console.Clear();

Console.Write("Введите количество строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int colu = int.Parse(Console.ReadLine()!);
double[,] matrix = new double[line, colu];

void RandArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-50, 50)/ 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

RandArray(matrix);
PrintArray(matrix);

