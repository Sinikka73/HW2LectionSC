// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int number = new Random().Next(1, 8);

//if (number == 1) Console.WriteLine($"Цифра{number} означает, что день не является выходным");
//else if (number == 2) Console.WriteLine($"Цифра {number} означает, что день не является выходным");
//else if (number == 3) Console.WriteLine($"Цифра {number} означает, что день не является выходным");
//else if (number == 4) Console.WriteLine($"Цифра {number} означает, что день не является выходным");
//else if (number == 5) Console.WriteLine($"Цифра {number} означает, что день не является выходным");
//else if (number == 6) Console.WriteLine($"Цифра {number} означает, что день является выходным - это суббота!");
//else if (number == 7) Console.WriteLine($"Цифра {number} означает, что день является выходным - воскресенье");

if(number > 5) Console.WriteLine($"Цифра {number} соответствует выходному дню!");
else Console.WriteLine($"Цифра {number} соответствует рабочему дню");