// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Задайте финальное значение промежутка: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
NaturalToLow(num, count);

{
    if (num<1)
    {
    Console.Write("Натуральное число не может быть меньше 1");
    }
}
    
void NaturalToLow(int a, int count)
{
    if (count > a)
    {
        return;
    }
    else
    {
        NaturalToLow(a, count + 1);
        Console.Write(count + " ");
    }
}