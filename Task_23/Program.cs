//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

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

int NumberOne = GetNumberFromConsole("Input number: ");
int Index = 1;

while (Index <= NumberOne)
{
    Console.WriteLine(Math.Pow(Index, 3));
    Index++;
}
