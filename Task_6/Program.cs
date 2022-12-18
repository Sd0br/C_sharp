//получает число с консоли. "Защита от дурака"
int GetNumberFromConsole(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

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

bool flag = false;
int firtstNumber = GetNumberFromConsole("Input first number");
int secondNumber = GetNumberFromConsole("Input second number");

if (firtstNumber*firtstNumber == secondNumber)
{
flag = true;
}

if (secondNumber*secondNumber == firtstNumber)
{
flag = true;
}

if (flag)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

