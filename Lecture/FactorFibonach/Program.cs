// Факториалы
/*
double Factorial(int n) //int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if( n == 1) return 1;
    else return  n * Factorial(n - 1);
}
*/
//Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6
//Ответ: 6
//вариант 2
/*
double Factorial(int n) //int Factorial (int n)
{
    if( n == 1) return 1;
    else return  n * Factorial(n - 1);
}
for(int i = 0; i < 5; i++)
{                // номерация    //подсчет
    Console.WriteLine($"{i}! = {Factorial(i)}"); // 
}
*/
//числа Фибоначи
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else Fibonacci(n - 1) + Fibonacci(n - 2);
}
