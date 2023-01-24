/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string message)
{
    double result = 0;

    while(true)
    {
        Console.Write(message);

        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Entered not a number");
        }

    }

    return result;
}

double b1 = GetNumber("Enter number B1: ");
double b2 = GetNumber("Enter number B2: ");
double k1 = GetNumber("Enter number K1: ");
double k2 = GetNumber("Enter number K2: ");

double x =  ((b2 - b1) / (k1 - k2));
double y = k1 * x + b1;


Console.WriteLine($"X is {x}");
Console.WriteLine($"Y is {y}");

