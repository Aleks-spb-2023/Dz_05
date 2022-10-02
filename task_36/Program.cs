/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

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
int counterEvenIndexNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            result += array[i];
        }
    }

    return result;
}

int leghtarray = new Random().Next(3,20);
int[] Spisok = getArrayrandomNumber(leghtarray,0, 99);
PrintArray(Spisok);
Console.WriteLine();
int suumIndex = counterEvenIndexNumber(Spisok);
Console.WriteLine($" Сумма элементов четных позиций = {suumIndex}");



