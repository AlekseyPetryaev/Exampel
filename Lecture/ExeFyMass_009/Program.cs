// Урок 2 Лекция
// Нахождение максимального числа из 9 чисел 
// ВАРИАНТ 1 (класический стихийный подход)
Console.Clear();
/*
int a1 = 34;
int b1 = 45;
int c1 = 560;
int a2 = 67;
int b2 = 78;
int c2 = 89;
int a3 = 90;
int b3 = 12;
int c3 = 23;
int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;
if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;
if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;
Console.Write($"Максимальное из 9 :{max} ");
Console.WriteLine(" ");
*/
// Нахождение максимального числа из 9 чисел 
// ВАРИАНТ 2 (с помошью функций)
/*
int Max(int arg1, int arg2, int arg3)//задаём переменным имена
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // возвращаем 
}
int a1 = 34;
int b1 = 45;
int c1 = 560;
int a2 = 67;
int b2 = 78;
int c2 = 89;
int a3 = 90;
int b3 = 12;
int c3 = 23;
// 1 вариант
/*
int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1,max2,max3);
*/
// 2 вариант 
/*
int max = Max(Max(a1, b1, c1),Max(a2, b2, c2),Max(a3, b3, c3));
*/
// 3 вариант
/*
int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.Write($"Максимальное из 9 : {max} ");
Console.WriteLine(" ");
*/
/*
// Нахождение максимального числа из 9 чисел 
// ВАРИАНТ 3 (с помошью функций и массивы)
int Max(int arg1, int arg2, int arg3)//задаём переменным имена
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // возвращаем 
}
//В место этих строк указываем одну ниже
//              0  1  2   3  4  5  6  7  8
int[] array = {34,45,560,67,78,89,90,12,23};// вот эту !!
//array[0] = 12;// Это командой можно присвоить другое значение под индексом 0 
Console.WriteLine(array[4]); // можем указать что именно надо вывести 
//Ответ: 78
*/
// Нахождение максимального числа из 9 чисел 
// ВАРИАНТ 4 (с помошью функций и массивы)

int Max(int arg1, int arg2, int arg3) //задаём переменным имена
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // возвращаем 
}
//              0   1   2    3   4   5   6   7  8
int[] array = {34, 45, 560, 67, 78, 89, 90, 12, 23}; // вот эту !!
//прогоняем все числа с индаксами и на ходим макисум, и присваеваем название result
int result = Max( 
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine($"Max :{result}"); // выводим максимальное значение (result)
