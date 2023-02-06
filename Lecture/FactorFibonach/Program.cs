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
/*
int Fibonacci(int n) //F(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);//F(n - 1) + F(n - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}
*/
/*
Ответ:
1
1
2
3
5
8
13
21
34
*/
// тоже самое но через dubale
/*
double Fibonacci(int n) //F(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);//F(n - 1) + F(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine(Fibonacci(i));
}
*/
/*Ответ:
1
1
2
3
5
8
13
21
34
55
89
144
233
377
610
987
1597
2584
4181
6765
10946
17711
28657
46368
75025
121393
196418
317811
514229
832040
1346269
2178309
3524578
5702887
9227465
14930352
24157817
39088169
63245986
*/
/*
double Fibonacci(int n) //F(int n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);//F(n - 1) + F(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
*/
//Ответ: 
/*
f(1) = 1
f(2) = 1
f(3) = 2
f(4) = 3
f(5) = 5
f(6) = 8
f(7) = 13
f(8) = 21
f(9) = 34
f(10) = 55
f(11) = 89
f(12) = 144
f(13) = 233
f(14) = 377
f(15) = 610
f(16) = 987
f(17) = 1597
f(18) = 2584
f(19) = 4181
f(20) = 6765
f(21) = 10946
f(22) = 17711
f(23) = 28657
f(24) = 46368
f(25) = 75025
f(26) = 121393
f(27) = 196418
f(28) = 317811
f(29) = 514229
f(30) = 832040
f(31) = 1346269
f(32) = 2178309
f(33) = 3524578
f(34) = 5702887
f(35) = 9227465
f(36) = 14930352
f(37) = 24157817
f(38) = 39088169
f(39) = 63245986
f(40) = 102334155
f(41) = 165580141
f(42) = 267914296
f(43) = 433494437
f(44) = 701408733
f(45) = 1134903170
f(46) = 1836311903
f(47) = 2971215073
f(48) = 4807526976
f(49) = 7778742049
*/