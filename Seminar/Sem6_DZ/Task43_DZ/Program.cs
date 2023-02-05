/*Задача 43 Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
У = к1*х+b1,y=k2*x+b2; Значения b1,k1,b2, и k2 задаються пользователем. 
b1 = 2,k1 = 5,k2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.Clear();


/*
Console.Write("Введите число k1:");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1:");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2:");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2:");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 -b2) / (k1 -k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(x, 3);

Console.WriteLine($"Пересечение в точке: ({x};{y})");
*/

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых, X: {x}, Y: {y}");

/*
double b1 = ReadConsole("Введите значение b1: "); 
double k1 = ReadConsole("Введите значение k1: "); 
double b2 = ReadConsole("Введите значение b2: "); 
double k2 = ReadConsole("Введите значение k2: "); 
 
void CalculationXY() //double abscissa, double ordinate 
{ 
    double x = 0; 
    double y = 0; 
     
    if ((k1 == k2) && (b1 != b2)) 
    { 
        Console.WriteLine("Прямые параллельны"); 
    } 
    else if ((k1 == k2) && (b1 == b2)) 
    { 
        Console.WriteLine("Прямые совпадают"); 
    } 
    else 
    { 
        x = (b2 - b1) / (k1 - k2); 
        y = (k1 * x) + b1; 
        Console.WriteLine($"Координаты точки пересечения прямых x = {x}, y = {y}"); 
    } 
} 
 
CalculationXY();
*/