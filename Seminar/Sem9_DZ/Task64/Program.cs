//Задача 64: Задайте значение N. Напишите программу, которая выведет все
//натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();

void PrintNumbers(int n, int num)
{
    if(num > n) 
    {
        return;
    }
    else
    {
        PrintNumbers(n, num +1);
        Console.Write(num + " ");
    }   
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int num = 1;
PrintNumbers(n, num);
