//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

const int Size = 10;
int[] numbers = CreateRandomArray(Size);
PrintArray(numbers);
int nemberOfEvenNumbers = FindEvenNumbers(numbers);
System.Console.WriteLine($"Количество чётных чисел в массиве {nemberOfEvenNumbers}");

void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    System.Console.WriteLine();
}

int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
            count += 1;
        }
    }
    return count;
}