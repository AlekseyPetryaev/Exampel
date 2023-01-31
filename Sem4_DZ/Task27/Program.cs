// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10

Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
int number = 0;
void Met(string[] args)
{   
    while (num > 0)
    {
        number = num % 10;
        sum = sum + number;
        num = num /10;
    }
    Console.Write($"{sum} ");
}
Met(args);
Console.WriteLine("");



