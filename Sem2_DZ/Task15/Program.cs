/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine()!);
if(num <= 5 && num >=1)
{
    Console.WriteLine($"НЕT, не выходной {num} ");
}
else
{
    if(num >= 6 && num <= 7 )
    {
        Console.WriteLine($"ДА, Выходной {num} ");
    }
    else
    {
        if(num > 7) 
        {
        Console.WriteLine($"Такого дня недели нет!!! {num} ");
        } 
        else
        {
            if(num < 1) 
        Console.WriteLine($"Такого дня недели нет!!! {num} ");
        }
        
    }
}      
        





