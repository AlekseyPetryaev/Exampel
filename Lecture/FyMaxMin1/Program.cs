// Находим минимальное значение в масиме 
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1}; //называем метод arr = {Задаем массив }
//на зываем метод ( указываем что сюда будет приходить )
void PritArray(int[] array)
{
    int count = array.Length;// задаем переменную массиву 

    for( int i = 0; i < count; i++)// прогоняем ее через весь массив 
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();/// будет делать отстум (пустая строка)
}

//PritArray(arr); простовыводит значение в терминал 
//Ответ: 1 5 4 3 2 6 7 1 1

void SelectionSort(int[] array)
{
    for(int i = 0 ; i < array.Length -1 ; i++)
    {
        int minPosition = i; //задаем мин позицию

        for(int j = i + 1 ; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }       
        int temporary = array[i]; // меняем позицыю минимального значения
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PritArray(arr);
SelectionSort(arr);

PritArray(arr);

//Ответ:
//1 5 4 3 2 6 7 1 1
//1 1 1 2 3 4 5 6 7
