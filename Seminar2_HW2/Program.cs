﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int FindThirdDigit(int number);
{
 if (number >=100)
    {
     while (number > 999)
     {
        number = number / 10;
     }
        int result = number % 10;
    }
    else
    {
     int result = -1;
    }
 return result;
}

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
 
if (ThirdDigit(number1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Third digit is {ThirdDigit(number1)}");