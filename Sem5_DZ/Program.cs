/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//Console.Clear();

//1)Вариант задаем числа вручную

int[] ReadArray(int Length, int min, int max) 
{
    int[] array = new int[4];
    for(int i = 0; i < 4; i++)
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
        if(array[i] % 2 == 0) count ++;
    }   
    return count;
}

int[] array = ReadArray(4, 100, 999 );
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");



//2)Вариант числа рандомные
/*
int[] RandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for(int i = 0; i < Length ; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }   
    return array;   
}

int PrintArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {       
        if(array[i] % 2 == 0) count ++;
    }   
    return count;
}

int[] array = RandomArray(4, 100, 999);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");
*/

/*Задача 36 задайте одномерный массим, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях*/
//[3,7,23,12] -> 19
//[-4,-6,89,6] -> 0


/*
int[] RandomArray(int Length, int min, int max)
{
    int[] array = new int[Length];
    for(int i = 0; i < Length ; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }   
    return array;   
}

int PrintArray(int[] array)
{
    int num = 0;
    for(int i = 0; i < array.Length; i += 2) num += array[i];
    return num;
}

int[] array = RandomArray(5, -10, 100);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");
*/

