int m = EnterData("Задайте количество строк: ");
int n = EnterData("Задайте количество столбцов: ");
int[,] array = CreateArray(m, n, -10, 10);

int[,] SqrtArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        if (i % 2 != 0 && j % 2 != 0)
        {
            array[i, j] = array[i, j] * array[i, j] ;
        }
    }
    return array;
}

int EnterData (string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] CreateArray(int rows, int colums, int min, int max)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

PrintArray(array);
Console.WriteLine();

int[,] massive = SqrtArray(array);

PrintArray(massive);