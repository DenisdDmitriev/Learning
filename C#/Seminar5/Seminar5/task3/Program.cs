int findNumber = EnterData("Введите число: ");

string SearchNumber(int[] massive, int findNumber)
{
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] == findNumber)
        return "Да";
    }
    return "Нет";
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

int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int[] massive = MakeRandomArray(4, 0, 350);
Console.Write($"{findNumber}; массив {String.Join(", ", massive)} -> ");

Console.WriteLine(SearchNumber(massive, findNumber));