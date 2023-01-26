/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Entered not a number or less than 1");
        }

    }

    return result;
}

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

int row = 5;
int col = 5;
int[, ] table = new int[row, col];
FillTable(table);
PrintTable(table);
int rowNumber = GetNumber("Enter row: ");
int colNumber = GetNumber("Enter col: ");

if ((rowNumber < 0) || (rowNumber > table.GetLength(0)) || (colNumber < 0) || (colNumber > table.GetLength(1)))
{
    Console.WriteLine($"The number in position {rowNumber} {colNumber} dosn't exists");
}
else
{
    Console.WriteLine($"The number in position {rowNumber} {colNumber} is {table[rowNumber, colNumber]}");
}


