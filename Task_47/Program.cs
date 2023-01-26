/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
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
    Random rndDouble = new Random(); 
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            tab[i, j] = (new Random().Next(1, 10)) * rndDouble.Next();
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


int row = GetNumber("Input rows number: ");
int col = GetNumber("Inpet columns number: ");

int[,] table = new int[row, col];
FillTable(table);
PrintTable(table);

