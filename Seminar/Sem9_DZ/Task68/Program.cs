// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

int AckFunc(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return AckFunc(M - 1, 1);
    if (M > 0 && N > 0) return AckFunc(M - 1, AckFunc(M, N - 1));
return AckFunc(M, N);
}

Console.WriteLine($"функции Аккермана для чисел A({M},{N}) = {AckFunc(M, N)}");
