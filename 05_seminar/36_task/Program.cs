// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random N = new Random();

int[] arr = GenerateArray(N.Next(10));
Console.WriteLine("Сгенерированный массив:");
PrintArray(arr);

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

int SumOfEvenElements(int[] arr) 
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) {
        sum += arr[i];
    }
    return sum;
}

Console.WriteLine("Сумма элементов на нечетных позициях: " + SumOfEvenElements(arr));