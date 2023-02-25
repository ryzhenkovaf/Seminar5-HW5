// /* **Задача 32:**Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие 
// отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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
int[] startArray = GetRandomArray(6, -10, 10);

int[] InversArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine(String.Join(" ", InversArray(startArray)));
