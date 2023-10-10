// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите стартовое число M: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите финальное число N: ");
int b = Convert.ToInt32(Console.ReadLine());

SumFromMToN(a, b);

void SumFromMToN(int a, int b)
{
    Console.Write(SumMN(a - 1, b));
}
int SumMN(int a, int b)
{
    int result = a;
    if (a == b)
        return 0;
    else
    {
        a++;
        result = a + SumMN(a, b);
        return result;
    }
}

