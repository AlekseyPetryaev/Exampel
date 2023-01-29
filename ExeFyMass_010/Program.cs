﻿// Имеется одномерный массив array из (n) элементов, требуется найти элемент массива, равный Find
// 1) Установить счетчик index в позицию 0
// 2) Если [index] = find, алгоритм завершил работу успешнл.
// 3) Увеличить index на 1
// 4) Если index < n, то перейти к шагу 
//          2.В противном случае алгоритм завершил работу безуспешно.
// Пишем решение для любого каличества элементов
Console.Clear();
/*
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18,};

int n = array.Length; // Задаем на всю длину = n
int find = 4; // указываем номер каторый надо найти 

int index = 0; // задаем начало счетчику 

while (index < n) //проверяем если индекс < n
{
    if(array[index] == find) // если какое то число из массива равняется find 
    { // тогда 
        Console.WriteLine($"Вывод:{index}");// Выводим индекс этого сисла 
    } // если не ищем дальше
    index++;
}   
Ответ: 3 
*/
/*
//Если есть одинаковые тогда тоже выводим их 
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18,};

int n = array.Length; // Задаем на всю длину = n
int find = 4; // указываем номер каторый надо найти 

int index = 0; // задаем начало счетчику 

while (index < n) //проверяем если индекс < n
{
    if(array[index] == find) // если какое то число из массива равняется find 
    { // тогда 
        Console.WriteLine($"Вывод:{index}");// Выводим индекс этого сисла 
    } // если не ищем дальше
    index++;
}   
//Вывод:3
//Вывод:7
*/
/*
// Если надо только первое савподение, тогда надо добавить (break)
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18,};
int n = array.Length; 
int find = 4; 
int index = 0;  
while (index < n) 
{
    if(array[index] == find) 
    {  
        Console.WriteLine($"Вывод:{index}");
        break;
    } 
    index++;
}   
//Вывод:3
*/
//  два метода в первом заполняем случайными числами вовтором выводим их на экран
//Переписываем этот код с использоаванием псевдо слючайных числами и с использованием методов
// 1) взять метод передать в него массив
// 2) заполнить массив нужными элементами
// 3) выводить все элементы попорядку
/*
void FillArray(int[] collection) //даем название методу FillaAray(будет приниматься аргумент по названию коллекция)                              
{
    int length = collection.Length;//получаем длину массива(количество элементов) и присваемаем название lenght
    int index = 0; //задаем счетчик с нуля(по индексу)
    while (index < length) // пока индекс меньше масива 
    { // будем делать 
        collection[index] = new Random().Next(1, 10);//Заполняем колецию = новыми числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)//метод с название PrintArray который будет выводить(аргумент с нозванием Col) 
{
    int count = col.Length;//получаем длину массива(количество элементов) и присваемаем название count
    int position = 0;//задаем счетчик с нуля позиции 
    while (position < count) //будет прокручивать пока позиция будет меньше count
    { //будем делать 
        Console.Write($"{col[position]}, ");//Вывод:указываем название аргумента и его позицию 
        position++; // задаем +1 в по пазициям 
    }    
}
int[] array = new int[10]; //называем массив (array) в котором будет 10 элементов
FillArray(array); //заполнил массив
PrintArray(array); // вывод на экран массива
Console.WriteLine(" ");
*/

//Добавляем к верхней решннию. Нахождение нужного нам элемента в масиве через метод

void FillArray(int[] collection) //даем название методу FillaAray(будет приниматься аргумент по названию коллекция)                              
{
    int length = collection.Length;//получаем длину массива(количество элементов) и присваемаем название lenght
    int index = 0; //задаем счетчик с нуля(по индексу)
    while (index < length) // пока индекс меньше масива 
    { // будем делать 
        collection[index] = new Random().Next(1, 10);//Заполняем колецию = новыми числами от 1 до 10
        index++;
    }
}

void PrintArray(int[] col)//метод с название PrintArray который будет выводить(аргумент с нозванием Col) 
{
    int count = col.Length;//получаем длину массива(количество элементов) и присваемаем название count
    int position = 0;//задаем счетчик с нуля позиции 
    while (position < count) //будет прокручивать пока позиция будет меньше count
    { //будем делать 
        Console.Write($"{col[position]}, ");//Вывод:указываем название аргумента и его позицию 
        position++; // задаем +1 в по пазициям 
    }    
}

int IndexOf(int[] collection, int find)// будет возврашать позицию индекса и 
//аргумента будет collection, и эллеиент find !!!!(по элементу из массива находим индекс)!!!
{
    int count = collection.Length; //получаем длину массива(количество элементов) и присваемаем название count
    int index = 0;//задаем счетчик с нуля index
    int position = -1;// сюда будет сохранять совподаюшие элементы из массива
    //указываем  -1 а не 0 .принято если нету совпадений тогда пишем -1 
    while(index < count) //  пока индекс меньше каунта
    { // делаем это
        if(collection[index] == find)// если коллекшен индекс совпал с файнд 
        { // делаем это
            position = index; // в позишен кладем наш индекс
            //break;  // если уберем будет показывать следующее совподени но не первое
        }
        index++;
    }
    return position; //возвращаем позыцию
}

int[] array = new int[10]; //называем массив (array) в котором будет 10 элементов

FillArray(array); //заполнил массив
//array[4] = 4; //принудительно можно подставить свое [укавываем индекс] = и цифру
//array[6] = 4; //принудительно можно подставить свое [укавываем индекс] = и цифру
PrintArray(array); // вывод на экран массива
Console.WriteLine(" ");
// создаем переменную пос = в каторую будет передоваться массив и в нем будет искатся наш элемент 4
int pos = IndexOf(array, 4);
//как отработает наш метод, будет выводить 
Console.WriteLine(pos);

//Ответ:
//2, 9, 6, 7, 6, 3, 9, 9, 5, 4,
//9
//Ответ если нет совподений тогда пишет -1
//8, 7, 5, 5, 1, 7, 8, 1, 9, 8,
//-1