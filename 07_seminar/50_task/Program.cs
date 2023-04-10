// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] GenerateMatrix(int m, int n) {
    int[,] matrix = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            matrix[i, j] = rand.Next(1, 101); // заполняем случайными числами от 1 до 100
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) {
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write("{0, 4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

bool FindNumber(int[,] matrix, int number, out int row, out int column) {
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (row = 0; row < m; row++) {
        for (column = 0; column < n; column++) {
            if (matrix[row, column] == number) {
                return true;
            }
        }
    }
    row = -1;
    column = -1;
    return false;
}

Console.Write("Введите количество строк матрицы: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int n = int.Parse(Console.ReadLine());

int[,] matrix = GenerateMatrix(m, n);
Console.WriteLine("Сгенерированная матрица:");
PrintMatrix(matrix);

Console.Write("Введите число, которое нужно найти в матрице: ");
int number = int.Parse(Console.ReadLine());

int row, column;
if (FindNumber(matrix, number, out row, out column)) {
    Console.WriteLine("Число {0} находится в позиции [{1}, {2}]", number, row + 1, column + 1);
} else {
    Console.WriteLine("Число {0} не найдено в матрице", number);
}