// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int size = 4;
int[,] array = new int[size,size];

CreateSpiralArray(array,size);
PrintArray(array);

void CreateSpiralArray(int[,] massive, int size)
{
    int i = 0;
    int j = 0;
    int count = 1;
    for (int a = 0; a < size * size; a++)
    {
        int k = 0;
        do { massive[i, j++] = count++; } while (++k < size - 1);
        for (k = 0; k < size - 1; k++) massive[i++, j] = count++;
        for (k = 0; k < size - 1; k++) massive[i, j--] = count++;
        for (k = 0; k < size - 1; k++) massive[i--, j] = count++;
        ++i; ++j;
        size = size < 2 ? 0 : size - 2;
    }
}

void PrintArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            if (massive[i,j] < 10)
            {
            Console.Write($"0{massive[i, j]} ");
            }
            else
            {
                Console.Write($"{massive[i,j]} ");
            }
        }
        Console.WriteLine();
    }
}