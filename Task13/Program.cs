// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number = new Random().Next(0, 999999999);

int getThreeDigitNumber(int number)
{
    while (number >= 1000) number = number / 10;
    return number;
}
    
int ThreeDigitNumber = getThreeDigitNumber(number);     
        if(ThreeDigitNumber < 100)
        {
            Console.WriteLine($"В числе {number} нет третьей цифры");
        }
        else
        {  int thirdDigit = ThreeDigitNumber % 10;
           Console.WriteLine($"В числе {number} третья цифра {thirdDigit}");
        }
    
    


