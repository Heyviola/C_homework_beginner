/* SЗадача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int FindSecondDigit(int num) //функция
{
    int secondDigit = num / 10;
    int firstDigit = num / 100;
    int result = secondDigit - firstDigit * 10;
    
    return result;
}
int number = new Random().Next(100, 1000); //[100, 1000)
int res = FindSecondDigit(number);

Console.WriteLine($"в исходном числе {number} вторая цифра {res}");