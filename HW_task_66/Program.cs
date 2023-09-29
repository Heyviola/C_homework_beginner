/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int InputNumbers(string message)
{
    Console.Write(message);
    int output = Convert.ToInt32(Console.ReadLine()!);
    return output;
}

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int m = InputNumbers("Введите значение M: ");
int n = InputNumbers("Введите значение N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);