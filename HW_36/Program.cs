// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] startArray = GetRandomArray(10, 10, 100);

int GetCountSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}
PrintArray(startArray);
Console.WriteLine($"Сумма элементов на нечетных позициях = {GetCountSumOdd(startArray)}");

void PrintArray(int[] startArray)
{
    for(int i = 0; i < startArray.Length; i++)
    {
        Console.Write(startArray[i] + " ");
    }
    Console.WriteLine();
}
