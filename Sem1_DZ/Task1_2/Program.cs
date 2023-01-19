/*
//Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Введите число 1): ");//в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): ");//в терминале напишет то что ("........:  ");
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);" 
if (numberA==numberB )  //если А больше мах то будет мах
{
    Console.WriteLine("Введите другие числа, эти равны!!!");
}
else 
{
    if (numberA > numberB) //если А больше мах то будет мах
    {
        Console.WriteLine($"максимальное число {numberA}");
        Console.WriteLine($"минимальное число {numberB}");
    }
    else 
    {
        Console.WriteLine($"максимальное число {numberB}");
        Console.WriteLine($"минимальное число {numberA}");
    }
}
  
*/


























/*
Console.Write("Введите число 1): "); //в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами
if(numberA==numberB) //если числа равны
{
    Console.WriteLine("Числа равны");
}
else
{
    if( numberA > numberB ) //если А больше мах то будет мах 
    {
        Console.WriteLine($"Большее число {numberA}"); //задаем информацию которая будет отображаться в терминале (".....: ")
        Console.WriteLine($"Меньшее число {numberB}"); //будет выводить мах значение
    }
    else // если нет, тогла В больше мах то будет мах
    {
        Console.WriteLine($"Большее число {numberB}"); //задаем информацию которая будет отображаться в терминале (".....: ")
        Console.WriteLine($"Меньшее число {numberA}"); //будет выводить мах значение
    }

}
*/
