/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Entered not a number or less than 1");
        }

    }

    return result;
}

int[] NewArray(int elementsNumber)
{
    int[] newMassive = new int[elementsNumber];
    Random rnd = new Random(); 

    for (int i = 0; i < elementsNumber; i++)
    {
        newMassive[i] = rnd.Next(100, 1000);
        Console.WriteLine(newMassive[i]);
    }
    return newMassive;
}

int countElement = GetNumber("Enter number of array's elements ");
int[] ourArray = NewArray(countElement);


int NumberOfEvenNumbers = 0;
for (int i = 0; i < countElement; i++)
{
    if (ourArray[i] % 2 == 0)
    {
        NumberOfEvenNumbers++;
    }
}

Console.Write($"Number of even numbers in arrais is {NumberOfEvenNumbers}");

