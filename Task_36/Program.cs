/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        newMassive[i] = rnd.Next();
        Console.WriteLine(newMassive[i]);
    }
    return newMassive;
}

int countElement = GetNumber("Enter number of array's elements ");
int[] ourArray = NewArray(countElement);

double summOfOddElements = 0;
for (int i = 0; i < countElement; i = i + 2)
{
    summOfOddElements = summOfOddElements + ourArray[i];
}

Console.WriteLine($"Summ of odd elements is {summOfOddElements}");