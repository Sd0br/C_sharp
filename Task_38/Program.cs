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

double[] NewArray(int elementsNumber)
{
    double[] newMassive = new double[elementsNumber];
    Random rnd = new Random();
    Random rndDouble = new Random(); 

    for (int i = 0; i < elementsNumber; i++)
    {
        newMassive[i] = rnd.Next(-2147483648, 2147483647)*rndDouble.NextDouble();
        Console.WriteLine(newMassive[i]);
    }
    return newMassive;
}

double MaxArray(double[] secondArray, int NumberOfElements)
{
   double max = secondArray[0];
   for (int i = 1; i < NumberOfElements; i++)
   {
    if (secondArray[i] > max)
    {
        max = secondArray[i];
    }
   }
    
   return max;
}

double MinArray(double[] secondArray, int NumberOfElements)
{
   double min = secondArray[0];
   for (int i = 1; i < NumberOfElements; i++)
   {
    if (secondArray[i] < min)
    {
        min = secondArray[i];
    }
   }
    
   return min;
} 

int countElement = GetNumber("Enter number of array's elements ");
double[] MainArray = NewArray(countElement);
double max = MaxArray(MainArray, countElement);
double min = MinArray(MainArray, countElement);
double difference = max-min;
Console.WriteLine($"Difference between max {max} and min {min} array element is {difference}");


