double[] array = new double[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 10;
    array[i] = Math.Round(array[i],2);
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length)
        {
            Console.Write(" . ");
        }
       
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

double minElement(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        
        if(array[i + 1] < min)
        {
            min = array[i + 1];
        }
    }

    return min;
}

double maxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length - 1; i++)
    {
        
        if(array[i + 1] > max)
        {
            max = array[i + 1];
        }
    }

    return max;
}

PrintArray(array);  
double minimum =  minElement(array);
double maximum = maxElement(array);
Console.WriteLine();
Console.WriteLine($"Разница между {maximum} и {minimum} = {maximum - minimum }");
