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


//генерирует случайно число в границах [leftBoard, rightBoard]
int GetRandomNumber(int leftBoard, int rightBoard)
{
    Random rnd = new Random();

    int result = rnd.Next(leftBoard, rightBoard + 1); //[leftBoard, rightBoard)

    return result;
}

int leftRange = GetNumberFromConsole("Введите левую границу диапазона рандомного значения:");
int rightRange = GetNumberFromConsole("Введите правую границу диапазона рандомного значения:");
int number = GetRandomNumber(leftRange, rightRange);

Console.WriteLine($"Рандомное число: {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;

Console.WriteLine(result);

