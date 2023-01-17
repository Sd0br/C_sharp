/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int mainNumber = GetNumber("Enter number: ");
string numberToString = mainNumber.ToString();
int cycle = numberToString.Length;
int summ = 0;
int temp = 0;
string tempString;
for (int i = 0; i < cycle; i++)
{
    tempString = numberToString[i].ToString();
    int.TryParse(tempString, out temp);
    summ = summ + temp;
}

Console.WriteLine(summ);
