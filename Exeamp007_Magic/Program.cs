// Рисунок по координатам 
Console.Clear(); // эта команда чистит терминал
//Console.SetCursorPosition(10, 4); //задаем страку и столбец
//Console.WriteLine("+"); // задаем символ
//1№ один из вариантов записи 

int xa = 1; //присваеваем координаты
int ya = 1; //присваеваем координаты
int xb = 1; //присваеваем координаты
int yb = 30; //присваеваем координаты
int xc = 70; //присваеваем координаты
int yc = 30; //присваеваем координаты

// 2№ вариант записи
//int xa = 10, ya = 1, 
//    xb = 1,  yb = 30, 
//    xc = 80, yc = 30;

Console.SetCursorPosition(xb, yb); //задаем_Переменные
Console.WriteLine("+"); //задаем символ

Console.SetCursorPosition(xb, yb); //задаем_Переменные
Console.WriteLine("+"); //задаем символ

Console.SetCursorPosition(xc, yc); //задаем_Переменные
Console.WriteLine("+"); //задаем_символ
/*
int x = xa, y = xb;

int count = 0; //счетчик 

while(count < 5) //указали сколько раз будет повтаряться

{   //гениратор случайных чисел
    int what = new Random().Next(0,3); // от 0 до 3 ( 0 1 2 )
    if(what == 0) //если число "what" ровно 0 
    {
        x = (x + xa) / 2; //тогда для Х это выражение 
        y = (y + ya) / 2; //тогда для У это выражение 
    }
    if(what == 1) //если число "what" ровно 1
    {
        x = (x + xb) / 2; //тогда для Х это выражение 
        y = (y + yb) / 2; //тогда для У это выражение 
    }
    if(what == 2) //если число "what" ровно 2
    {
        x = (x + xa) / 2; //тогда для Х это выражение 
        y = (y + ya) / 2; //тогда для У это выражение 
    }

    Console.SetCursorPosition(x, y); //задаем Переменные
    Console.WriteLine("+"); //задаем символ
    count = count +1; // or /count +=1 ; or /cuont++; если у нас будет постоянное увеличение на один раз
}
/*
int i=0;
 while (i < 10)
{
    i += 2;
    Console.Write (i);
}
*/