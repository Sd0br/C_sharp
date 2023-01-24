/*
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или меньше 1");
        }

    }

    return result;

}

int GetSumm(int number)
{
    int summ = 0;

    for (int i = 0; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число больше 1");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до  {number} = {summ}");


Random rnd = new Random();
for (int i = 0; i < 100; i++)
{
    int a = rnd.Next(100, 1000);  
    Console.WriteLine(a);
}



int[] InitArray(int dimenssion)
{
    int[] arr = new int[dimenssion];
    Random rnd = new Random();
    for (int i = 0; i < dimenssion; i++)
    {
        arr[i] = rnd.Next(1,10);
    }

    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] ReverseArray(int[] array)

{
    int[] result = new int[array.Length];
    int count = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        result[count] = array[i];
        count++;
    }
    return result;
}

Console.WriteLine("Введите размерность массива");
int dimenssion = int.Parse(Console.ReadLine());
int[] arr = InitArray(dimenssion);
int[] reverseArr = ReverseArray(arr);

PrintArray(arr);

PrintArray(reverseArr);

*/

Console.WriteLine("Input a number");
int dimenssion = int.Parse(Console.ReadLine());
int[] ourArray =new int[dimenssion];
ourArray[0] = 0;
ourArray[1] = 1;
for (int i = 2; i < dimenssion; i++)
{
    ourArray[i] = ourArray[i - 1] + ourArray[i - 2];
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(ourArray);

