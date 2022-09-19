// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] numbers = CreatArray(4, -100, 100);
PrintArray(numbers);
int sum = SummationOfOdd(numbers);
Console.WriteLine($"Сумма элементоа в массиве, стоящих на нечётных позициях равна {sum}");

int[] CreatArray(int size, int smalles, int baggest)
{
    int[] numbers = new int[size];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(smalles, baggest + 1);
    }
    return numbers;
}

void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int SummationOfOdd(int[] array)
{
    int sum = 0;
    for (int i = 1; i <= array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
