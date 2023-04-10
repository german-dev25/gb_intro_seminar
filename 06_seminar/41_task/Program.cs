// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

{
int m = PromptNumber("Введите количество чисел: ");
int[] numbers = new int[m];

for (int i = 0; i < m; i++)
{
    numbers[i] = PromptNumber($"Введите число {i + 1}: ");
}

int count = CountPositive(numbers);
Console.WriteLine($"Количество положительных чисел: {count}");
}

int PromptNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int CountPositive(int[] numbers)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number > 0)
        {
            count++;
        }
    }
    return count;
}