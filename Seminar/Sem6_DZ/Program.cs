/*Задача 41 Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел Пользователь.
0, 7, 8, -2, -2, -> 2
1, -7, 567, 89, 223, -> 3*/

Console.Clear();
/*
int[] ReadArray(int Length, int min, int max) 
{
    int[] array = new int[Length];
    for(int i = 0; i < Length ; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }   
    return array;   
}

int PrintArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {       
        if(array[i] > 0 ) count ++;
    }   
    return count;
}

int[] array = ReadArray(7, -1000, 1000 );
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");
*/

/*Задача 43 Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями 
У = к1*х+b1,y=k2*x+b2; Значения b1,k1,b2, и k2 задаються пользователем. 
b1 = 2,k1 = 5,k2 = 4, k2 = 9 -> (-0,5; -0,5)*/

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

Console.WriteLine($"две прямые пересекутся в точке S координатами X: {x}, Y: {y}");