// формирует из исходного массива строк, массив длина элементов которого 3 или меньше символа

void PrintTable(string[] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        Console.Write($"{tab[i]} ");
    }
}


string[] firstArray = {"123", "asdfsasdf", "12345"};

PrintTable(firstArray);




