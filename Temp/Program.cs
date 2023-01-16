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
*/

Random rnd = new Random();
for (int i = 0; i < 100; i++)
{
    int a = rnd.Next(100, 1000);  
    Console.WriteLine(a);
}




