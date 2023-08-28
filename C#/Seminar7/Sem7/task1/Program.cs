int m = EnterData("Задайте количество строк: ");
int n = EnterData("Задайте количество столбцов: ");
int[,] array = CreateArray(m,n);


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

int[,] CreateArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

PrintArray(array);