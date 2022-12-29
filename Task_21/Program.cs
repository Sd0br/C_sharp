//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

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
            Console.WriteLine("Input not a number.");
        }
    }

    return result;
}

//first point
Console.WriteLine("This programm calcuate the distance between two points in 3D ");
int X1 = GetNumberFromConsole("Input X1 ");
int Y1 = GetNumberFromConsole("Input Y1 ");
int Z1 = GetNumberFromConsole("Input Z1 ");

//second point
int X2 = GetNumberFromConsole("Input X2 ");
int Y2 = GetNumberFromConsole("Input Y2 ");
int Z2 = GetNumberFromConsole("Input Z2 ");

Console.WriteLine ($"The distance between two points in 3D is {Math.Sqrt(Math.Pow(X1-X2, 2) + Math.Pow(Y1-Y2, 2) + Math.Pow(Z1-Z2, 2))}");

