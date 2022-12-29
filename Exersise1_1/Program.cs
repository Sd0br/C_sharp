int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Entered not a number or zero. Try again.");
        }
    }

    return result;
}

//int NumberOne = GetNumber("Input a number. More than zero.");
//Console.WriteLine(NumberOne);

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else
        return 4;
}

int x = GetNumber("Input coordinate X, not equel zero ");
int y = GetNumber("Input coordinate Y, not equel zero ");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Point with coordinates ({x}, {y}) belongs quarter {quarter}");


