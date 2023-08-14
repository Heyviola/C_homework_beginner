Console.WriteLine("Введите число: ");
string num = Console.ReadLine ()!;
int number = int.Parse (num)!; // = int.Parse (Console.ReadLine ()!); - преобразовать в цифру то, что введут в console. Readline

int square = number * number;
Console.WriteLine ("Квадрат числа " + number + " равен " + square);