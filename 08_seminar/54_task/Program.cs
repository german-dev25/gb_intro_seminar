// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GenerateRandomMatrix()
{
    Random rand = new Random();

    // генерируем случайный размер массива от 2 до 5
    int size = rand.Next(2, 6);

    // создаем массив заданного размера и заполняем случайными числами
    int[,] matrix = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            matrix[i, j] = rand.Next(10);
        }
    }

    return matrix;
}

void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // создаем временный массив для сортировки строки
        int[] temp = new int[matrix.GetLength(1)];

        // копируем текущую строку во временный массив
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp[j] = matrix[i, j];
        }

        // сортируем временный массив по убыванию
        Array.Sort(temp);
        Array.Reverse(temp);

        // копируем отсортированные значения обратно в исходную строку
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = temp[j];
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// генерируем случайный двумерный массив
int[,] matrix = GenerateRandomMatrix();

Console.WriteLine("Исходный массив:");
PrintMatrix(matrix);

// сортируем каждую строку массива по убыванию
SortMatrix(matrix);

Console.WriteLine("Упорядоченный массив:");
PrintMatrix(matrix);