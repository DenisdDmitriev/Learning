// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m = EnterData("Введите номер строки: ");
int n = EnterData("Введите номер столбца: ");
int[,] array = CreateRandomArray(3, 4);

string SearchRowsAndColums(int[,] massive)
{   if (m >= massive.GetLength(0) | n >= massive.GetLength(1)) Console.Write($"Элемента с позицией [{m},{n}] в массиве нет");
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (m == i && n == j) Console.Write($"Элемент с позицией [{i},{j}] равен {massive[i, j]}");
        }
    }
    return "";
} 

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandomArray (int rows, int colums)
{
    int[,] massive = new int [rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            massive [i, j] = new Random().Next(-10, 10);
        }
    }
    return massive;
}

PrintArray(array);
string searchNumber = SearchRowsAndColums(array);