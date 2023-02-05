/*Задача 41 Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел Пользователь.
0, 7, 8, -2, -2, -> 2
1, -7, 567, 89, 223, -> 3*/

Console.Clear();
/*
int[] ReadArray(int Length, int min, int max) 
{
    int[] array = new int[Length];
    for(int i = 0; i < Length ; i++)
    {
        Console.Write("Введите элемент: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }   
    return array;   
}

int PrintArray(int[] array)
{
    int count = 0;///////////////////////////////////////////////////////////////
    for(int i = 0; i < array.Length; i++)
    {       
        if(array[i] > 0 ) count ++;
    }   
    return count;
}

int[] array = ReadArray(7, -1000, 1000 );
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Ответ: {PrintArray(array)}");
*/
///Начало 2

//Вариант 2 

Console.Write("Введите числа через запятую: ");
  int[] numbers = StringToNum(Console.ReadLine()!);
  PrintArray(numbers);
  int sum = 0;
  for (int i = 0; i < numbers.Length; i++)
  {
      if (numbers[i] > 0) sum++;
  }
  Console.WriteLine();
  Console.WriteLine($"количество значений больше 0 = {sum}");
  
  int[] StringToNum(string input)
  {
      int count = 1;
      for (int i = 0; i < input.Length; i++)
      {
        if (input[i] == ' ') count++;
      }
  
      int[] numbers = new int [count];
      int index = 0;
  
      for (int i = 0; i < input.Length; i++)
      {
          string temp = "";
  
          while (input [i] != ' ')
          {
          if(i != input.Length - 1)
          {
            temp += input [i].ToString(); i++;
          }
          else
          {
              temp += input [i].ToString();
              break;
          }
          }
          numbers[index] = Convert.ToInt32(temp);
          index++;
      }
      return numbers;
  }
  
  void PrintArray(int[] array)
  {
      for (int i = 0; i < array.Length; i++)
      {
          Console.Write(array[i] + " ");
      }
  }

