﻿//Приглошение к вводу 
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine()!;
//Если имя Кристина
//if(username.ToLower() == "Кристина") // как бы мы не записали слова с большой или с маленькой буквы будут
//                                            отоброжаться как мы задали 
if(username == "Кристина") // если это имя 
{
    Console.WriteLine("Люблю тебя"); //при совподении заданного имени будет это выражение  
}
else // если будет не совподение то...
{
    Console.WriteLine("Иди спать, "); //при не совподении будет это вырожение 
    Console.WriteLine(username);
} 
