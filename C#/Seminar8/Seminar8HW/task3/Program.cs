// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = EnterData("Введите количество строк: ");
int colums = EnterData("Введите количество столбцов: ");
int[,] firstMatrix = CreateRandomArray(rows, colums);
int[,] secondMatrix = CreateRandomArray(rows, colums);
int[,] resultMatrix = CreateRandomArray(rows, colums);

PrintArray(firstMatrix);
Console.WriteLine();
PrintArray(secondMatrix);

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine(" Невозможно перемножить ");
    return;
}
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
}

Console.WriteLine();
PrintArray(resultMatrix);

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
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