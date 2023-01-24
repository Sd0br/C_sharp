/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int PositiveNumbersInArray(int[] array)

{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Enter multiple numbers through ,: ");
string mainString = Console.ReadLine();
string[] twoString = mainString.Split(",");
//Console.WriteLine(twoString.Length);
int[] newArray = new int[twoString.Length];
for (int i = 0; i < twoString.Length; i++)
{
     //Console.WriteLine(twoString[i]);
     int.TryParse(twoString[i], out newArray[i]);
}

PrintArray(newArray);
Console.Write("Positive numbers in array is: ");
Console.WriteLine(PositiveNumbersInArray(newArray));


