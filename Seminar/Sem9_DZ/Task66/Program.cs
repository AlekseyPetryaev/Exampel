//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 104
//M = 4; N = 8. ->    (5 + 6 + 7) = 18

Console.Clear();

Console.Write("Введите начальное число M:");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите начальное число N:");
int n = int.Parse(Console.ReadLine()!);
int t = m+1;
void GapNumberSum(int t, int n, int sum)
{
    if(t > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    else if (t == n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (t++);

    GapNumberSum(t, n, sum);
}

GapNumberSum(t, n, 0);

