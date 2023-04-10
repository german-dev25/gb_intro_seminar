// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Random N = new Random();

int[] arr = GenerateArray(N.Next(10));
Console.WriteLine("Сгенерированный массив:");
PrintArray(arr);

int count = CountEvenNumbers(arr);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");


int[] GenerateArray(int n)
{
    int[] arr = new int[n];
    Random rand = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    foreach (int number in arr)
    {
        Console.Write(number + " ");
    }
    Console.WriteLine();
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int number in arr)
    {
        if (number % 2 == 0)
        {
            count++;
        }
    }
    return count;
}