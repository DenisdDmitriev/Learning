// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int rows = EnterData("Введите количество строк: ");
int colums = EnterData("Введите количество столбцов: ");
int[,] array = CreateRandomArray(rows, colums);

PrintArray(array);
Console.WriteLine();
RowWithMinSum(array);

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void RowWithMinSum(int[,] massive)
{
    int minRow = 0;
    int minSum = 0;
    int sum = 0;
    for (int i = 0; i < massive.GetLength(1); i++)
    {
        minRow = massive[0, i] + minRow;
    }
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            sum = massive[i, j] + sum;
        }
        if (sum < minRow)
        {
            minRow = sum;
            minSum = i;
        }
        sum = 0;
    }
    Console.Write($"Строка {minSum + 1}");
}

int[,] CreateRandomArray(int rows, int colums)
{
    int[,] massive = new int[rows, colums];
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            massive[i, j] = new Random().Next(10);
        }
    }
    return massive;
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
}