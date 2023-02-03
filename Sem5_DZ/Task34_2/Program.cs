/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();

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
    Console.WriteLine($"Кол-во четных чисел в массиве = {evenNums}");
}

main();
