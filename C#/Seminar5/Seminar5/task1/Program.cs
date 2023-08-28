int GetSumElementsMinus(int[] massive)
{
    int sum = 0;
    for (int i =0; i < massive.Length; i++)
    {
        if(massive[i] < 0)
        {
            sum = sum + massive[i];
        }        
    }
    return sum;
}

int GetSumElementsPlus(int[] massive)
{
    int sum = 0;
    for (int i =0; i < massive.Length; i++)
    {
        if(massive[i] > 0)
        {
            sum = sum + massive[i];
        }        
    }
    return sum;
}

int[] MakeRandomArray(int size, int minValue, int maxValue)
{
    int[] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue+1);
    }
    return massive;
}

int[] array = MakeRandomArray(12, -9, 9);
Console.WriteLine(String.Join(",", array));
int sumPositiveNum = GetSumElementsPlus(array);
int sumNegativeNum = GetSumElementsMinus(array);
Console.WriteLine($"Sum of positive numbers -> {sumPositiveNum}, Sum of negative numbers -> {sumNegativeNum}");

