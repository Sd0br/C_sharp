/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortTable (int[,] tab)
{
    for (int n =0; n < tab.GetLength(0); n++)
    {
    for (int q = 0; q < tab.GetLength(1); q++)
    {
    int temp = tab [n, q];
    for (int i = q + 1; i < tab.GetLength(1); i++)
    {
        //Console.WriteLine($"{temp} and {tab[n, i]}"); 
          if (temp < tab[n, i])
          {
            temp = tab [n, i];
            tab [n, i] = tab [n, q];
            tab [n, q] = temp;
           }
           //Console.WriteLine("");
           //PrintTable(tab);
    }
    }
    }

}



int row = 3;
int col = 5;

int[, ] table = new int[row, col];
FillTable(table);
PrintTable(table);
SortTable(table);
Console.WriteLine("");
PrintTable(table);
