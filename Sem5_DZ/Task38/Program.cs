/* Задача38 Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементом массива*/

double[] ReadArray(int Length, int min, int max) 
{
    int[] array = new int[5];
    for(int i = 0; i < 5; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }   
    return array;   
}

double PrintArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {       
        if(array[i] % 2 == 0) count ++;
    }   
    return count;
}

doblo[] array = ReadArray(4, 100, 999);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");



