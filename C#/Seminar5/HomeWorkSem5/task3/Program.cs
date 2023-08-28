int[] array = RandomMassive(5, 0, 100);

int min = array[0];
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
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

Console.Write($"[{String.Join(",", array)}] -> {max - min}");