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

int firtstNumber = GetNumberFromConsole("Input first number: ");
int secondNumber = GetNumberFromConsole("Input second number: ");

if (firtstNumber == secondNumber)
    {
        Console.WriteLine("The numbers are equal");
    }
else
    if (firtstNumber > secondNumber)
        {
           Console.WriteLine($"The number {firtstNumber} is more"); 
        }
    else
        {
           Console.WriteLine($"The number {secondNumber} is more");  
        }

