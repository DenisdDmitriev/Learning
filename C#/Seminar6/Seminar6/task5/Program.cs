int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue);
    }
    return massive;
}

int[] array = CreateRandomArray(5, 0, 10);


int[] CopyArray(int[] massive)
{
    int[] array = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        array[i] = massive[i];
    }
    return array;
}

int[] massive = CopyArray(array);

Console.Write($"[{String.Join(",", array)}] -> [{String.Join(",", massive)}]");


