// записать трехзначное число и удалить среднее, 567 -> 57

int RemoveSecondDigit(int num) //функция
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = firstDigit * 10 + thirdDigit;
    return result;
}
int number = new Random().Next(100, 1000); //[100, 1000)
int res = RemoveSecondDigit(number);

Console.WriteLine($"в исходном числе {number} результат получим {res}");