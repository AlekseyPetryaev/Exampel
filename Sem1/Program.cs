// Коментарии

/*бабаб
бабаба
бабаб
*/

// Напишите программу, которая на 
/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
//Рушение математически
int num = number * number;
Console.WriteLine(num);
Console.WriteLine($"Квадрат числа {number} = {num}");
//Решение, через Библиотеку
int num2 = Convert.ToInt32(Math.Pow(number, 2));
Console.WriteLine($"Квадрат числа {number} = {num2}");
*/
/*  
Console.Write("Введите число: ");
int x = int.Parse(Console.ReadLine( ));
if (x ==1)
{
    Console.Write("Понедельник");
}
if (x ==2)
{
    Console.Write("Вторник");
}
if (x ==3)
{
    Console.Write("Среда");
}
if (x ==4)
{
    Console.Write("Четверг");
}
if (x ==5)
{
    Console.Write("Пятница");
}
if (x ==6)
{
    Console.Write("Суббота");
}
if (x ==7)
{
    Console.Write("Воскресение");
}

else if (x < 1 || x > 7)
{
    Console.WriteLine(" Такого нет ");
}
*/
/*
Console.WriteLine("Введите :");
int number = int.Parse(Console.ReadLine());
int count = -number;
while (count <= number) {
    Console.Write($"{count} ");
    count++; // count++повышает cout на 1
}
*/

Console.Write("Введите 3х значное число: ");
int num3 = int.Parse(Console.ReadLine());
int numX = num3 % 10;
Console.WriteLine(numX);

