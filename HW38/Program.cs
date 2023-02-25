// Задача 38: Задайте массив целых чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

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

int FindDiff (int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    int dif = max - min;
    return dif;
}
PrintArray(startArray);
Console.WriteLine($"Разница между числами: {FindDiff(startArray)}");

void PrintArray(int[] startArray)
{
    for(int i = 0; i < startArray.Length; i++)
    {
        Console.Write(startArray[i] + " ");
    }
    Console.WriteLine();
}
