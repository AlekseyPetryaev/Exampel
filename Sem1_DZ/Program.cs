//Домашнее задание 
/*
Урок 1. Знакомство с языком программирования С#
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
/*
Console.Write("Введите число 1): "); //в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами  

int max = numberA;
int min = numberB;

if( numberA > max ) max = numberA; //если А больше мах то будет мах 
if( numberA < min ) min = numberA; //если А меньше мин то будет мин 
if( numberB > max ) max = numberB; //если B больше мах то будет мах 
if( numberB < min ) min = numberB; //если А меньше мин то будет мин

Console.Write("max: "); //задаем информацию которая будет отображаться в терминале (".....: ")
Console.WriteLine(max); //будет выводить мах значение 
Console.Write("min: "); //задаем информацию которая будет отображаться в терминале (".....: ")
Console.WriteLine(min); //будет выводить мах значение
*/

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.Write("Введите число 1): "); //в терминале напишет то что ("........:  ");
int numberA = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 2): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberB = int.Parse(Console.ReadLine()!); // работаем с цифрами 
Console.Write("Введите число 3): "); //в терминале напишет то что ("........:  ");
// если надо перевести из строки в целочисленный тип то пишем это "int.Parse(Console.ReadLine()!);"
int numberС = int.Parse(Console.ReadLine()!); // работаем с цифрами 

int max = numberA;

if( numberA > max ) max = numberA; //если А больше мах то будет мах 
if( numberB > max ) max = numberB; //если B больше мах то будет мах 
if( numberС > max ) max = numberС; //если B больше мах то будет мах

Console.Write("максимальное из этих чисел: ");
Console.WriteLine(max);
*/





