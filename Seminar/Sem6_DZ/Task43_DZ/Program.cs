/*Задача 43 Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
У = к1*х+b1,y=k2*x+b2; Значения b1,k1,b2, и k2 задаються пользователем. 
b1 = 2,k1 = 5,b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();

Console.Write("введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void Intersection() 
{ 
    double x = 0; 
    double y = 0; 
     
    if ((k1 == k2) && (b1 != b2)) 
    {
        Console.WriteLine(" "); 
    }
    else if ((k1 == k2) && (b1 == b2)) 
    {
        Console.WriteLine(" "); 
    }
    else 
    { 
        x =(-b2 + b1)/(-k1 + k2);
        y = k2 * x + b2; 
        Console.WriteLine($"Точка пересечения двух прямых -> (X: {x}; Y: {y})"); 
    } 
} 
 
Intersection();



