/*Задача 41 Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел Пользователь.
0, 7, 8, -2, -2, -> 2
1, -7, 567, 89, 223, -> 3*/

Console.Clear();

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
    int count = 0;///////////////////////////////////////////////////////////////
    for(int i = 0; i < array.Length; i++)
    {       
        if(array[i] > 0 ) count ++;
    }   
    return count;
}

int[] array = ReadArray(7, -1000, 1000 );
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");

///Начало 2

