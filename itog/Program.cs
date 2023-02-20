// формирует из исходного массива строк, массив длина элементов которого 3 или меньше символа

void PrintTable(string[] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        Console.Write($"{tab[i]} ");
    }
    Console.WriteLine();
}


string[] firstArray = {"Hello", "2", "world", ":-)"};
string[] secondArray = new string[firstArray.Length];

PrintTable(firstArray);


int count = 0;
for (int i = 0; i < firstArray.GetLength(0); i++)
{
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
}

PrintTable(secondArray);







