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
// Console.WriteLine(countOfNumber);
if (countOfNumber < 3)
    {
      Console.WriteLine("There isn't third number");
    }
else
    {
      string numberStr = number.ToString();
      Console.WriteLine(numberStr[2]);
    }
