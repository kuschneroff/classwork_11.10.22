/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

//метод который получает число с консоли
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ??"");
    return result;
}

int GetSumm(int a)
{
    int summ = 0;
    for (int i = 1; i <= a; i++)
    {
        summ += i;
    }
    return summ;
}

int a = GetNumber("Введите число А:");
int summ = GetSumm(a);

Console.WriteLine($"Сумма чисел от 1 до {a} = {summ}");
