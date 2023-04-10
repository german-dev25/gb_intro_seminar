// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// создаем массив
double[] GenerateRandomArray()
{
    Random rnd = new Random();
    int length = rnd.Next(1, 11); 
    double[] arr = new double[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.NextDouble() * rnd.Next(200); 
    }
    return arr;
}

// находим разницу между максимальным и минимальным элементами массива
double FindDifference(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    foreach (double num in arr)
    {
        if (num < min)
        {
            min = num;
        }
        else if (num > max)
        {
            max = num;
        }
    }
    return max - min;
}

// запускаем
double[] arr = GenerateRandomArray();
Console.WriteLine("Массив: " + string.Join(", ", arr));
double diff = FindDifference(arr);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
