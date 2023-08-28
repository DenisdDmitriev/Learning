int FindNumber (int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] >= 10 && massive[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massive;
}

int[] massive = MakeRandomArray(123, 0, 350);
int count = FindNumber(massive);

Console.Write("[");
Console.Write($"{String.Join(", ", massive)}] -> ");
Console.WriteLine(count);
