//получает число с консоли. "Защита от дурака"
int GetNumberFromConsole(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

int number = GetNumberFromConsole("Enter the number: ");

double countOfNumber = Math.Floor(Math.Log10(number) + 1);
Console.WriteLine(countOfNumber);

