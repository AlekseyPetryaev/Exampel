
/*
//Фибоначи
F(n)= [n, n < 2 - ,база          ]
      [F(n - 2) + F(n - 1), n > 2]  

//Рекрусия
F(5):
F(5)= F(4) + F(3) = 5
F(4)= F(3) + F(2) = 3
F(3)= F(2) + F(1) = 2
F(2)= F(1) + F(0) = 1

F(1) = 1
F(0) = 0
*/
//Задача 63 Задайте значение N. Напишите программу, которая 
//выведет все натуральные числа в промежуток от 1 до N

//N = 5-> "1,2,3,4,5"
//N = 6-> "1,2,3,4,5,6"
/*
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

string PrintNumbers(int n)
{
    if(n == 1) 
    {
        return "1";
    }
    else
    {
        return PrintNumbers(n - 1) + $" {n}";
        // или так можно..return PrintNumbers(n - 1) + " " +n.ToString();
    }
    
}

Console.WriteLine(PrintNumbers(n));

// Втарой вариант без ввода числа с консоли
/*
string PrintNumbers(int n)
{
    if(n == 1) 
    {
        return "1";
    }
    else
    {
        return PrintNumbers(n - 1) + $" {n}";
    }
    
}

Console.WriteLine(PrintNumbers(8));
*/


// Задача 65 Задайте значение M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5; -> "1,2,3,4,5"
// M = 4; N = 8; -> "4,6,7,8"
/*
string PrintNumbers(int m, int n)
{
    if(n == m) 
    {
        return m.ToString();
    }
    else
    {
        return PrintNumbers(m, n - 1) + " " +n.ToString();
    }
}

Console.WriteLine(PrintNumbers(1 ,8));
*/

//Задача 67 Напишите программму, котороя будет принимать на вход число и возвращать сумму его цыфор.
// 453 -> 12
// 45 -> 9

int GetSum(int num)
{
    if(num == 0) return num;
    else return num % 10 + GetSum(num / 10);

}

Console.WriteLine(GetSum(100));

//Задача 69 Напишите программу которая принемает 2 числа (А , Б) и возводит А в число В

void main()
{
    Console.Write("Введите число : ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Введите степент : ");
    int m = int.Parse(Console.ReadLine()!);

    Console.WriteLine(Pow(n, m));
}

int Pow(int n, int m)
{
    if(m == 0) return 1;
    else
    {
        return n * Pow(n, m -1);
    }
}
 
main();