/*Задача 53, Задайте двухмерный массив, Напишите программу которая поменяет
местами первую и последнюю строчку массива.*/

Console.Clear();
/*
int[,] GetrandomMatrix(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[ m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal);
        }
    }
    return result; 
}
// меняем последнию строчку с первой
void transMatrix(int[,] matrix)
{
    int temp;
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}
// вызываем функции
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetrandomMatrix( m: 4, n: 5, minVal: 1, maxVal: 10);
PrintArray(matrix);// выводим как есть 
transMatrix(matrix);// меняем местами строчки
Console.WriteLine(" ");// пустая строка
PrintArray(matrix);//выводим помененые строчки 
*/

// Задача 55: Задайте двухмерный массивб, Написите программу которая заменяет строки на столбцы, 
// в случае если это не возможно, программа должна вывести сообщение для пользователя

/*
int[,] TranspMatrix(int[,] matrix)
{   
    int lineCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);

    int[,] resultMatrix = new int[lineCount, colCount];

    for(int col = 0; col < matrix.GetLength(1); col++)
    {
        for(int line = 0; line < matrix.GetLength(0); line++)
        {
            resultMatrix[line, col] = matrix[col, line];
        }
    }
    return resultMatrix;
}

void PrintArray(int[,] arrayTo)
{
    Console.WriteLine();
    Console.WriteLine("Таблица значение:");
    for(int line = 0; line < arrayTo.GetLength(0); line ++)
    {
        for(int col = 0; col < arrayTo.GetLength(1); col ++)
        {
            Console.Write($"{arrayTo[line, col]} ");
        }
        Console.WriteLine();
    }     
}  

int[, ]  Getrandom(int line = 5, int col = 5,  int minVal = 0, int maxVal = 10)
{
    int[,] matrix = new int[line, col];
    Random randInt = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = randInt.Next(minVal, maxVal + 1);
        }
    }
    return matrix;
}

void Main()
{
    int[,] matrix = Getrandom();
    PrintArray(matrix);
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        Console.WriteLine("Не получится");
        return;
    }
    int[,] transpMatrix = TranspMatrix(matrix);
    PrintArray(transpMatrix);
}

Main();
*/

// Задача 58: Составте частотный словарь двухмерного массива. Напишите Программу, 
// частотный словарь содержит информацию о том сколько развстречается элемент входных данных.
/*
Console.Write("Введите кол-ко строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colu = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[line, colu];

void randomArray(int[, ] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 9);
        }
    }
}

int[] MatrixAToArray(int[,] matrix)
{
    int count = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

void SortArray(int[] array)
{
    int temp; 
    for(int i = 0; i < array.Length -1; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void PrintArray(int[, ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

void CountElemets(int[] array)
{
    int num = 1;
    for(int i = 0; i < array.Length-1; i++)
    {
        if(array[i] != array[i+1])
        {
            Console.WriteLine($"элемент {array[i]} встретился {num} раз");
            num = 1;
        }
        else num++;
    }
    Console.WriteLine($"элемент {array[array.Length -1]} встретился {num} раз");

}

randomArray(matrix);
PrintArray(matrix);
Console.WriteLine("Переводим двух мерный массив в страку");
int[] array = MatrixAToArray(matrix);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Числа повозрастанию");
SortArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine("Сколько раз встречается число");
CountElemets(array);
*/

// Задача 58: Вариант 2) Составте частотный словарь двухмерного массива. Напишите Программу, 
// частотный словарь содержит информацию о том сколько развстречается элемент входных данных.
/*
Console.Write("Введите кол-ко строк: ");
int line = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int colu = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[line, colu];

void randomArray(int[, ] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j <array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
        }
    }
}

void PrintArray(int[, ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

void PrintArray1(int[, ] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++ )
        {
            Console.Write($"{inArray[i, j]} ");
        }
        //Console.WriteLine(" ");
    }
}

randomArray(matrix);
PrintArray(matrix);
Console.WriteLine(" ");
PrintArray1(matrix);
*/

//Задача 59: Задайте двухмерный массыв из целых чисел. Напишите программу, 
//которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// 5 2 6 7 
//Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

int[, ] GetArray(int m, int n, int minVal, int maxVal)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minVal, maxVal +1);
        }
    }
    return result;
}

void PrintArra(int[,] array)
{
    for(int i = 0; i < array.GetLength; i++)
    {
        for(int j = 0; j < array.GetLength; j++)
        {
            Console.Write("array[i, j] = 
        }
    }
}