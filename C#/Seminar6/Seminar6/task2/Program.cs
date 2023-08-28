int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int a = EnterData("Введите число: ");
int b = EnterData("Введите число: ");
int c = EnterData("Введите число: ");
// if (a < b+c && b < a+c && c < a+b)
// {
//     Console.WriteLine("Да");
// } 
// else Console.WriteLine("Нет");

string TriangleSide(int a, int b, int c)
{
    if (a < b+c && b < a+c && c < a+b)
    {
        return "Да";
    }
    else
    {
        return "Нет";
    }
}

Console.WriteLine(TriangleSide(a, b, c));