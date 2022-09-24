//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100, 1000);

Console.Write($"В числе {number} ");

number = number / 10;

Console.Write($"вторая цифра {number % 10} ");