/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Введите число 1): "); //в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами 
if(numberA == numberB)
{
    Console.WriteLine($"Введите другие числа, эти равны!!!");
}
else
{
    Console.Write("Введите число 3): "); //в терминале напишет то что ("........:  ");
    //если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
    int numberС = int.Parse(Console.ReadLine()!); // работаем с цифрами
    if((numberС == numberA)&&(numberС == numberB))
    {
        Console.WriteLine($"Введите другие числа, эти равны!!!"); 
    }
    else
    {
        if((numberA>numberB)&&(numberA>numberС))
        {
            Console.WriteLine($"Максимальное число {numberA}");
        }
        else
        {
            if(numberB>numberС)
            {
                Console.WriteLine($"Максимальное число {numberB}");
            }
            else
            {
                Console.WriteLine($"Максимальное число {numberС}");
            }
        }
    }
}

*/

Console.Write("Введите число 1): "); //в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 3): "); //в терминале напишет то что ("........:  ");
//если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberС = int.Parse(Console.ReadLine()!); // работаем с цифрами
if((numberA == numberB)&&(numberB == numberС))
{
    Console.WriteLine($"Все числа равны!!!");
}
else
{ 
    if((numberA>numberB)&&(numberA>numberС))
    {
        Console.WriteLine($"Максимальное число {numberA}");
    }
    else
    {
        if(numberB>numberС)
        {
            Console.WriteLine($"Максимальное число {numberB}");
        }
        else
        {
            Console.WriteLine($"Максимальное число {numberС}");
        }
    }
}
