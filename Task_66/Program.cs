/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int NumberRec (int a, int b)
{
    if (a == b)
    {
        return b;
    }
    else
    {
        return a + NumberRec(a+1, b);
    }
}


int NumberM = GetNumberFromConsole("Input number M: ");
int NumberN = GetNumberFromConsole("Input number N: ");


Console.WriteLine(NumberRec(NumberM, NumberN));
