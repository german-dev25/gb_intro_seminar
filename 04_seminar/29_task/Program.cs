// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

static int[] GenerateRandomArray(int N)
{
    Random rnd = new Random();
    int[] arr = new int[N];

    for (int i = 0; i < N; i++)
    {
        arr[i] = rnd.Next(1, 101);
    }

    return arr;
}

Console.WriteLine("Введите количество элементов массива:");
int N = int.Parse(Console.ReadLine());

int[] arr = GenerateRandomArray(N);

Console.WriteLine("Сгенерированный массив:");
foreach (int element in arr)
{
    Console.Write(element + " ");
}