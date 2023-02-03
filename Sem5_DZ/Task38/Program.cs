/* Задача38 Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементом массива*/

Console.Clear();

double[] ReadArray(int Length, int min, int max) 
{
    double[] array = new double[Length];
    for(int i = 0; i < Length ; i++)
    {
        array[i] = new Random().Next(min, max );
    }   
    return array;   
}

void DiffArray(double[] array)
{
    double min = array[0],max = array[0],Diff = 0;
    for(int i = 1; i < array.Length; i++)
    {       
        if(array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }   
    Diff = max - min;
    Console.WriteLine($"Элемент массива max {max} - Элемент массива min {min} = Разница {Diff}");
}

double[] random = ReadArray(15, 1, 20);
Console.WriteLine(string.Join(" ", random));
DiffArray(random);





