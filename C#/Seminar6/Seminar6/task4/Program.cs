int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int count = 0;
int firstNum = 0;
int secondNum = 1;
int sum = 0;
int N = EnterData("Введите число: ");
int maxCount = N-1;

Console.Write($"Если N = {N} -> 0");
while (count < maxCount)
{
   sum = secondNum + sum;
   count++;
   Console.Write($"{sum}");
   secondNum = sum - secondNum;
}
