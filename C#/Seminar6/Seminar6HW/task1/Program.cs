int EnterData(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int quantityNumber = EnterData("Сколько чисел нужно ввести? ");
int positiveNumber = 0;
int count = 0;

while (count < quantityNumber)
{
    int number = EnterData("Введите число: ");
    
    if (number > 0)
    {
        positiveNumber++;
        count++;
    }
    else 
    {
        count++;
    }
   }

    Console.Write($"Количество положительных чисел - {positiveNumber}");

