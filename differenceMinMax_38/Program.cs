// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

const int Size = 10;
float[] numbers = CreatArray(Size, -100, 100);
PrintArray(numbers);
float min = Min(numbers);
float max = Max(numbers);
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} в массиве равна {DifferenceMaxMin(min, max)}");


float[] CreatArray(int size, int smallest, int biggest)
{
    float[] array = new float[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(smallest, biggest + 1);
    }
    return array;
}

void PrintArray(float[] array)
{
    foreach (int number in array)
    {
        Console.Write ($"{number} ");
    }
    Console.WriteLine();
}

float Min(float[] array)
{
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

float Max(float[] array)
{
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

float DifferenceMaxMin(float Min, float Max)
{
    float difference = Max - Min;
    return difference;
}




