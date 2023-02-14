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

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка*/


/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

//Вариант 1
/*
Console.Write("Введите кол-во строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colu = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[line, colu];

void randomArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(01, 15);
        }
    }
}

void FillArraySpiral(int[,] array ,int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArray(int[, ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i, j] < 10)
            {
                Console.Write("0" + inArray[i, j]);
                Console.Write(" ");
            }
            else
            {
                Console.Write($"{inArray[i, j]} ");
            } 
        }
        Console.WriteLine("  ");
    }
}

void main()
{
    randomArray(matrix);
    PrintArray(matrix);
    FillArraySpiral(matrix);
}    

main();
*/
/*
//Вариант 2
int num = 4;
int[,] matrix = new int[num, num];
FillArraySpiral(matrix, num);
PrintArray(matrix);

void FillArraySpiral(int[,] array ,int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}
void PrintArray(int[, ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(inArray[i, j] < 10)
            {
                Console.Write("0" + inArray[i, j]);
                Console.Write(" ");
            }
            else
            {
                Console.Write($"{inArray[i, j]} ");
            } 
        }
        Console.WriteLine("  ");
    }
}
*/

/*Задача со звездочкой:
Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
4 -> 2
28 -> 5

Нельзя использовать встроенные функции библиотеки Math!*/