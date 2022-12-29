//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

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

string NumberToString = (GetNumberFromConsole("Input number: ")).ToString();

int NumberLength = NumberToString.Length;
int index = 0;
bool Flag = true;

while (index < NumberLength / 2)
{
//Console.WriteLine(index);
if (NumberToString[index] != NumberToString[NumberLength - index -1])
    {
        Flag = false;
        Console.WriteLine($"The number {NumberToString} is not a palindrome");
        break;
    }
index++;  
}

if (Flag)
    {
        Console.WriteLine($"The number {NumberToString} is a palindrome");
    }