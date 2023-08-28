// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];

CreateNonRepeatarray(array);
PrintIndexArray(array);

void CreateNonRepeatarray(int[,,] massive)
{
    int number = 10;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            for (int k = 0; k < massive.GetLength(1); k++)
            {
                massive[k, i, j] = massive[k, i, j] + number;
                number++;
            }
        }
    }
}

void PrintIndexArray(int[,,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < massive.GetLength(2); k++)
            {
                Console.Write($"{massive[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}