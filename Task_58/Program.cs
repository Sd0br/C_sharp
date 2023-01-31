/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

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

int[,] tableOne = {{2, 4},{3, 2}};
int[,] tableTwo = {{3, 4},{3, 3}};
int[,] tableRezult = new int[2, 2];

PrintTable(tableOne);
Console.WriteLine("");
PrintTable(tableTwo);

int i = 0;
int j = 0;

tableRezult [i, j] = tableOne[i, j] * tableTwo[i, j] + tableOne[i, j+1] * tableTwo[i+1, j];      
tableRezult [i, j+1] = tableOne[i, j] * tableTwo[i, j+1] + tableOne[i, j+1] * tableTwo[i+1, j+1];
tableRezult [i+1, j] = tableOne[i+1, j] * tableTwo[i, j] + tableOne[i+1, j+1] * tableTwo[i+1, j];
tableRezult [i+1, j+1] = tableOne[i+1, j] * tableTwo[i, j+1] + tableOne[i+1, j+1] * tableTwo[i+1, j+1];

Console.WriteLine("");
PrintTable(tableRezult);