// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = EnterData("Введите количество строк: ");
int colums = EnterData("Введите количество столбцов: ");
int[,] array = CreateRandomArray(rows, colums);

PrintArray(array);
Console.WriteLine();
DescendingRowsArray(array);
PrintArray(array);

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void DescendingRowsArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 1; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1) - 1; k++)
            {
                if (massive[i, k] < massive[i, k + 1])
                {
                    int count = massive[i, k + 1];
                    massive[i, k + 1] = massive[i, k];
                    massive[i, k] = count;
                }
            }
        }
    }
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