/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void FillTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            tab[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintTable(int[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Console.Write($"{tab[i, j]} ");
        }
        Console.WriteLine("");
    }
}

int SumInRow (int[,] tab, int row)
{
    int sum = 0;
    for (int i = 0; i < tab.GetLength(1); i++)
    {
        sum = sum + tab[row, i];
    }
    return sum;
}

int row = 5;
int col = 5;

int[, ] table = new int[row, col];
FillTable(table);
PrintTable(table);
int[] sum = new int[5];
sum[0] = SumInRow(table, 0);
sum[1] = SumInRow(table, 1);
sum[2] = SumInRow(table, 2);
sum[3] = SumInRow(table, 3);
sum[4] = SumInRow(table, 4);
Console.WriteLine(sum[0]);
Console.WriteLine(sum[1]);
Console.WriteLine(sum[2]);
Console.WriteLine(sum[3]);
Console.WriteLine(sum[4]);
int Min = sum[0];
int MinRow = 0;
for (int i = 1; i < table.GetLength(0); i++)
{
    if (Min > sum[i])
    {
        Min = sum[i];
        MinRow = i+1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinRow} строка");
