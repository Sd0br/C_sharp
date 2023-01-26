/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int row = 3;
int col = 3;

int[, ] table = new int[row, col];
FillTable(table);
PrintTable(table);

double sum = 0;

for (int i = 0; i < table.GetLength(1); i++)
{
    sum = 0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
        sum = sum + table[j, i];
    }
    Console.WriteLine(sum / table.GetLength(1));
}

