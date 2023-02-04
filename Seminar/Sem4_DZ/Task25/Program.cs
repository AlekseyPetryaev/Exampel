// Задача 25: Напишите цикл, который принимает на вход два числа 
//(А и В) и возводит число А в натуральную степень В.
// Реализовать функцию возведения в степень самостоятельно!
// 3 , 5 -> 243(3 в 5)
// 2, 4 -> 16 
Console.Clear();
Console.Write("Введите число 1): ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень 2): ");
int numA = int.Parse(Console.ReadLine()!);
int num3 = num;
int Method1(int num, int numA)
{
    int num3 = num;
    for(int i = 1 ;i < numA;i++)
    {
        num *= num3;   
    }
    return num;
    //Console.Write($"{num} ");
}

int dop = Method1(num ,numA);
Console.Write($"Ответ: {dop}");
Console.WriteLine();

