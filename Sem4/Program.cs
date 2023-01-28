// 24.На пишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А

Console.Clear();
/*
Console.Write("Введите чтсло: ");
int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");

int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= n; i++) //i = i + 1 // i += 1
    {
        sum += i; // sum = sum + 1
    }

    return sum;

}
*/
/************Это вариант если от 0 
Console.Write("Введите чтсло: ");
int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");

int GetSum(int A)
{
    int sum = 0;
    if (A > 1)
    {
        for (int i = 1; i <= n; i++) //i = i + 1 // i += 1
        {
            sum += i; // sum = sum + 1
        }
    }
    return sum;

}
*/
/*
Console.Write("Введите чтсло: ");
int n = int.Parse(Console.ReadLine()!);
int sum = GetSum(n);
Console.WriteLine($"{sum}");

int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= n; i++) //i = i + 1 // i += 1
    {
        sum += i; // sum = sum + 1
    }

    return sum;

}
*/
/*
Задача 26 Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
456 > 3
78 > 2
89126 > 5
*/
/*
void main()
{
    Console.Clear();
    Console.Write("Введите число : ");
    int num = int.Parse(Console.ReadLine()!);
    Console.WriteLine(result(num));
}
int result(int number)
{
    if(number < 0) number *= -1; // это строка делает из отрецательного положительное
    int count = 0;
    while(number > 0)
    {
        number /=10;
        count++;
    }
    return count;
}
main();
*/

/*
Задача 28 Напишите программу, которая принимает на входе число N и выдает произведение чисел 1 до N 
4 -> 24
5 -> 150
*/
/*
int Mult(int arg)
{
    int x =1;
    for (int i = 1; i <= arg; i++)
    {
        x *= i;
    }
    return x;
}
Console.Write("Введите чтсло: ");
int a = int.Parse(Console.ReadLine()!);
int total = Mult(a);
Console.WriteLine($"{total}");
*/

//Задача 30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке. 
//[1,0,1,1,0,1,0,0]

//Console.Write("Введите чтсло: ");
/*
void printArray(int[] array)
{
    string outArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        outArray += array[i];
        if (i != array.Length - 1) outArray += ", ";
    }
    Console.WriteLine(outArray);
}
int[] getArray()
{
    int[] intArray = new int [8];
    
    for (int i = 0; i < intArray.Length; i++)
    {
        int randInd = new Random().Next(0,2);
        intArray[i] = randInd;
    }
    return intArray;
}
void main()
{
    int[] array = getArray();
    printArray (array);
}
main();
*/
// Втарой вариант решение этой задачи
/*
void printArray(int[] array)
{
    string outArray = "";
    for (int i = 0; i < array.Length; i++)
    {
        outArray += array[i];
        if (i != array.Length - 1) outArray += ", ";
    }
    Console.WriteLine(outArray);
}
int[] getArray()
{
    int[] intArray = new int [8];
    
    for (int i = 0; i < intArray.Length; i++)
    {
        int randInd = new Random().Next(0,2);
        intArray[i] = randInd;
    }
    return intArray;
}
void main()
{
    int[] array = getArray();
    Console.WriteLine(String.Join(", ", array));//Меняем одну строчку
}
main();

*/

    
