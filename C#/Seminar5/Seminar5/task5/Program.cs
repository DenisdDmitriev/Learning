int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue+1);
    }
    return massive;
}

string MultArrayNumber (int[] massive)
{
    for (int i = 0; i < 2; i++)
    {
        Console.Write($"{massive[i] * massive[massive.Length - i -1]}, ");
    } 
    Console.Write(massive[2]);
    return "";
}
Console.Write("[");
int[] array = MakeRandomArray(5, 0, 9);
Console.Write($"{String.Join(",", array)}] -> ");
MultArrayNumber(array);

