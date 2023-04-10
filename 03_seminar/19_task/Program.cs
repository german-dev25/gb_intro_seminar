// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));

if (number < 10000 || number > 99999) {
Console.WriteLine("Число не является пятизначным");
} else {
int a = number / 10000;
int b = (number / 1000) % 10;
int c = (number / 10) % 10;
int d = number % 10;

if (a == d && b == c) {
    Console.WriteLine("Число является палиндромом");
} else {
    Console.WriteLine("Число не является палиндромом");
}
}