int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue+1);
    }
    return massive;
}

int[] ReplaceNumber(int[] massive)
{
    for (int i =0; i < massive.Length; i++)
    {
        massive[i] = -massive[i];
    }
    return massive;
}

int[] array = MakeRandomArray(4, -9, 9);
Console.Write($"{String.Join(", ", array)} -> ");
int[] massive = ReplaceNumber(array);
Console.WriteLine(String.Join(", ", massive));