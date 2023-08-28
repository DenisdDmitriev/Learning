int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int rows = EnterData("Введите количество строк: ");
int colums = EnterData("Введите количество столбцов: ");
int[,] array = CreateRandomArray(rows, colums);

PrintArray(array);

int[,] SwapRowsArray(int[,] massive)
{
    int[,] matrix = new int[massive.GetLength(0), massive.GetLength(1)];
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        matrix[0, j] = massive[massive.GetLength(0) - 1, j];
    }
    for (int i = 1; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            matrix[i, j] = massive[i, j];
        }
    }    
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        matrix[matrix.GetLength(0) - 1, j] = massive[0, j];
    }
    return matrix;
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

int[,] swapRowsArray = SwapRowsArray(array);

Console.WriteLine();
PrintArray(swapRowsArray);