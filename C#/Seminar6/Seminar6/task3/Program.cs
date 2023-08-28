string NumTwo(int numb)
{
    string binaryNumber = "";
    while (numb > 0)
    {
        binaryNumber = numb % 2 + binaryNumber;
        numb = numb / 2;
    }
    return binaryNumber;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int num = EnterData("Введите число ");
string numTwo = NumTwo(num);
Console.WriteLine($"{num} -> {numTwo}");
