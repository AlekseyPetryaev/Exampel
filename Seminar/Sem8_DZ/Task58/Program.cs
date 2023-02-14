/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();

Console.Write("Введите кол-во строк матрицы 1): ");
int line1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во сталбцов матрицы 1): ");
int colu1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во строк матрицы 2): ");
int line2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во сталбцов матрицы 2): ");
int colu2 = int.Parse(Console.ReadLine()!);
int[,] matrix1 = new int[line1, colu1];
int[,] matrix2 = new int[line2, colu2];

void randArray1(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray1(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++ )
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(" ");
    }
    Console.WriteLine("Вторая Матрица :");
}

void randArray2(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray2(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++ )
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(" ");
    }
Console.WriteLine("Результирующая матрица будет: ");     
}

int[,] GetMatrix3(int[,] array, int[,] matrix) 
{
    int[,] matrix3 = new int[array.GetLength(0), matrix.GetLength(1)]; 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < matrix.GetLength(1); j++) 
        { 
            for (int x = 0; x < matrix.GetLength(0); x++) 
            { 
                matrix3[i, j] += array[i, x] * matrix[x, j]; 
            } 
        } 
    }
    return matrix3;
    
}    
    
void Printmatrix3(int[,] nArray) 
{ 
    for (int i = 0; i < nArray.GetLength(0); i++) 
    { 
        for (int j = 0; j < nArray.GetLength(1); j++) 
        { 
            Console.Write("{0} ", nArray[i, j]); 
        } 
        Console.WriteLine("");
    } 
}    

void Main() 
{ 
    Console.WriteLine("Первая Матрица :");
    randArray1(matrix1);
    PrintArray1(matrix1);
    randArray2(matrix2);
    PrintArray2(matrix2);
    if(matrix1.GetLength(0) != (matrix2.GetLength(1)))
    {
        Console.WriteLine("Произведение двух матриц не получится");
        return;
    }
    int[,] sum = GetMatrix3(matrix1, matrix2); 
    Printmatrix3(sum);
}   

Main();

