// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = CreateRandomArray(3, 4);

double SearchArithMean(int[,] massive)
{
    double result = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (j == 0)
            {
                result = massive[i, j] + result;
            }
        }
    }
    return result;
    Console.Write(result);

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

int[,] CreateRandomArray(int rows, int colums)
{
    int[,] massive = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            massive[i, j] = new Random().Next(10);
        }
    }
    return massive;
}

PrintArray(array);

double searchArithMean = SearchArithMean(array);

//Console.Write($"{searchArithMean / 3}");

