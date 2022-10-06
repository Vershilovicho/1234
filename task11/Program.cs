//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int twoDigit = number / 10;
int secontDigit = twoDigit % 10;

Console.WriteLine($"Вторая цифра числа: {secontDigit}");
