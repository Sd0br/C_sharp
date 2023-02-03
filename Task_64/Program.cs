/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

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
            Console.WriteLine("Input not a number.");
        }
    }

    return result;
}

string NumberRec (int a)
{
    if (a >= 1)
    {
        return $"{a} " + NumberRec(a - 1);
    }
    else
    {
        return String.Empty;
    }
}


int NumberOne = GetNumberFromConsole("Input number: ");
Console.WriteLine(NumberRec(NumberOne));


