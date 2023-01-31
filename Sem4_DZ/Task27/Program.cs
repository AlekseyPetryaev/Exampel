// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10

Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine()!);
int sum = 0;
int number = 0;
int Met(string[] args)
{   
    while (num > 0)
    {
        number = num % 10;
        sum = sum + number;
        num = num /10;
    }
    return sum;
    //Console.Write($"{sum} ");
}

int dop = Met(args);
Console.WriteLine($"Ответ: {dop}");
Console.WriteLine("");



