// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();

int[] array = ReadArray();
PrintArray(array);
int[] ReadArray()
{
    int[] result = new int[8];
    int index = 0;
    while(index < 8)
    {
        Console.Write("Введите элемент: ");
        result[index] = int.Parse(Console.ReadLine()!);
        index++;
    }   
    return result;   
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    while(index < count)
    {       
        Console.Write($"{array[index]}, ");
        index++;
    }   
    Console.WriteLine();
    
}

