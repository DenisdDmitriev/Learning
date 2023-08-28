int QuantityEvenNumbers(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] RandomMassive(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massive;
}

int[] array = RandomMassive(4, 100, 900);

int evenNumber = QuantityEvenNumbers(array);

Console.Write($"[{String.Join(",", array)}] -> {evenNumber}");