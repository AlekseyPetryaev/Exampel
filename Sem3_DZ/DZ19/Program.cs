// Урок 3. Базовые алгоритмы. Продолжение
/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int numA = num /1000;
int numB = num %10;
int numD = ((num /1000)%10); 
int numC = (num %100/10);  
if(numA == numB)
{
    Console.WriteLine($"Число не является палиндромом: {num}");
}    
else
{
    if(numD == numC)
    {   
        Console.WriteLine($"Число является палиндромом: {num}");
    }
    else
    {
        Console.WriteLine($"Число не является палиндромом: {num}");
    }           
}

