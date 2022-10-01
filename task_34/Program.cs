/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int [] getArrayrandomNumber(int lenght, int start, int end)
{
    int[] resultArray = new int[lenght];
    for (int i = 0; i < resultArray.Length ; i++)
    {
        resultArray[i] = new Random().Next(start, end);
    }
    return resultArray;
}
void PrintArray(int[] array)

{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length)
        {
            Console.Write(",");
        }
       
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");

}
int counterEvenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result += 1;
        }
    }

    return result;
}

int leghtarray = new Random().Next(3,20);
int[] Spisok = getArrayrandomNumber(leghtarray,100, 999);
PrintArray(Spisok);
int count = counterEvenNumber(Spisok);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел данного списка = {count}");



