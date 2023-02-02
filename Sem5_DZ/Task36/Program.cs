/*Задача задайте одномерный массим, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечетных позициях
[3,7,23,12] -> 19
[-4,-6,89,6] -> 0*/

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

