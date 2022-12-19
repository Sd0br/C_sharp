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

int numberOne = GetNumberFromConsole("Enter the number: ");
if ((numberOne%2) == 0)
    {
        Console.WriteLine($"Number {numberOne} is even");
    }
else
    {
        Console.WriteLine($"Number {numberOne} is odd");
    }