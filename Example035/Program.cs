// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат 
// в отрезке [10, 99].

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
int[] startArray = GetArray(123, 0, 150);

int[] GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}
Console.WriteLine($"Количество элементов в отрезке [10;99] = {GetCountElements(startArray, 10, 99)}");
