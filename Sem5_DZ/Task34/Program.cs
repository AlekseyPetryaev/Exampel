/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();
/*
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
*/

int[] ThreeDigitNumber(int nums, int min, int max)

{
    int [] result = new int[nums];
    for(int i = 0; i < nums; i++)
    {
        result[i] = new Random().Next(min,max + 1);
    }
    return result;
}

void main()
{
    int[] even = ThreeDigitNumber(4, 100, 1000);
    Console.WriteLine(string.Join(" ", even));
    int evenNums = 0;
    foreach( int elem in even )
    {
        if(elem % 2 == 0 ) evenNums += 1;
        else evenNums += 0; 
    }
    Console.WriteLine($"Количество четных чисел в массиве = {evenNums}");
}

main();

