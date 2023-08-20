/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int dayOff(int number)
{
    int day = 0;
    if(day >= 1 && day <= 5)
    {
    Console.WriteLine(" - нет");
    }
    Console.WriteLine(" - да");
    return day;
}
Console.WriteLine("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine()!);

int  rest = dayOff(number);
Console.WriteLine(rest);