// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// Random N = new Random();

// int[] arr = GenerateArray(N.Next(10));
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(arr);

// int count = CountEvenNumbers(arr);
// Console.WriteLine($"Количество чётных чисел в массиве: {count}");


// int[] GenerateArray(int n)
// {
//     int[] arr = new int[n];
//     Random rand = new Random();

//     for (int i = 0; i < n; i++)
//     {
//         arr[i] = rand.Next(100, 1000);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     foreach (int number in arr)
//     {
//         Console.Write(number + " ");
//     }
//     Console.WriteLine();
// }

// static int CountEvenNumbers(int[] arr)
// {
//     int count = 0;
//     foreach (int number in arr)
//     {
//         if (number % 2 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// Random N = new Random();

// int[] arr = GenerateArray(N.Next(10));
// Console.WriteLine("Сгенерированный массив:");
// PrintArray(arr);

// int[] GenerateArray(int n)
// {
//     int[] arr = new int[n];
//     Random rand = new Random();

//     for (int i = 0; i < n; i++)
//     {
//         arr[i] = rand.Next(100, 1000);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     foreach (int number in arr)
//     {
//         Console.Write(number + " ");
//     }
//     Console.WriteLine();
// }

// int SumOfEvenElements(int[] arr) 
// {
//     int sum = 0;
//     for (int i = 1; i < arr.Length; i += 2) {
//         sum += arr[i];
//     }
//     return sum;
// }

// Console.WriteLine("Сумма элементов на нечетных позициях: " + SumOfEvenElements(arr));


// // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// // создаем массив
// double[] GenerateRandomArray()
// {
//     Random rnd = new Random();
//     int length = rnd.Next(1, 11); 
//     double[] arr = new double[length];
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = rnd.NextDouble() * rnd.Next(200); 
//     }
//     return arr;
// }

// // находим разницу между максимальным и минимальным элементами массива
// double FindDifference(double[] arr)
// {
//     double min = arr[0];
//     double max = arr[0];
//     foreach (double num in arr)
//     {
//         if (num < min)
//         {
//             min = num;
//         }
//         else if (num > max)
//         {
//             max = num;
//         }
//     }
//     return max - min;
// }

// // запускаем
// double[] arr = GenerateRandomArray();
// Console.WriteLine("Массив: " + string.Join(", ", arr));
// double diff = FindDifference(arr);
// Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
