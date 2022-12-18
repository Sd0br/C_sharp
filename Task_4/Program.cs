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

int ReturnMaxNumber (int numberOne, int numberTwo)
{
    int max = numberOne;
    if (numberTwo > numberOne)
    {
        max = numberTwo;
    }
   
    return max;
}

int firtstNumber = GetNumberFromConsole("Input first number: ");
int secondNumber = GetNumberFromConsole("Input second number: ");
int thirdNumber = GetNumberFromConsole("Input third number: ");

int max = firtstNumber;

max = ReturnMaxNumber(firtstNumber, secondNumber);
max = ReturnMaxNumber(max, thirdNumber);

Console.WriteLine ($"Maximum number is  {max}");