/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int[,] table = new int [4, 4];
PrintTable(table);
int count = 1;

for (int n = 1; n <= 4; n++)
    {
        table[0, n-1] = count;
        count++;
    }
    
for (int n = 1; n < 4; n++)
    {
        table[n, 3] = count;
        count++;
    }

for (int n = 2; n >= 0; n--)
    {
        table[3, n] = count;
        count++;
    }


for (int n = 2; n >= 1; n--)
    {
        table[n, 0] = count;
        count++;
    }

for (int n = 1; n <= 2; n++)
  {
    Console.WriteLine("In for"); 
    table[1, n] = count;
    count++;
  }

for (int n = 2; n >= 1; n--)
 {
    table[2, n] = count;
    count++;
 }




Console.WriteLine("");
PrintTable(table);