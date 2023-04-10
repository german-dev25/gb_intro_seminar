// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int PromptNumber(string prompt)
{
    Console.Write(prompt);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] GenerateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(random.NextDouble(), 2);
        }
    }

    return array;
}

void PrintArray(double[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = PromptNumber("Введите количество строк: ");
int n = PromptNumber("Введите количество столбцов: ");

double[,] array = GenerateRandomArray(m, n);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);
