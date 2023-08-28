// int[] array = {1,2,3,4,5};
// int[] massive = {array[4], array[3], array[2], array[1], array[0]};
// Console.Write($"[{String.Join("," ,massive)}] -> [{String.Join("," ,massive)}]");


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


int[] FlipArray(int[] massive)
{
    int[] array = new int[massive.Length];
    for (int i = 0; i < massive.Length; i++)
    {
        array[i] = massive[massive.Length - 1 - i];
    }
    return array;
}

int[] massive = FlipArray(array);

Console.Write($"[{String.Join(",", array)}] -> [{String.Join(",", massive)}]");


