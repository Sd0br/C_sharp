//Задача 10: Напишите программу,
//которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
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

int number = GetNumberFromConsole("Input three-digit number: ");
Console.WriteLine((number - 100 * (number / 100)) / 10);
