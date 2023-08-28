// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] CreateArray()
{
    Console.Write("Укажите размер массива: ");
    int size = int.Parse(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Задайте {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}


// void PrintArray(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }    
//     Console.WriteLine();
// }


string[] ResultArray(string[] array)
{
    int k = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        k++;
    }
    string[] resultArray = new string[k];
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        } 
    }
    return resultArray;
}


string[] array = CreateArray();
// Console.WriteLine("Начальный массив: ");
// PrintArray(array);
string[] arrayResult = ResultArray(array);
// Console.WriteLine();
// Console.WriteLine("Итоговый массив: ");
// PrintArray(arrayResult);
Console.WriteLine("Преобразование исходного массива в итоговый: ");
Console.Write($"[{String.Join(",", array)}] -> [{String.Join(",", arrayResult)}]");