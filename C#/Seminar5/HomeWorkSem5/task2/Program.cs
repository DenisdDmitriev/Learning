int SumOddNumbersMassive(int[] massive)
{
    int sum = 0;
    for (int i = 1; i < massive.Length; i++)
    {
        sum = sum + massive[i];
        i++;
    }
    return sum;
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

int[] array = RandomMassive(10, 0, 100);

int oddNumbersSum = SumOddNumbersMassive(array);

Console.Write($"[{String.Join(",", array)}] -> {oddNumbersSum}");