/*
Напиште программу, которая принимает на вход число N и выдает произведение числе от 1 до N.
*/


void GetProd()
{
    Console.WriteLine("Введите число N: ");
    int num = int.Parse(Console.ReadLine() ??"");
    int prod = 1;
    for (int  i  = 1; i <= num; i ++ )
    {
        prod = prod * i;
    }
    
    Console.WriteLine($"{num} -> {prod}");
}
GetProd();
